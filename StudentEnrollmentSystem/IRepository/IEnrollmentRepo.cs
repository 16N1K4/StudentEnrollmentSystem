using StudentEnrollmentSystem.Models;

namespace StudentEnrollmentSystem.IRepository
{
    public interface IEnrollmentRepo
    {
        public List<Subject> ViewAllSubjects();
        public Subject ViewOneSubject(int id);
        public List<StudentSubject> ViewSchedule(string id);
        public StudentSubject EnrollSubject(string StudentID, int CourseID);
        public StudentSubject DropSubject(string StudentID, int SubjectID);
        public bool ScheduleConflict(string StudentID, int SubjectID);
    }
}
