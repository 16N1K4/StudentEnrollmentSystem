using Microsoft.AspNetCore.Mvc.Rendering;
using StudentEnrollmentSystem.Models;

namespace StudentEnrollmentSystem.IRepository
{
    public interface ISectionRepo
    {
        public List<Section> ViewAllSections();
        public Section ViewOneSection(int id);
        public Section AddSection(Section NewSection);
        public Section UpdateSection(Section NewSection);
        public Section DeleteSection(int id);
        public List<SelectListItem> ListOfDays();
        public List<SelectListItem> ListOfTimes();
        public string GenerateSectionCode(string day, string startTime, string endTime);
        public string GenerateSchedule(string day, string startTime, string endTime);
        public bool CheckDuplicate(string day, string startTime, string endTime);

    }
}
