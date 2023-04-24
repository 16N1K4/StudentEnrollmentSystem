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

        public async Task<string> GetUserRole(ApplicationUser user)
        {
            var roleList = await _userManager.GetRolesAsync(user);
            string role = roleList.First();
            return role;
        }

        public async Task<List<StudentSubject>> ViewSchedule(string email)
        {
            var user = await _userManager.FindByEmailAsync(email);

            return _context.StudentSubjects.Where(stdsub => stdsub.StudentID == user.Id)
                .Include(sub => sub.Subject).Include(std => std.Student)
                .Include(sub => sub.Subject.Section).Include(sub => sub.Subject.Course).Include(sub => sub.Subject.Faculty)
                .ToList();
        }

        
    }
}
