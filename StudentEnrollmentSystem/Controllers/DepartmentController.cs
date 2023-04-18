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
    public class DepartmentController : Controller
    {
        IDepartmentRepo _repo;
        private SignInManager<ApplicationUser> _signInManager { get; }

        public DepartmentController(IDepartmentRepo repo, SignInManager<ApplicationUser> signInManager)
        {
            _repo = repo;
            _signInManager = signInManager;
        }

        public IActionResult ViewAllDepartments()
        {
            var DeptList = _repo.ViewAllDepartments();
            return View(DeptList);
        }

        public IActionResult ViewOneDepartment(int id)
        {
            var Dept = _repo.ViewOneDepartment(id);
            return View(Dept);
        }

        [HttpGet]
        public IActionResult AddDepartment()
        {
            return View();
        }

        [HttpPost]
        public IActionResult AddDepartment(Department NewDept)
        {
            if (ModelState.IsValid)
            {
                _repo.AddDepartment(NewDept);
                TempData["SuccessA"] = "Department successfully added!";
                return RedirectToAction("ViewAllDepartments");
            }

            return View(NewDept);
        }

        [HttpGet]
        public IActionResult UpdateDepartment(int id)
        {
            var Dept = _repo.ViewOneDepartment(id);
            return View(Dept);
        }

        [HttpPost]
        public IActionResult UpdateDepartment(Department NewDept)
        {
            if (ModelState.IsValid)
            {
                _repo.UpdateDepartment(NewDept);
                TempData["SuccessB"] = "Department successfully updated!";
                return RedirectToAction("ViewAllDepartments");
            }

            return View(NewDept);
        }

        [HttpGet]
        public IActionResult DeleteDepartment(int id)
        {
            var Dept = _repo.ViewOneDepartment(id);
            DeleteEntryViewModel ToDelete = new DeleteEntryViewModel
            {
                ID = Dept.ID
            };

            return View(ToDelete);
        }

        [HttpPost]
        public IActionResult DeleteDepartment(DeleteEntryViewModel OldEntry)
        {
            _repo.DeleteDepartment(OldEntry.ID);
            TempData["SuccessC"] = "Department successfully deleted!";
            return RedirectToAction("ViewAllDepartments");
        }
    }
}
