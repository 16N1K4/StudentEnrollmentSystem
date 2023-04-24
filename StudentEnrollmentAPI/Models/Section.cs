using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;

namespace StudentEnrollmentAPI.Models
{
    public class Section
    {
        [Key]
        public int ID { get; set; }
        public string SectionCode { get; set; }
        public string Day { get; set; }
        public string StartTime { get; set; }
        public string EndTime { get; set; }
        public List<Subject>? Subjects { get; set; }

        public Section()
        {

        }

        public Section(int id, string sectionCode)
        {
            ID = id;
            SectionCode = sectionCode;
        }
    }
}
