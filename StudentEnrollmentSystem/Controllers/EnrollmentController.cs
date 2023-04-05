using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using StudentEnrollmentSystem.IRepository;
using StudentEnrollmentSystem.Models;
using System.Security.Claims;

namespace StudentEnrollmentSystem.Controllers
{
    [Authorize(Roles = "Student")]
    public class EnrollmentController : Controller
    {
        IEnrollmentRepo _repo;
        UserManager<ApplicationUser> _userManager;

        public EnrollmentController(IEnrollmentRepo repo, UserManager<ApplicationUser> userManager)
        {
            _repo = repo;
            _userManager = userManager;
        }

        public IActionResult ViewAllSubjects()
        {
            var SubjectList = _repo.ViewAllSubjects();
            var StudentID = User.FindFirstValue(ClaimTypes.NameIdentifier);
            ViewBag.StudentID = StudentID;

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
            if (_repo.ScheduleConflict(StudentID, SubjectID))
            {
                TempData["FailA"] = "The class you're trying to add has a schedule conflict with a class you've already added.";
                return RedirectToAction("ViewAllSubjects");
            }

            try
            {
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

        public IActionResult DropSubject(string StudentID, int SubjectID)
        {
            _repo.DropSubject(StudentID, SubjectID);

            TempData["SuccessB"] = "Subject successfully dropped!";
            return RedirectToAction("ViewSchedule");
        }
    }
}
