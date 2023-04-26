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
            List<Subject> SubjectList = _context.Subjects.Where(sub => sub.SectionID > 0 || sub.SectionID == null)
                .Include(sub => sub.Faculty).Include(sub => sub.Course).Include(sub => sub.Section).ToList();

            //remove classes already added to schedule
            var Schedule = ViewSchedule(id);
            foreach (var Subject in Schedule)
            {
                SubjectList.Remove(SubjectList.FirstOrDefault(sub => sub.ID == Subject.Subject.ID));
            }

            //check for null values
            foreach (Subject sub in SubjectList)
            {
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
                _context.SaveChanges();

                return Subject;
            }
            if (Subject.FacultyID == null)
            {
                Subject.FacultyID = -1;
                _context.Subjects.Update(Subject);
                _context.SaveChanges();

                return Subject;
            }

            return Subject;
        }

        public List<StudentSubject> ViewSchedule(string id)
        {
            var Schedule = _context.StudentSubjects.Where(stdsub => stdsub.StudentID == id).Include(stdsub => stdsub.Subject).Include(stdsub => stdsub.Subject.Faculty).Include(stdsub => stdsub.Subject.Course).Include(stdsub => stdsub.Subject.Section).OrderBy(stdsub => stdsub.Subject.SectionID).ToList();
            //check for null values
            foreach (var stdsub in Schedule)
            {
                var Subject = ViewOneSubject(stdsub.SubjectID);
                if (Subject.SectionID == null)
                {
                    Subject.SectionID = -1;
                    _context.Subjects.Update(Subject);
                    _context.SaveChanges();
                }
            }
            
            return Schedule;
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

        public bool ClassIsFull(int SubjectID)
        {
            var SubjectToAdd = ViewOneSubject(SubjectID);
            var EnrolledList = _context.StudentSubjects.ToList();

            int counter = 0;
            foreach (var stdsub in EnrolledList)
            {
                if (SubjectToAdd.ID == stdsub.SubjectID)
                {
                    counter++;
                }
            }

            if (counter >= SubjectToAdd.ClassSize)
            {
                return true;
            }

            return false;
        }

        #endregion
    }
}
