using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using StudentEnrollmentSystem.Models;
using Microsoft.EntityFrameworkCore;

namespace StudentEnrollmentSystem.Data
{
    public static class PremadeAdmin
    {
        public static void CreateAdminAccount(this ModelBuilder builder)
        {
            UserManager<ApplicationUser> _userManager;
            RoleManager<ApplicationUser> _roleManager;

            
        }
    }
}
