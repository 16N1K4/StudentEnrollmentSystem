using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Rewrite;
using StudentEnrollmentSystem.Data;
using StudentEnrollmentSystem.IRepository;
using StudentEnrollmentSystem.Models;
using StudentEnrollmentSystem.ViewModels;
using System.Diagnostics;
using System.Security.Claims;

namespace StudentEnrollmentSystem.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private UserManager<ApplicationUser> _userManager { get; }
        private SignInManager<ApplicationUser> _signInManager { get; }
        public RoleManager<IdentityRole> _roleManager { get; }
        ICourseRepo _repo;

        public HomeController(ILogger<HomeController> logger, UserManager<ApplicationUser> userManager, SignInManager<ApplicationUser> signInManager, RoleManager<IdentityRole> roleManager, ICourseRepo repo)
        {
            _logger = logger;
            _userManager = userManager;
            _signInManager = signInManager;
            _roleManager = roleManager;
            _repo = repo;
        }

        [HttpGet]
        public IActionResult Login()
        {
            if (_signInManager.IsSignedIn(User))
            {
                if (User.IsInRole("Administrator"))
                {
                    return RedirectToAction("ViewAllFaculty", "Faculty");
                }


                if (User.IsInRole("Student"))
                {
                    return RedirectToAction("ViewSchedule", "Enrollment");
                }
            }

            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Login(LoginViewModel ReturningUser)
        {
            if (ModelState.IsValid)
            {
                var result = await _signInManager.PasswordSignInAsync(ReturningUser.UserName, ReturningUser.Password, false, false);
                if (result.Succeeded)
                {
                    return RedirectToAction("Login");
                }

                ModelState.AddModelError(string.Empty, "Invalid login credentials");
            }
            return View();
        }

        [HttpGet]
        public IActionResult Register()
        {
            var CourseList = _repo.ViewAllCourses();
            ViewBag.Courses = CourseList;

            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Register(RegisterViewModel NewUser)
        {
            if (ModelState.IsValid)
            {
                var user = new ApplicationUser
                {
                    FirstName = NewUser.FirstName,
                    LastName = NewUser.LastName,
                    Email = NewUser.Email,
                    UserName = NewUser.Email,
                    CourseID = NewUser.CourseID
                };

                var result = await _userManager.CreateAsync(user, NewUser.Password);

                if (result.Succeeded)
                {
                    bool roleExists = await _roleManager.RoleExistsAsync("Student");
                    if(roleExists)
                    {
                        var roleResult = await _userManager.AddToRoleAsync(user, "Student");

                        if (!roleResult.Succeeded)
                        {
                            ModelState.AddModelError(String.Empty, "User Role cannot be assigned");
                        }

                        await _signInManager.SignInAsync(user, isPersistent: false);
                        return RedirectToAction("Index");
                    }
                    
                    
                }

                foreach (var error in result.Errors)
                {
                    ModelState.AddModelError(string.Empty, error.Description);
                }
            }

            return View(NewUser);
        }

        [HttpGet]
        public async Task<IActionResult> Logout()
        {
            await _signInManager.SignOutAsync();
            return RedirectToAction("Login");
        }

        public async Task<IActionResult> Initialize()
        {
            if (_userManager.Users.FirstOrDefault(u => u.UserName == "superuser@ses.com") == null)
            {
                var user = new ApplicationUser
                {
                    FirstName = "Super",
                    LastName = "User",
                    Email = "superuser@ses.com",
                    UserName = "superuser@ses.com",
                    CourseID = -1
                };

                string password = "Password_1";

                var result = await _userManager.CreateAsync(user, password);
                var roleResult = await _userManager.AddToRoleAsync(user, "Administrator");

                ViewData["Initialize"] = "Default admin account created.";
            }
            else
            {
                ViewData["Initialize"] = "Default admin already exists.";
            }

            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}