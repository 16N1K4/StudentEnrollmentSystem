using Microsoft.AspNetCore.Identity;
using StudentEnrollmentAPI.Data;
using StudentEnrollmentAPI.IRepository;
using StudentEnrollmentAPI.Models;
using StudentEnrollmentAPI.Repository;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddDbContext<SESContext>();
builder.Services.AddScoped<SESContext, SESContext>();
builder.Services.AddScoped<ISubjectRepo, SubjectRepo>();

builder.Services.AddIdentity<ApplicationUser, IdentityRole>()
    .AddEntityFrameworkStores<SESContext>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseAuthorization();

app.MapControllers();

app.Run();
