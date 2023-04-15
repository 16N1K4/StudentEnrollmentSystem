using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using StudentEnrollmentSystem.IRepository;
using StudentEnrollmentSystem.Models;

namespace StudentEnrollmentSystem.Controllers
{
    [Authorize(Roles = "Administrator")]
    public class CourseController : Controller
    {
        ICourseRepo _repo;
        private SignInManager<ApplicationUser> _signInManager { get; }

        public CourseController(ICourseRepo repo, SignInManager<ApplicationUser> signInManager)
        {
            _repo = repo;
            _signInManager = signInManager;
        }

        public IActionResult ViewAllCourses()
        {
            if (!_signInManager.IsSignedIn(User))
            {
                TempData["Unauthorized"] = "You must be logged in to access this page.";
                return RedirectToAction("Login", "Home");
            }
            var CourseList = _repo.ViewAllCourses();
            return View(CourseList);
        }

        public IActionResult ViewOneCourse(int id)
        {
            if (!_signInManager.IsSignedIn(User))
            {
                TempData["Unauthorized"] = "You must be logged in to access this page.";
                return RedirectToAction("Login", "Home");
            }
            var Course = _repo.ViewOneCourse(id);
            return View(Course);
        }

        [HttpGet]
        public IActionResult AddCourse()
        {
            if (!_signInManager.IsSignedIn(User))
            {
                TempData["Unauthorized"] = "You must be logged in to access this page.";
                return RedirectToAction("Login", "Home");
            }
            var DeptList = _repo.FetchDepartmentList();
            ViewBag.Departments = DeptList;

            return View();
        }

        [HttpPost]
        public IActionResult AddCourse(Course NewCourse)
        {
            if (ModelState.IsValid)
            {
                _repo.AddCourse(NewCourse);

                TempData["SuccessA"] = "Course successfully added!";
                return RedirectToAction("ViewAllCourses");
            }

            return View(NewCourse);
        }

        [HttpGet]
        public IActionResult UpdateCourse(int id)
        {
            if (!_signInManager.IsSignedIn(User))
            {
                TempData["Unauthorized"] = "You must be logged in to access this page.";
                return RedirectToAction("Login", "Home");
            }
            var Course = _repo.ViewOneCourse(id);
            var DeptList = _repo.FetchDepartmentList();
            ViewBag.Departments = DeptList;

            return View(Course);
        }

        [HttpPost]
        public IActionResult UpdateCourse(Course NewCourse)
        {
            if (ModelState.IsValid)
            {
                _repo.UpdateCourse(NewCourse);
                TempData["SuccessB"] = "Course successfully updated!";
                return RedirectToAction("ViewAllCourses");
            }

            return View(NewCourse);
        }

        public IActionResult DeleteCourse(int id)
        {
            _repo.DeleteCourse(id);
            TempData["SuccessC"] = "Course successfully deleted!";
            return RedirectToAction("ViewAllCourses");
        }
    }
}
