using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using StudentEnrollmentSystem.IRepository;
using StudentEnrollmentSystem.Models;
using StudentEnrollmentSystem.ViewModels;
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
            var SubjectList = _repo.ViewAllSubjects();

            return View(SubjectList);
        }

        public IActionResult ViewOneSubject(int id)
        {
            var Subject = _repo.ViewOneSubject(id);

            return View(Subject);
        }

        [HttpGet]
        public IActionResult AddSubject()
        {
            var courses = _repo.FetchCourseList();
            var faculty = _repo.FetchFacultyList();
            var sections = _repo.FetchSectionList();

            ViewBag.Courses = courses;
            ViewBag.Faculty = faculty;
            ViewBag.Sections = sections;

            return View();
        }

        [HttpPost]
        public IActionResult AddSubject(SubjectViewModel NewSubject)
        {
            if (ModelState.IsValid)
            {
                var NewSub = new Subject
                {
                    Name = NewSubject.Name,
                    Units = NewSubject.Units,
                    ClassSize = NewSubject.ClassSize,
                    FacultyID = NewSubject.FacultyID,
                    SectionID = NewSubject.SectionID,
                    CourseID = NewSubject.CourseID
                };

                _repo.AddSubject(NewSub);
                TempData["SuccessA"] = "Subject successfully added!";
                return RedirectToAction("ViewAllSubjects");
            }
            
            return View(NewSubject);
        }

        [HttpGet]
        public IActionResult UpdateSubject(int id)
        {
            var Subject = _repo.ViewOneSubject(id);
            SubjectViewModel SubjectVM = new SubjectViewModel
            {
                ID = Subject.ID,
                Name = Subject.Name,
                Units = Subject.Units,
                ClassSize = Subject.ClassSize,
                FacultyID = Subject.FacultyID,
                SectionID = Subject.SectionID,
                CourseID = Subject.CourseID
            };
            var courses = _repo.FetchCourseList();
            var faculty = _repo.FetchFacultyList();
            var sections = _repo.FetchSectionList();

            ViewBag.Courses = courses;
            ViewBag.Faculty = faculty;
            ViewBag.Sections = sections;

            return View(SubjectVM);
        }

        [HttpPost]
        public IActionResult UpdateSubject(Subject NewSubject)
        {
            if (ModelState.IsValid)
            {
                var NewSub = new Subject
                {
                    ID = NewSubject.ID,
                    Name = NewSubject.Name,
                    Units = NewSubject.Units,
                    ClassSize = NewSubject.ClassSize,
                    FacultyID = NewSubject.FacultyID,
                    SectionID = NewSubject.SectionID,
                    CourseID = NewSubject.CourseID
                };
                _repo.UpdateSubject(NewSub);
                TempData["SuccessB"] = "Subject successfully updated!";
                return RedirectToAction("ViewAllSubjects");
            }

            return View(NewSubject);
        }

        [HttpGet]
        public IActionResult DeleteSubject(int id)
        {
            var Subject = _repo.ViewOneSubject(id);
            DeleteEntryViewModel ToDelete = new DeleteEntryViewModel
            {
                ID = Subject.ID
            };

            return View(ToDelete);
        }

        [HttpPost]
        public IActionResult DeleteSubject(DeleteEntryViewModel OldEntry)
        {
            _repo.DeleteSubject(OldEntry.ID);
            TempData["SuccessC"] = "Subject successfully deleted!";
            return RedirectToAction("ViewAllSubjects");
        }
    }
}
