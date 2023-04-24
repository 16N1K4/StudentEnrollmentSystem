using StudentEnrollmentAPI.Models;

namespace StudentEnrollmentAPI.IRepository
{
    public interface ISubjectRepo
    {
        public List<Subject> ViewAllSubjects();
        public List<Subject> ViewSubjectsByCourse(int courseID);
        public List<Subject> ViewSubjectsBySchedule(string sectionCode);
        public Subject ViewOneSubject(int id);
    }
}
