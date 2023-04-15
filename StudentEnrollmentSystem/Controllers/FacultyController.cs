using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using StudentEnrollmentSystem.IRepository;
using StudentEnrollmentSystem.Models;
using System.Data;

namespace StudentEnrollmentSystem.Controllers
{
    [Authorize(Roles = "Administrator")]
    public class FacultyController : Controller
    {
        IFacultyRepo _repo;
        private SignInManager<ApplicationUser> _signInManager { get; }

        public FacultyController(IFacultyRepo repo, SignInManager<ApplicationUser> signInManager)
        {
            _repo = repo;
            _signInManager = signInManager;
        }

        public IActionResult ViewAllFaculty()
        {
            if (!_signInManager.IsSignedIn(User))
            {
                TempData["Unauthorized"] = "You must be logged in to access this page.";
                return RedirectToAction("Login", "Home");
            }
            var FacultyList = _repo.ViewAllFaculty();
            return View(FacultyList);
        }

        public IActionResult ViewOneFaculty(int id)
        {
            if (!_signInManager.IsSignedIn(User))
            {
                TempData["Unauthorized"] = "You must be logged in to access this page.";
                return RedirectToAction("Login", "Home");
            }
            var Faculty = _repo.ViewOneFaculty(id);
            return View(Faculty);
        }

        [HttpGet]
        public IActionResult AddFaculty()
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
        public IActionResult AddFaculty(Faculty NewFaculty)
        {
            if (ModelState.IsValid)
            {
                NewFaculty.FullName = NewFaculty.FirstName + " " + NewFaculty.LastName;
                _repo.AddFaculty(NewFaculty);
                TempData["SuccessA"] = "Faculty successfully added!";
                return RedirectToAction("ViewAllFaculty");
            }

            return View(NewFaculty);
        }

        [HttpGet]
        public IActionResult UpdateFaculty(int id)
        {
            if (!_signInManager.IsSignedIn(User))
            {
                TempData["Unauthorized"] = "You must be logged in to access this page.";
                return RedirectToAction("Login", "Home");
            }
            var Faculty = _repo.ViewOneFaculty(id);
            var DeptList = _repo.FetchDepartmentList();
            ViewBag.Departments = DeptList;

            return View(Faculty);
        }

        [HttpPost]
        public IActionResult UpdateFaculty(Faculty NewFaculty)
        {
            if (ModelState.IsValid)
            {
                NewFaculty.FullName = NewFaculty.FirstName + " " + NewFaculty.LastName;
                _repo.UpdateFaculty(NewFaculty);
                TempData["SuccessB"] = "Faculty successfully updated!";
                return RedirectToAction("ViewAllFaculty");
            }

            return View(NewFaculty);
        }

        public IActionResult DeleteFaculty(int id)
        {
            _repo.DeleteFaculty(id);
            TempData["SuccessC"] = "Faculty successfully deleted!";
            return RedirectToAction("ViewAllFaculty");
        }
    }
}
