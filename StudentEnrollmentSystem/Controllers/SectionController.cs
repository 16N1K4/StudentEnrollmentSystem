using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using StudentEnrollmentSystem.IRepository;
using StudentEnrollmentSystem.Models;
using StudentEnrollmentSystem.ViewModels;

namespace StudentEnrollmentSystem.Controllers
{
    [Authorize(Roles = "Administrator")]
    [ResponseCache(Location = ResponseCacheLocation.None, NoStore = true)]
    public class SectionController : Controller
    {
        ISectionRepo _repo;

        public SectionController(ISectionRepo repo)
        {
            _repo = repo;
        }

        public IActionResult ViewAllSections()
        {
            var SectionList = _repo.ViewAllSections();
            return View(SectionList);
        }

        public IActionResult ViewOneSection(int id)
        {
            var Section = _repo.ViewOneSection(id);

            return View(Section);
        }

        [HttpGet]
        public IActionResult AddSection()
        {
            ViewBag.Days = _repo.ListOfDays();
            ViewBag.Times = _repo.ListOfTimes();
            return View();
        }

        [HttpPost]
        public IActionResult AddSection(Section NewSection)
        {
            if (ModelState.IsValid)
            {
                NewSection.FullSchedule = _repo.GenerateSchedule(NewSection.Day, NewSection.StartTime, NewSection.EndTime);
                NewSection.SectionCode = _repo.GenerateSectionCode(NewSection.Day, NewSection.StartTime, NewSection.EndTime);

                var NewTime = TimeOnly.Parse(NewSection.EndTime);

                _repo.AddSection(NewSection);

                TempData["SuccessA"] = "Section successfully added!";
                return RedirectToAction("ViewAllSections");
            }

            return View(NewSection);
        }

        [HttpGet]
        public IActionResult UpdateSection(int id)
        {
            var Section = _repo.ViewOneSection(id);
            ViewBag.Days = _repo.ListOfDays();
            ViewBag.Times = _repo.ListOfTimes();
            return View(Section);
        }

        [HttpPost]
        public IActionResult UpdateSection(Section NewSection)
        {
            if (ModelState.IsValid)
            {
                NewSection.FullSchedule = _repo.GenerateSchedule(NewSection.Day, NewSection.StartTime, NewSection.EndTime);
                NewSection.SectionCode = _repo.GenerateSectionCode(NewSection.Day, NewSection.StartTime, NewSection.EndTime);

                _repo.UpdateSection(NewSection);
                TempData["SuccessB"] = "Section successfully updated!";
                return RedirectToAction("ViewAllSections");
            }

            return View(NewSection);
        }

        [HttpGet]
        public IActionResult DeleteSection(int id)
        {
            DeleteEntryViewModel ToDelete = new DeleteEntryViewModel
            {
                ID = id
            };
            return View(ToDelete);
        }

        [HttpPost]
        public IActionResult DeleteSection(DeleteEntryViewModel OldEntry)
        {
            _repo.DeleteSection(OldEntry.ID);
            TempData["SuccessC"] = "Section successfully deleted!";
            return RedirectToAction("ViewAllSections");
        }

        [AcceptVerbs("GET", "POST")]
        public IActionResult CheckStartEndTime(string StartTime, string EndTime)
        {
            var start = TimeOnly.Parse(StartTime);
            var end = TimeOnly.Parse(EndTime);

            if(start == end || start > end)
            {
                return Json(false);
            }

            return Json(true);
        }

        [AcceptVerbs("GET", "POST")]
        public IActionResult AllowedTimeSpan(string StartTime, string EndTime)
        {
            var start = TimeOnly.Parse(StartTime);
            var end = TimeOnly.Parse(EndTime);

            if(end - start < TimeSpan.FromHours(1) || end - start > TimeSpan.FromHours(3))
            {
                return Json(false);
            }

            return Json(true);
        }

        [AcceptVerbs("GET", "POST")]
        public IActionResult DuplicateSchedule(string Day, string StartTime, string EndTime)
        {
            if(_repo.CheckDuplicate(Day, StartTime, EndTime))
            {
                return Json(false);
            }

            return Json(true);
        }
    }
}
