using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using StudentEnrollmentSystem.IRepository;
using StudentEnrollmentSystem.Models;
using System.Data;

namespace StudentEnrollmentSystem.Controllers
{
    [Authorize(Roles = "Administrator")]
    public class SubjectController : Controller
    {
        ISubjectRepo _repo;
        private SignInManager<ApplicationUser> _signInManager { get; }

        public SubjectController(ISubjectRepo repo, SignInManager<ApplicationUser> signInManager)
        {
            _repo = repo;
            _signInManager = signInManager;
        }

        public IActionResult ViewAllSubjects()
        {
            if (!_signInManager.IsSignedIn(User))
            {
                TempData["Unauthorized"] = "You must be logged in to access this page.";
                return RedirectToAction("Login", "Home");
            }
            var SubjectList = _repo.ViewAllSubjects();

            return View(SubjectList);
        }

        public IActionResult ViewOneSubject(int id)
        {
            if (!_signInManager.IsSignedIn(User))
            {
                TempData["Unauthorized"] = "You must be logged in to access this page.";
                return RedirectToAction("Login", "Home");
            }
            var Subject = _repo.ViewOneSubject(id);

            return View(Subject);
        }

        [HttpGet]
        public IActionResult AddSubject()
        {
            if (!_signInManager.IsSignedIn(User))
            {
                TempData["Unauthorized"] = "You must be logged in to access this page.";
                return RedirectToAction("Login", "Home");
            }
            var courses = _repo.FetchCourseList();
            var faculty = _repo.FetchFacultyList();
            var sections = _repo.FetchSectionList();

            ViewBag.Courses = courses;
            ViewBag.Faculty = faculty;
            ViewBag.Sections = sections;

            return View();
        }

        [HttpPost]
        public IActionResult AddSubject(Subject NewSubject)
        {
            if (ModelState.IsValid)
            {
                _repo.AddSubject(NewSubject);
                TempData["SuccessA"] = "Subject successfully added!";
                return RedirectToAction("ViewAllSubjects");
            }
            
            return View(NewSubject);
        }

        [HttpGet]
        public IActionResult UpdateSubject(int id)
        {
            if (!_signInManager.IsSignedIn(User))
            {
                TempData["Unauthorized"] = "You must be logged in to access this page.";
                return RedirectToAction("Login", "Home");
            }
            var Subject = _repo.ViewOneSubject(id);
            var courses = _repo.FetchCourseList();
            var faculty = _repo.FetchFacultyList();
            var sections = _repo.FetchSectionList();

            ViewBag.Courses = courses;
            ViewBag.Faculty = faculty;
            ViewBag.Sections = sections;

            return View(Subject);
        }

        [HttpPost]
        public IActionResult UpdateSubject(Subject NewSubject)
        {
            if (ModelState.IsValid)
            {
                _repo.UpdateSubject(NewSubject);
                TempData["SuccessB"] = "Subject successfully updated!";
                return RedirectToAction("ViewAllSubjects");
            }

            return View(NewSubject);
        }

        public IActionResult DeleteSubject(int id)
        {
            _repo.DeleteSubject(id);
            TempData["SuccessC"] = "Subject successfully deleted!";
            return RedirectToAction("ViewAllSubjects");
        }
    }
}
