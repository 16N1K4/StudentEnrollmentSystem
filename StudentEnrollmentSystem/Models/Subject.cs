using System.ComponentModel.DataAnnotations;
using static System.Collections.Specialized.BitVector32;
using System.Xml.Linq;

namespace StudentEnrollmentSystem.Models
{
    public class Subject
    {
        [Key]
        public int ID { get; set; }

        [Required(ErrorMessage = "The 'Name' field is required")]
        public string Name { get; set; }

        [Required(ErrorMessage = "The 'Units' field is required")]
        [Range(1, 5, ErrorMessage = "There must be a minimum of 1 unit and a maximum of 5 units")]
        public int Units { get; set; }

        [Required(ErrorMessage = "The 'Class Size' field is required")]
        [Range(15, 40, ErrorMessage = "There must be a minimum of 15 slots and a maximum of 40 slots")]
        public int ClassSize { get; set; }
        [Required(ErrorMessage = "The 'Section' field is required")]
        public int SectionID { get; set; }
        public Section? Section { get; set; }

        public List<StudentSubject>? Students { get; set; }
        [Required(ErrorMessage = "The 'Faculty' field is required")]
        public int FacultyID { get; set; }
        public Faculty? Faculty { get; set; }
        [Required(ErrorMessage = "The 'Course' field is required")]
        public int CourseID { get; set; }
        public Course? Course { get; set; }
        

        public Subject()
        {

        }

        public Subject(int id, string name, int units, int classSize, int sectionID, int courseID, int facultyID)
        {
            ID = id;
            Name = name;
            Units = units;
            ClassSize = classSize;
            SectionID = sectionID;
            CourseID = courseID;
            FacultyID = facultyID;
        }
    }
}
