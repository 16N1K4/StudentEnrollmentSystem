using Microsoft.AspNetCore.Identity;
using StudentEnrollmentAPI.Data;
using StudentEnrollmentAPI.IRepository;
using StudentEnrollmentAPI.Models;
using StudentEnrollmentAPI.Repository;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.IdentityModel.Tokens;
using System.Text;
using Microsoft.OpenApi.Models;
using System.Reflection.Metadata.Ecma335;
using Microsoft.EntityFrameworkCore;
using StudentEnrollmentAPI.DTO;
using StudentEnrollmentAPI.Middleware;
using StudentEnrollmentAPI.ViewModels;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();

//configure JWT
builder.Services.AddSwaggerGen(opt =>
{
    opt.SwaggerDoc("v1", new OpenApiInfo { Title = "StudentEnrollmentAPI", Version = "v1" });
    opt.AddSecurityDefinition("Bearer", new OpenApiSecurityScheme
    {
        In = ParameterLocation.Header,
        Description = "Please enter token",
        Name = "Authorization",
        Type = SecuritySchemeType.Http,
        BearerFormat = "JWT",
        Scheme = "bearer"
    });

    opt.AddSecurityRequirement(new OpenApiSecurityRequirement
    {
        {
            new OpenApiSecurityScheme
            {
                Reference = new OpenApiReference
                {
                    Type=ReferenceType.SecurityScheme,
                    Id="Bearer"
                }
            },
            new string[]{}
        }
    });
}
    );

//DB-related dependency injections
builder.Services.AddDbContext<SESContext>();
builder.Services.AddScoped<SESContext, SESContext>();
builder.Services.AddScoped<ISubjectRepo, SubjectRepo>();
builder.Services.AddScoped<IEnrollmentRepo, EnrollmentRepo>();
builder.Services.AddScoped<ICourseRepo, CourseRepo>();

var MyAllowSpecificOrigins = "_myAllowSpecificOrigins";

builder.Services.AddCors(options =>
{
    options.AddPolicy(
        name: MyAllowSpecificOrigins, policy =>
        {
            policy.AllowAnyOrigin().AllowAnyHeader().AllowAnyMethod();
        }
        );
});


//JWT variables
var issuer = builder.Configuration["JWT:Issuer"];
var audience = builder.Configuration["JWT:Audience"];
var key = builder.Configuration["JWT:Key"];

//add JWT authentication
builder.Services.AddAuthentication(options =>
{
    options.DefaultAuthenticateScheme = JwtBearerDefaults.AuthenticationScheme;
    options.DefaultChallengeScheme = JwtBearerDefaults.AuthenticationScheme;
    options.DefaultScheme = JwtBearerDefaults.AuthenticationScheme;
}).AddJwtBearer(options =>
{
    options.RequireHttpsMetadata = false;
    options.SaveToken = true;
    options.TokenValidationParameters = new Microsoft.IdentityModel.Tokens.TokenValidationParameters
    {
        ValidateIssuer = true,
        ValidateAudience = true,
        ValidIssuer = issuer,
        ValidAudience = audience,
        IssuerSigningKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(key))
    };
});

//identity framework
builder.Services.AddIdentity<ApplicationUser, IdentityRole>()
    .AddEntityFrameworkStores<SESContext>()
    .AddDefaultTokenProviders();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

//view all courses
app.MapGet("api/v1/course", async (SESContext _context) =>
{
    var CourseList = await _context.Courses.FromSqlRaw("EXEC view_all_courses").ToListAsync();
    List<CourseDTO> courses = new List<CourseDTO>();
    foreach (var Course in CourseList)
    {
        courses.Add(new CourseDTO
        {
            ID = Course.ID,
            Name = Course.Name,
            DeptID = Course.DeptID
        });
    }

    return Results.Ok(courses);
}
).AllowAnonymous();

app.MapGet("api/v1/course/{id}", async (SESContext _context, int id) =>
{
    var course = await _context.Courses.FromSqlRaw("EXEC view_one_course {0}", id).ToListAsync();
    if (_context.Courses.FirstOrDefault(crs => crs.ID == id) == null)
    {
        return Results.NotFound();
    }
    CourseViewModel crs = new CourseViewModel{
        ID = course.First().ID,
        Name = course.First().Name,
        DeptName = _context.Departments.FirstOrDefault(dept => dept.ID == course.First().DeptID).Name
    };
    return Results.Ok(crs);
}
);

app.MapPost("api/v1/course", async (SESContext _context, Course crs) =>
{
    if(crs.DeptID == null || crs.Name == null)
    {
        return Results.BadRequest();
    }
    await _context.Database.ExecuteSqlRawAsync("EXEC add_course {0}, {1}", crs.Name, crs.DeptID);
    await _context.SaveChangesAsync();

    var courses = _context.Courses.ToList();
    int newID = courses.MaxBy(course => course.ID).ID;

    CourseDTO newCourse = new CourseDTO
    {
        ID = newID,
        Name = crs.Name,
        DeptID = crs.DeptID
    };
    
    return Results.Created($"api/v1/course/{newID}", newCourse);
});

app.MapPut("api/v1/course/{id}", async (SESContext _context, int id, Course crs) =>
{
    if(_context.Courses.FirstOrDefault(course => course.ID == id) == null)
    {
        return Results.NotFound();
    }
    if (crs.DeptID == null || crs.Name == null)
    {
        return Results.BadRequest();
    }
    await _context.Database.ExecuteSqlRawAsync("EXEC update_course {0}, {1}, {2}", id, crs.Name, crs.DeptID);
    await _context.SaveChangesAsync();

    CourseDTO newCourse = new CourseDTO
    {
        ID = id,
        Name = crs.Name,
        DeptID = crs.DeptID
    };

    return Results.Ok(newCourse);
});

app.MapDelete("api/v1/course/{id}", async (SESContext _context, int id) =>
{
    if (_context.Courses.FirstOrDefault(crs => crs.ID == id) == null)
    {
        return Results.NotFound();
    }
    await _context.Database.ExecuteSqlRawAsync("EXEC delete_course {0}", id);
    await _context.SaveChangesAsync();

    return Results.Ok();
});

app.UseCors(MyAllowSpecificOrigins);
app.UseAuthentication();
app.UseAuthorization();
app.UseMiddleware<AuthenticateAPIKey>();

app.MapControllers();

app.Run();
