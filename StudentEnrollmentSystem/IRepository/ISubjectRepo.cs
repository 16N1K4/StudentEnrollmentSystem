using StudentEnrollmentSystem.Models;

namespace StudentEnrollmentSystem.IRepository
{
    public interface ISubjectRepo
    {
        public List<Subject> ViewAllSubjects();
        public Subject ViewOneSubject(int id);
        public Subject AddSubject(Subject NewSubject);
        public Subject UpdateSubject(Subject NewSubject);
        public Subject DeleteSubject(int id);
        public List<Faculty> FetchFacultyList();
        public List<Course> FetchCourseList();
        public List<Section> FetchSectionList();
    }
}
