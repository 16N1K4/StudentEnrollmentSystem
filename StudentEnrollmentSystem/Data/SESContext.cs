using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using StudentEnrollmentSystem.Models;

namespace StudentEnrollmentSystem.Data
{
    public class SESContext : IdentityDbContext<ApplicationUser>
    {
        public IConfiguration _config { get; }

        public SESContext(IConfiguration config)
        {
            _config = config;
        }

        protected override void OnConfiguring(DbContextOptionsBuilder builder)
        {
            var server = _config.GetConnectionString("Server");
            var DB = _config.GetConnectionString("DB");
            var username = _config.GetConnectionString("UserName");
            var password = _config.GetConnectionString("Password");

            string ConnectionString = $"Server={server};Database={DB};User Id={username};Password={password};MultipleActiveResultSets=true";

            builder.UseSqlServer(ConnectionString).UseQueryTrackingBehavior(QueryTrackingBehavior.NoTracking);

            base.OnConfiguring(builder);
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.CreateRoles();
            builder.Entity<StudentSubject>().HasKey(stdsub => new { stdsub.StudentID, stdsub.SubjectID });
            builder.SeedSectionCodes();
            builder.ConfigureRelationships();

            builder.Entity<Department>().HasData(new Department { ID = -1, Name = "Admin" });
            builder.Entity<Course>().HasData(new Course { ID = -1, Name = "Admin", DeptID = -1});
            
            base.OnModelCreating(builder);
        }

        public DbSet<StudentSubject> StudentSubjects { get; set; }
        public DbSet<Faculty> Faculties { get; set; }
        public DbSet<Subject> Subjects { get; set; }
        public DbSet<Course> Courses { get; set; }
        public DbSet<Department> Departments { get; set; }
        public DbSet<Section> Sections { get; set; }
    }
}
