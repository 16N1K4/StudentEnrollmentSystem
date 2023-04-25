using Microsoft.EntityFrameworkCore;
using StudentEnrollmentSystem.Models;

namespace StudentEnrollmentSystem.Data
{
    public static class SeedDefaultValues
    {
        public static void AddDefaultValues(this ModelBuilder builder)
        {
            builder.Entity<Department>().HasData(new Department { ID = -1, Name = "Admin" });
            builder.Entity<Course>().HasData(new Course { ID = -1, Name = "Admin", DeptID = -1 });
            builder.Entity<Faculty>().HasData(new Faculty { ID = -1, FirstName = "NULL", LastName = "", Email = ""});
            builder.Entity<Section>().HasData(new Section { ID = -1, SectionCode = "NULL", Day = "", StartTime = "", EndTime = "", FullSchedule ="NULL"});
            builder.Entity<Course>().HasData(new Course { ID = -2, Name = "NULL", DeptID = -1 });
        }
    }
}
