using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using StudentEnrollmentSystem.IRepository;
using StudentEnrollmentSystem.Models;
using StudentEnrollmentSystem.ViewModels;

namespace StudentEnrollmentSystem.Controllers
{
    [Authorize(Roles = "Administrator")]
    public class AccountController : Controller
    {
        private UserManager<ApplicationUser> _userManager { get; }
        private SignInManager<ApplicationUser> _signInManager { get; }
        public RoleManager<IdentityRole> _roleManager { get; }
        ICourseRepo _courseRepo;
        IAccountRepo _accountRepo;

        public AccountController(UserManager<ApplicationUser> userManager, SignInManager<ApplicationUser> signInManager, RoleManager<IdentityRole> roleManager, ICourseRepo courseRepo, IAccountRepo accountRepo)
        {
            _userManager = userManager;
            _signInManager = signInManager;
            _roleManager = roleManager;
            _courseRepo = courseRepo;
            _accountRepo = accountRepo;
        }

        public IActionResult ViewAllStudents()
        {
            var StudentList = _accountRepo.ViewAllStudents();

            return View(StudentList);
        }

        public IActionResult ViewOneStudent(string id)
        {
            var Student = _accountRepo.ViewOneStudent(id);

            return View(Student);
        }

        [HttpGet]
        public IActionResult Register()
        {
            var CourseList = _courseRepo.ViewAllCourses();
            ViewBag.Courses = CourseList;

            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Register(RegisterViewModel NewUser)
        {
            string password = "Password_1";

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

                var result = await _userManager.CreateAsync(user, password);

                if (result.Succeeded)
                {
                    bool roleExists = await _roleManager.RoleExistsAsync("Student");
                    if (roleExists)
                    {
                        var roleResult = await _userManager.AddToRoleAsync(user, "Student");

                        if (!roleResult.Succeeded)
                        {
                            ModelState.AddModelError(String.Empty, "User Role cannot be assigned");
                        }

                        TempData["SuccessA"] = "Student user account successfully created!";
                        return RedirectToAction("ViewAllStudents");
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
        public IActionResult UpdateStudent(string id)
        {
            var Student = _accountRepo.ViewOneStudent(id);
            RegisterViewModel viewStudent = new RegisterViewModel
            {
                FirstName = Student.FirstName,
                LastName = Student.LastName,
                Email = Student.Email,
                CourseID = Student.CourseID
            };
            var CourseList = _courseRepo.ViewAllCourses();
            ViewBag.Courses = CourseList;

            return View(viewStudent);
        }

        [HttpPost]
        public async Task<IActionResult> UpdateStudent(RegisterViewModel UpdatedUser)
        {
            if (ModelState.IsValid)
            {
                var user = await _userManager.FindByEmailAsync(UpdatedUser.Email);

                user.FirstName = UpdatedUser.FirstName;
                user.LastName = UpdatedUser.LastName;
                user.CourseID = UpdatedUser.CourseID;

                var result = await _userManager.UpdateAsync(user);
                if (result.Succeeded)
                {
                    TempData["SuccessB"] = "Student user account successfully updated!";
                    return RedirectToAction("ViewAllStudents");
                }

                foreach (var error in result.Errors)
                {
                    ModelState.AddModelError(string.Empty, error.Description);
                }
            }

            return View(UpdatedUser);
        }

        public async Task<IActionResult> DeleteStudent(string id)
        {
            var OldUser = _accountRepo.ViewOneStudent(id);
            if(OldUser != null)
            {
                var user = await _userManager.FindByIdAsync(id);
                var result = await _userManager.DeleteAsync(user);

                if (result.Succeeded)
                {
                    TempData["SuccessC"] = "Student user account successfully deleted!";
                    return RedirectToAction("ViewAllStudents");
                }

                foreach (var error in result.Errors)
                {
                    ModelState.AddModelError(string.Empty, error.Description);
                }
            }

            return View();
        }

        [AllowAnonymous]
        public IActionResult Login()
        {
            TempData["Unauthorized"] = "You must be logged in to access this page.";
            return RedirectToAction("Login", "Home");
        }
    }
}
