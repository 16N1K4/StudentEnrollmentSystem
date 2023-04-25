using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using StudentEnrollmentSystem.IRepository;
using StudentEnrollmentSystem.Models;
using StudentEnrollmentSystem.ViewModels;

namespace StudentEnrollmentSystem.Controllers
{
    [Authorize(Roles = "Administrator")]
    [ResponseCache(Location = ResponseCacheLocation.None, NoStore = true)]
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
            var CourseList = _repo.ViewAllCourses();
            return View(CourseList);
        }

        public IActionResult ViewOneCourse(int id)
        {
            var Course = _repo.ViewOneCourse(id);
            return View(Course);
        }

        [HttpGet]
        public IActionResult AddCourse()
        {
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

        [HttpGet]
        public IActionResult DeleteCourse(int id)
        {
            var Course = _repo.ViewOneCourse(id);
            DeleteEntryViewModel ToDelete = new DeleteEntryViewModel
            {
                ID = Course.ID
            };

            return View(ToDelete);
        }

        [HttpPost]
        public IActionResult DeleteCourse(DeleteEntryViewModel OldEntry)
        {
            _repo.DeleteCourse(OldEntry.ID);
            TempData["SuccessC"] = "Course successfully deleted!";
            return RedirectToAction("ViewAllCourses");
        }
    }
}
