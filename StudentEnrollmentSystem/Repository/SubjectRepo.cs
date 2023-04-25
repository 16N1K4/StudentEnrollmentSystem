using Microsoft.AspNetCore.SignalR;
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
            var SubjectList = _context.Subjects.Include(sub => sub.Faculty).Include(sub => sub.Course).Include(sub => sub.Section).ToList();
            foreach (Subject sub in SubjectList)
            {
                //check for null values
                if (sub.SectionID == null)
                {
                    sub.SectionID = -1;
                    _context.Subjects.Update(sub);
                    _context.SaveChanges();
                }
            }

            return SubjectList;
        }

        public Subject ViewOneSubject(int id)
        {
            var Subject = _context.Subjects.Include(sub => sub.Faculty).Include(sub => sub.Course).Include(sub => sub.Section).AsNoTracking().FirstOrDefault(sub => sub.ID == id);

            //check for null values
            if (Subject.SectionID == null)
            {
                Subject.SectionID = -1;
                _context.Subjects.Update(Subject);
            }
            if (Subject.FacultyID == null)
            {
                Subject.FacultyID = -1;
                _context.Subjects.Update(Subject);
            }

            _context.SaveChanges();
            return Subject;
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
            var EnrolledList = _context.StudentSubjects.ToList();
            //force drop updated subjects
            foreach(StudentSubject stdsub in EnrolledList)
            {
                if(stdsub.SubjectID == NewSubject.ID)
                {
                    _context.StudentSubjects.Remove(stdsub);
                }
            }
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
            return _context.Faculties.Where(fac => fac.ID > 0).ToList();
        }

        public List<Course> FetchCourseList()
        {
            return _context.Courses.Where(crs => crs.ID > 0).ToList();
        }

        public List<Section> FetchSectionList()
        {
            return _context.Sections.Where(sec => sec.ID > 0).ToList();
        }

        #endregion

    }
}
