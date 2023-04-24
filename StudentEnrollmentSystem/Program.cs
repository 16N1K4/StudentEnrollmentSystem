using Microsoft.AspNetCore.Identity;
using StudentEnrollmentSystem.Data;
using StudentEnrollmentSystem.IRepository;
using StudentEnrollmentSystem.Models;
using StudentEnrollmentSystem.Repository;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews().AddDataAnnotationsLocalization();

builder.Services.AddDbContext<SESContext>();
builder.Services.AddScoped<SESContext, SESContext>();
builder.Services.AddScoped<IDepartmentRepo, DepartmentRepo>();
builder.Services.AddScoped<ICourseRepo, CourseRepo>();
builder.Services.AddScoped<IFacultyRepo, FacultyRepo>();
builder.Services.AddScoped<ISubjectRepo, SubjectRepo>();
builder.Services.AddScoped<IEnrollmentRepo, EnrollmentRepo>();
builder.Services.AddScoped<IAccountRepo, AccountRepo>();
builder.Services.AddScoped<ISectionRepo, SectionRepo>();

builder.Services.AddIdentity<ApplicationUser, IdentityRole>()
    .AddEntityFrameworkStores<SESContext>()
    .AddDefaultTokenProviders();

builder.Services.Configure<DataProtectionTokenProviderOptions>(opt =>
   opt.TokenLifespan = TimeSpan.FromHours(2));

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
}
app.UseStaticFiles();

app.AutoMigrate();

app.UseRouting();

app.UseAuthentication();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Initialize}/{id?}");

app.Run();
