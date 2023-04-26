using Microsoft.EntityFrameworkCore;
using StudentEnrollmentAPI.Data;
using StudentEnrollmentAPI.IRepository;
using StudentEnrollmentAPI.Models;

namespace StudentEnrollmentAPI.Repository
{
    public class SubjectRepo : ISubjectRepo
    {
        SESContext _context;

        public SubjectRepo(SESContext context)
        {
            _context = context;
        }

        public List<Subject> ViewAllSubjects()
        {
            return _context.Subjects.Include(sub => sub.Section).Include(sub => sub.Course).Include(sub => sub.Faculty).ToList();
        }

        public List<Subject> ViewSubjectsByCourse(int courseID)
        {
            return _context.Subjects.Where(sub => sub.CourseID == courseID).Include(sub => sub.Section).Include(sub => sub.Course).Include(sub => sub.Faculty).ToList();
        }

        public List<Subject> ViewSubjectsBySchedule(string sectionCode)
        {
            return _context.Subjects.Where(sub => sub.Section.SectionCode == sectionCode).Include(sub => sub.Section).Include(sub => sub.Course).Include(sub => sub.Faculty).ToList();
        }

        public Subject ViewOneSubject(int id)
        {
            return _context.Subjects.Include(sub => sub.Section).Include(sub => sub.Course).Include(sub => sub.Faculty).FirstOrDefault(sub => sub.ID == id);
        }

        public bool SectionCodeExists(string sectionCode)
        {
            var SectionList = _context.Sections.ToList();
            foreach (var section in SectionList)
            {
                if(section.SectionCode == sectionCode)
                {
                    return true;
                }
            }
            return false;
        }

        public bool CourseExists(int id)
        {
            var CourseList = _context.Courses.ToList();
            foreach (var course in CourseList)
            {
                if(course.ID == id)
                {
                    return true;
                }
            }
            return false;
        }
    }
}
