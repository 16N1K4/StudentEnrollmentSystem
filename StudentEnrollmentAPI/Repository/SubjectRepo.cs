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

        public string ScheduleDay(char code)
        {
            string day = "";

            switch (code)
            {
                case 'M':
                    day = "Monday";
                    break;
                case 'T':
                    day = "Tuesday";
                    break;
                case 'W':
                    day = "Wednesday";
                    break;
                case 'H':
                    day = "Thursday";
                    break;
                case 'F':
                    day = "Friday";
                    break;
                case 'S':
                    day = "Saturday";
                    break;
            }

            return day;
        }

        public string StartTime(char code)
        {
            string time = "";

            switch (code)
            {
                case 'A':
                    time = "7:00AM";
                    break;
                case 'B':
                    time = "8:30AM";
                    break;
                case 'C':
                    time = "10:00AM";
                    break;
                case 'D':
                    time = "11:30AM";
                    break;
                case 'E':
                    time = "1:00PM";
                    break;
                case 'F':
                    time = "2:30PM";
                    break;
                case 'G':
                    time = "4:00PM";
                    break;
                case 'H':
                    time = "5:30PM";
                    break;
                case 'I':
                    time = "7:00PM";
                    break;
                case 'J':
                    time = "8:30PM";
                    break;
            }

            return time;
        }

        public string EndTime(char code)
        {
            string time = "";

            switch (code)
            {
                case 'A':
                    time = "7:00AM";
                    break;
                case 'B':
                    time = "8:30AM";
                    break;
                case 'C':
                    time = "10:00AM";
                    break;
                case 'D':
                    time = "11:30AM";
                    break;
                case 'E':
                    time = "1:00PM";
                    break;
                case 'F':
                    time = "2:30PM";
                    break;
                case 'G':
                    time = "4:00PM";
                    break;
                case 'H':
                    time = "5:30PM";
                    break;
                case 'I':
                    time = "7:00PM";
                    break;
                case 'J':
                    time = "8:30PM";
                    break;
            }

            return time;
        }
    }
}
