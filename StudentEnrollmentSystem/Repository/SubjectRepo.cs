using Microsoft.EntityFrameworkCore;
using StudentEnrollmentSystem.Data;
using StudentEnrollmentSystem.IRepository;
using StudentEnrollmentSystem.Models;

namespace StudentEnrollmentSystem.Repository
{
    public class SubjectRepo : ISubjectRepo
    {
        SESContext _context;

        public SubjectRepo(SESContext context)
        {
            _context = context;
        }

        #region Subject CRUD (Admin Functions)

        public List<Subject> ViewAllSubjects()
        {
            return _context.Subjects.Include(sub => sub.Faculty).Include(sub => sub.Course).Include(sub => sub.Section).ToList();
        }

        public Subject ViewOneSubject(int id)
        {
            return _context.Subjects.Include(sub => sub.Faculty).Include(sub => sub.Course).Include(sub => sub.Section).AsNoTracking().FirstOrDefault(sub => sub.ID == id);
        }

        public Subject AddSubject(Subject NewSubject)
        {
            _context.Subjects.Add(NewSubject);
            _context.SaveChanges();

            return NewSubject;
        }

        public Subject UpdateSubject(Subject NewSubject)
        {
            _context.Subjects.Update(NewSubject);
            _context.SaveChanges();

            return NewSubject;
        }

        public Subject DeleteSubject(int id)
        {
            var OldSubject = ViewOneSubject(id);
            if(OldSubject != null)
            {
                _context.Subjects.Remove(OldSubject);
                _context.SaveChanges();

                return OldSubject;
            }

            return null;
        }

        public List<Faculty> FetchFacultyList()
        {
            return _context.Faculties.ToList();
        }

        public List<Course> FetchCourseList()
        {
            return _context.Courses.Where(crs => crs.ID > 0).ToList();
        }

        public List<Section> FetchSectionList()
        {
            return _context.Sections.ToList();
        }

        #endregion

    }
}
