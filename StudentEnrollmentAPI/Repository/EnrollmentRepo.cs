using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using StudentEnrollmentAPI.Data;
using StudentEnrollmentAPI.DTO;
using StudentEnrollmentAPI.IRepository;
using StudentEnrollmentAPI.Models;
using System.Security.Claims;

namespace StudentEnrollmentAPI.Repository
{
    public class EnrollmentRepo : IEnrollmentRepo
    {
        public SESContext _context { get; }
        public UserManager<ApplicationUser> _userManager { get; }
        public SignInManager<ApplicationUser> _signInManager { get; }

        public EnrollmentRepo(UserManager<ApplicationUser> userManager,
                                   SignInManager<ApplicationUser> signInManager,
                                   SESContext context)
        {
            _userManager = userManager;
            _signInManager = signInManager;
            _context = context;
        }

        public async Task<SignInResult> SignInUserAsync(LoginDTO loginDTO)
        {
            var loginResult = await _signInManager.PasswordSignInAsync(loginDTO.UserName, loginDTO.Password, false, false);
            return loginResult;
        }

        public async Task<ApplicationUser> FindUserByEmailAsync(string email)
        {
            var user = await _userManager.FindByEmailAsync(email);
            return user;
        }

        public async Task<List<StudentSubject>> ViewSchedule(string email)
        {
            var user = await _userManager.FindByEmailAsync(email);

            return _context.StudentSubjects.Where(stdsub => stdsub.StudentID == user.Id)
                .Include(sub => sub.Subject).Include(std => std.Student)
                .Include(sub => sub.Subject.Section).Include(sub => sub.Subject.Course).Include(sub => sub.Subject.Faculty)
                .ToList();
        }

        public string ScheduleDay(char code)
        {
            string day = "";

            switch (code)
            {
                case 'M':
                    day = "Monday";
                    break;
                case 'T':
                    day = "Tuesday";
                    break;
                case 'W':
                    day = "Wednesday";
                    break;
                case 'H':
                    day = "Thursday";
                    break;
                case 'F':
                    day = "Friday";
                    break;
                case 'S':
                    day = "Saturday";
                    break;
            }

            return day;
        }

        public string StartTime(char code)
        {
            string time = "";

            switch (code)
            {
                case 'A':
                    time = "7:00AM";
                    break;
                case 'B':
                    time = "8:30AM";
                    break;
                case 'C':
                    time = "10:00AM";
                    break;
                case 'D':
                    time = "11:30AM";
                    break;
                case 'E':
                    time = "1:00PM";
                    break;
                case 'F':
                    time = "2:30PM";
                    break;
                case 'G':
                    time = "4:00PM";
                    break;
                case 'H':
                    time = "5:30PM";
                    break;
                case 'I':
                    time = "7:00PM";
                    break;
                case 'J':
                    time = "8:30PM";
                    break;
            }

            return time;
        }

        public string EndTime(char code)
        {
            string time = "";

            switch (code)
            {
                case 'A':
                    time = "7:00AM";
                    break;
                case 'B':
                    time = "8:30AM";
                    break;
                case 'C':
                    time = "10:00AM";
                    break;
                case 'D':
                    time = "11:30AM";
                    break;
                case 'E':
                    time = "1:00PM";
                    break;
                case 'F':
                    time = "2:30PM";
                    break;
                case 'G':
                    time = "4:00PM";
                    break;
                case 'H':
                    time = "5:30PM";
                    break;
                case 'I':
                    time = "7:00PM";
                    break;
                case 'J':
                    time = "8:30PM";
                    break;
            }

            return time;
        }
    }
}
