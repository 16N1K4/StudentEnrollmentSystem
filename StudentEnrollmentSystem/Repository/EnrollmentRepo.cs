using Microsoft.EntityFrameworkCore;
using StudentEnrollmentSystem.Data;
using StudentEnrollmentSystem.IRepository;
using StudentEnrollmentSystem.Models;
using System.Runtime.CompilerServices;

namespace StudentEnrollmentSystem.Repository
{
    public class EnrollmentRepo : IEnrollmentRepo
    {
        SESContext _context;

        public EnrollmentRepo(SESContext context)
        {
            _context = context;
        }

        #region Enrollment Operations (Student Functions)

        public List<Subject> ViewAllSubjects(string id)
        {
            List<Subject> SubjectList = _context.Subjects.Where(sub => sub.Students.Count < sub.ClassSize).Include(sub => sub.Faculty).Include(sub => sub.Course).Include(sub => sub.Section).ToList();
            var Schedule = ViewSchedule(id);
            foreach(var Subject in Schedule)
            {
                SubjectList.Remove(SubjectList.FirstOrDefault(sub => sub.ID == Subject.Subject.ID));
            }
            return SubjectList;
        }

        public Subject ViewOneSubject(int id)
        {
            return _context.Subjects.Include(sub => sub.Faculty).Include(sub => sub.Course).Include(sub => sub.Section).AsNoTracking().FirstOrDefault(sub => sub.ID == id);
        }

        public List<StudentSubject> ViewSchedule(string id)
        {
            return _context.StudentSubjects.Where(stdsub => stdsub.StudentID == id).Include(stdsub => stdsub.Subject).Include(stdsub => stdsub.Subject.Faculty).Include(stdsub => stdsub.Subject.Course).Include(stdsub => stdsub.Subject.Section).OrderBy(stdsub => stdsub.Subject.SectionID).ToList();
        }

        //add subject
        public StudentSubject EnrollSubject(string StudentID, int SubjectID)
        {
            StudentSubject NewSubject = new StudentSubject
            {
                StudentID = StudentID,
                SubjectID = SubjectID
            };

            _context.StudentSubjects.Add(NewSubject);
            _context.SaveChanges();

            return NewSubject;
        }

        //drop subject
        public StudentSubject DropSubject(string StudentID, int SubjectID)
        {
            var SubjectToDrop = _context.StudentSubjects.FirstOrDefault(stdsub => stdsub.StudentID == StudentID && stdsub.SubjectID == SubjectID);
            if (SubjectToDrop != null)
            {
                _context.StudentSubjects.Remove(SubjectToDrop);
                _context.SaveChanges();

                return SubjectToDrop;
            }

            return null;
        }

        public bool ScheduleConflict(string StudentID, int SubjectID)
        {
            var SubjectToAdd = ViewOneSubject(SubjectID);
            var Schedule = _context.StudentSubjects.Where(stdsub => stdsub.StudentID == StudentID).Include(stdsub => stdsub.Subject).Include(stdsub => stdsub.Subject.Section).ToList();
            foreach(var sub in Schedule)
            {
                var Subject = ViewOneSubject(sub.SubjectID);
                var SubjectToAddStart = TimeOnly.Parse(SubjectToAdd.Section.StartTime);
                var SubjectToAddEnd = TimeOnly.Parse(SubjectToAdd.Section.EndTime);
                var StartTimeCheck = TimeOnly.Parse(Subject.Section.StartTime);
                var EndTimeCheck = TimeOnly.Parse(Subject.Section.EndTime);
                if(SubjectToAddStart >= StartTimeCheck && SubjectToAddStart < EndTimeCheck)
                {
                    return true;
                }

                if(SubjectToAddEnd >= StartTimeCheck && SubjectToAddEnd < EndTimeCheck)
                {
                    return true;
                }
            }

            return false;
        }

        #endregion
    }
}
