using System.ComponentModel.DataAnnotations;
using static System.Collections.Specialized.BitVector32;
using System.Xml.Linq;

namespace StudentEnrollmentSystem.Models
{
    public class Subject
    {
        [Key]
        public int ID { get; set; }

        [Required]
        public string Name { get; set; }

        [Required]
        [Range(1, 5)]
        public int Units { get; set; }

        [Required]
        [Range(15, 40)]
        public int ClassSize { get; set; }

        public int SectionID { get; set; }
        public Section? Section { get; set; }

        public List<StudentSubject>? Students { get; set; }
        public int FacultyID { get; set; }
        public Faculty? Faculty { get; set; }
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
