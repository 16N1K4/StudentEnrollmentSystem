using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using StudentEnrollmentSystem.IRepository;
using StudentEnrollmentSystem.Models;
using StudentEnrollmentSystem.ViewModels;
using System.Security.Claims;

namespace StudentEnrollmentSystem.Controllers
{
    [Authorize(Roles = "Student")]
    [ResponseCache(Location = ResponseCacheLocation.None, NoStore = true)]
    public class EnrollmentController : Controller
    {
        IEnrollmentRepo _repo;
        UserManager<ApplicationUser> _userManager;
        private SignInManager<ApplicationUser> _signInManager { get; }

        public EnrollmentController(IEnrollmentRepo repo, UserManager<ApplicationUser> userManager, SignInManager<ApplicationUser> signInManager)
        {
            _repo = repo;
            _userManager = userManager;
            _signInManager = signInManager;
        }

        public IActionResult ViewAllSubjects()
        {
            var StudentID = User.FindFirstValue(ClaimTypes.NameIdentifier);
            ViewBag.StudentID = StudentID;
            var SubjectList = _repo.ViewAllSubjects(StudentID);

            return View(SubjectList);
        }

        public IActionResult ViewOneSubject(int id)
        {
            var Subject = _repo.ViewOneSubject(id);

            return View(Subject);
        }

        public IActionResult ViewSchedule(string id)
        {
            var StudentID = User.FindFirstValue(ClaimTypes.NameIdentifier);
            var Schedule = _repo.ViewSchedule(StudentID);
            ViewBag.StudentID = StudentID;

            return View(Schedule);
        }

        public IActionResult EnrollSubject(string StudentID, int SubjectID)
        {
            try
            {
                if (_repo.ScheduleConflict(StudentID, SubjectID))
                {
                    TempData["FailA"] = "The class you're trying to add has a schedule conflict with a class you've already added.";
                    return RedirectToAction("ViewAllSubjects");
                }
                if (_repo.ClassIsFull(SubjectID))
                {
                    TempData["FailC"] = "The class you're trying to add already has the maximum number of students.";
                    return RedirectToAction("ViewAllSubjects");
                }

                _repo.EnrollSubject(StudentID, SubjectID);

                TempData["SuccessA"] = "Subject successfully enrolled!";
                return RedirectToAction("ViewSchedule");
            }
            catch(Exception e)
            {
                TempData["FailB"] = "You've already added that class to your schedule.";
                return RedirectToAction("ViewAllSubjects");
            }
        }

        [HttpGet]
        public IActionResult DropSubject(string StudentID, int SubjectID)
        {
            DropSubjectViewModel ToDrop = new DropSubjectViewModel
            {
                StudentID = StudentID,
                SubjectID = SubjectID
            };

            return View(ToDrop);
        }

        [HttpPost]
        public IActionResult DropSubject(DropSubjectViewModel ToDrop)
        {
            _repo.DropSubject(ToDrop.StudentID, ToDrop.SubjectID);

            TempData["SuccessB"] = "Subject successfully dropped!";
            return RedirectToAction("ViewSchedule");
        }
    }
}
