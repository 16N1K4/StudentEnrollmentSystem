using Microsoft.AspNetCore.Identity;
using StudentEnrollmentAPI.DTO;
using StudentEnrollmentAPI.Models;

namespace StudentEnrollmentAPI.IRepository
{
    public interface IEnrollmentRepo
    {
        public Task<SignInResult> SignInUserAsync(LoginDTO loginDTO);
        public Task<ApplicationUser> FindUserByEmailAsync(string email);
        public Task<List<StudentSubject>> ViewSchedule(string email);
        public string ScheduleDay(char code);
        public string StartTime(char code);
        public string EndTime(char code);
    }
}
