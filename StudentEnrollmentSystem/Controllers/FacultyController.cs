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
            var FacultyList = _repo.ViewAllFaculty();
            return View(FacultyList);
        }

        public IActionResult ViewOneFaculty(int id)
        {
            var Faculty = _repo.ViewOneFaculty(id);
            return View(Faculty);
        }

        [HttpGet]
        public IActionResult AddFaculty()
        {
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
            var Faculty = _repo.ViewOneFaculty(id);

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

        [HttpGet]
        public IActionResult DeleteFaculty(int id)
        {
            var Faculty = _repo.ViewOneFaculty(id);
            DeleteEntryViewModel ToDelete = new DeleteEntryViewModel
            {
                ID = Faculty.ID
            };

            return View(ToDelete);
        }

        [HttpPost]
        public IActionResult DeleteFaculty(DeleteEntryViewModel OldEntry)
        {
            _repo.DeleteFaculty(OldEntry.ID);
            TempData["SuccessC"] = "Faculty successfully deleted!";
            return RedirectToAction("ViewAllFaculty");
        }
    }
}
