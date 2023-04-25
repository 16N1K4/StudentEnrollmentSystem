using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using StudentEnrollmentSystem.IRepository;
using StudentEnrollmentSystem.Models;
using StudentEnrollmentSystem.ViewModels;

namespace StudentEnrollmentSystem.Controllers
{
    [Authorize(Roles = "Administrator")]
    [ResponseCache(Location = ResponseCacheLocation.None, NoStore = true)]
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

        public async Task<IActionResult> ViewOneStudent(string id)
        {
            var Student = _accountRepo.ViewOneStudent(id);
            if (Student.CourseID == null)
            {
                var user = await _userManager.FindByEmailAsync(Student.UserName);
                user.CourseID = -2;
                var result = await _userManager.UpdateAsync(user);
            }
            Student = _accountRepo.ViewOneStudent(Student.Id);
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
            UpdateUserViewModel viewStudent = new UpdateUserViewModel
            {
                Id = Student.Id,
                FirstName = Student.FirstName,
                LastName = Student.LastName,
                OldEmail = Student.Email,
                NewEmail = Student.Email,
                CourseID = Student.CourseID.Value
            };
            var CourseList = _courseRepo.ViewAllCourses();
            ViewBag.Courses = CourseList;

            return View(viewStudent);
        }

        [HttpPost]
        public async Task<IActionResult> UpdateStudent(UpdateUserViewModel UpdatedUser)
        {
            var CourseList = _courseRepo.ViewAllCourses();
            ViewBag.Courses = CourseList;

            if (ModelState.IsValid)
            {
                var user = await _userManager.FindByEmailAsync(UpdatedUser.OldEmail);

                user.FirstName = UpdatedUser.FirstName;
                user.LastName = UpdatedUser.LastName;
                user.CourseID = UpdatedUser.CourseID;
                user.Email = UpdatedUser.NewEmail;
                user.UserName = UpdatedUser.NewEmail;

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
        [HttpGet]
        public IActionResult DeleteStudent(string id)
        {
            var OldUser = _accountRepo.ViewOneStudent(id);
            DeleteUserViewModel ToDelete = new DeleteUserViewModel
            {
                ID = OldUser.Id
            };

            return View(ToDelete);
        }

        [HttpPost]
        public async Task<IActionResult> DeleteStudent(DeleteUserViewModel OldUser)
        {
            if(OldUser != null)
            {
                var user = await _userManager.FindByIdAsync(OldUser.ID);
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

        [AcceptVerbs("GET", "POST")]
        public IActionResult CheckDuplicateEmail(string email)
        {
            if(_accountRepo.DuplicateEmail(email))
            {
                return Json(false);
            }

            return Json(true);
        }

        [AcceptVerbs("GET", "POST")]
        public IActionResult VerifyNewEmail(string OldEmail, string NewEmail)
        {
            if (OldEmail.ToUpper() == NewEmail.ToUpper())
            {
                return Json(true);
            }

            if (_accountRepo.DuplicateEmail(NewEmail))
            {
                return Json(false);
            }

            return Json(true);
        }

        [AllowAnonymous]
        public IActionResult Login()
        {
            TempData["Unauthorized"] = "You must be logged in to access this page.";
            return RedirectToAction("Login", "Home");
        }

        [AllowAnonymous]
        public IActionResult AccessDenied()
        {
            return RedirectToAction("Login", "Home");
        }
    }
}
