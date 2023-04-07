using System.ComponentModel.DataAnnotations;

namespace StudentEnrollmentAPI.Models
{
    public class Section
    {
        [Key]
        public int ID { get; set; }
        public string SectionCode { get; set; }
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
