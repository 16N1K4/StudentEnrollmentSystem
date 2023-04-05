using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using StudentEnrollmentSystem.Models;
using System.Runtime.CompilerServices;

namespace StudentEnrollmentSystem.Data
{
    public static class AddRoles
    {
        public static void CreateRoles(this ModelBuilder builder)
        {
            builder.Entity<IdentityRole>().HasData(
                new IdentityRole { Name = "Administrator", NormalizedName = "ADMINISTRATOR" },
                new IdentityRole { Name = "Student", NormalizedName = "STUDENT" }
                );
        }
    }
}
