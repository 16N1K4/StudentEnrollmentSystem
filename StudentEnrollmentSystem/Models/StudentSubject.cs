namespace StudentEnrollmentSystem.Models
{
    public class StudentSubject
    {
        public string StudentID { get; set; }
        public ApplicationUser Student { get; set; }

        public int SubjectID { get; set; }
        public Subject Subject { get; set; }
    }
}
