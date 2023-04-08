using System.ComponentModel.DataAnnotations;

namespace StudentEnrollmentAPI.DTO
{
    public class SubjectDTO
    {
        public int ID { get; set; }

        [Required]
        public string Name { get; set; }

        [Required]
        [Range(1, 5)]
        public int Units { get; set; }

        [Required]
        [Range(15, 40)]
        public int ClassSize { get; set; }

        public string SectionCode { get; set; }
        public string ScheduleDay { get; set; }
        public string StartTime { get; set; }
        public string EndTime { get; set; }

        public string FacultyName { get; set; }
        public string CourseName { get; set; }
    }
}
