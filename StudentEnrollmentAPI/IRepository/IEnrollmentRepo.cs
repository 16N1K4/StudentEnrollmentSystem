using Microsoft.AspNetCore.Identity;
using StudentEnrollmentAPI.DTO;
using StudentEnrollmentAPI.Models;
using System.Security.Claims;

namespace StudentEnrollmentAPI.IRepository
{
    public interface IEnrollmentRepo
    {
        public Task<SignInResult> SignInUserAsync(LoginDTO loginDTO);
        public Task<ApplicationUser> FindUserByEmailAsync(string email);
        public Task<List<StudentSubject>> ViewSchedule(string email);
        public Task<string> GetUserRole(ApplicationUser user);
    }
}
