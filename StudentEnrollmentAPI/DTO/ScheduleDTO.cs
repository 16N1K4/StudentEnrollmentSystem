using System.ComponentModel.DataAnnotations;

namespace StudentEnrollmentAPI.DTO
{
    public class ScheduleDTO
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string SubjectName { get; set; }
        public int Units { get; set; }

        public int ClassSize { get; set; }

        public string SectionCode { get; set; }
        public string ScheduleDay { get; set; }
        public string StartTime { get; set; }
        public string EndTime { get; set; }

        public string FacultyName { get; set; }
        public string CourseName { get; set; }
    }
}
