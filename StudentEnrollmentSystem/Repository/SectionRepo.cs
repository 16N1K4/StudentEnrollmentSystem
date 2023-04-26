using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.AspNetCore.SignalR;
using Microsoft.EntityFrameworkCore;
using StudentEnrollmentSystem.Data;
using StudentEnrollmentSystem.IRepository;
using StudentEnrollmentSystem.Models;
using System;

namespace StudentEnrollmentSystem.Repository
{
    public class SectionRepo : ISectionRepo
    {
        SESContext _context;

        public SectionRepo(SESContext context)
        {
            _context = context;
        }

        public List<Section> ViewAllSections()
        {
            return _context.Sections.Where(sec => sec.ID > 0).ToList();
        }

        public Section ViewOneSection(int id)
        {
            return _context.Sections.AsNoTracking().FirstOrDefault(sec => sec.ID == id);
        }

        public Section AddSection(Section NewSection)
        {
            _context.Sections.Add(NewSection);
            _context.SaveChanges();

            return NewSection;
        }

        public Section UpdateSection(Section NewSection)
        {
            _context.Sections.Update(NewSection);
            var EnrolledList = _context.StudentSubjects.Include(stdsub => stdsub.Subject).Include(stdsub => stdsub.Subject.Section).ToList();
            //force drop subjects with updated section
            foreach (StudentSubject stdsub in EnrolledList)
            {
                if (stdsub.Subject.SectionID == NewSection.ID)
                {
                    _context.StudentSubjects.Remove(stdsub);
                }
            }
            _context.SaveChanges();

            return NewSection;
        }

        public Section DeleteSection(int id)
        {
            var OldSection = ViewOneSection(id);
            if(OldSection != null)
            {
                _context.Sections.Remove(OldSection);
                _context.SaveChanges();

                //replace null sections in subjects with placeholders
                var SubjectList = _context.Subjects.Where(sub => sub.SectionID == null).ToList();

                foreach (var Subject in SubjectList)
                {
                    Subject.SectionID = -1;
                    _context.Subjects.Update(Subject);
                    _context.SaveChanges();
                }
                return OldSection;
            }

            return null; 
        }

        public List<SelectListItem> ListOfDays()
        {
            List<SelectListItem> days = new List<SelectListItem>();
            days.Add(new SelectListItem
            {
               Value = "Monday",
               Text = "Monday"
            });
            days.Add(new SelectListItem
            {
                Value = "Tuesday",
                Text = "Tuesday"
            });
            days.Add(new SelectListItem
            {
                Value = "Wednesday",
                Text = "Wednesday"
            });
            days.Add(new SelectListItem
            {
                Value = "Thursday",
                Text = "Thursday"
            });
            days.Add(new SelectListItem
            {
                Value = "Friday",
                Text = "Friday"
            });
            days.Add(new SelectListItem
            {
                Value = "Saturday",
                Text = "Saturday"
            });

            return days;
        }

        public List<SelectListItem> ListOfTimes()
        {
            List<SelectListItem> times = new List<SelectListItem>();
            times.Add(new SelectListItem
            {
                Value = "07:00 AM",
                Text = "07:00 AM"
            });
            times.Add(new SelectListItem
            {
                Value = "07:30 AM",
                Text = "07:30 AM"
            });
            times.Add(new SelectListItem
            {
                Value = "08:00 AM",
                Text = "08:00 AM"
            });
            times.Add(new SelectListItem
            {
                Value = "08:30 AM",
                Text = "08:30 AM"
            });
            times.Add(new SelectListItem
            {
                Value = "09:00 AM",
                Text = "09:00 AM"
            });
            times.Add(new SelectListItem
            {
                Value = "09:30 AM",
                Text = "09:30 AM"
            });
            times.Add(new SelectListItem
            {
                Value = "10:00 AM",
                Text = "10:00 AM"
            });
            times.Add(new SelectListItem
            {
                Value = "10:30 AM",
                Text = "10:30 AM"
            });
            times.Add(new SelectListItem
            {
                Value = "11:00 AM",
                Text = "11:00 AM"
            });
            times.Add(new SelectListItem
            {
                Value = "11:30 AM",
                Text = "11:30 AM"
            });
            times.Add(new SelectListItem
            {
                Value = "12:00 PM",
                Text = "12:00 PM"
            });
            times.Add(new SelectListItem
            {
                Value = "12:30 PM",
                Text = "12:30 PM"
            });
            times.Add(new SelectListItem
            {
                Value = "01:00 PM",
                Text = "01:00 PM"
            });
            times.Add(new SelectListItem
            {
                Value = "01:30 PM",
                Text = "01:30 PM"
            });
            times.Add(new SelectListItem
            {
                Value = "02:00 PM",
                Text = "02:00 PM"
            });
            times.Add(new SelectListItem
            {
                Value = "02:30 PM",
                Text = "02:30 PM"
            });
            times.Add(new SelectListItem
            {
                Value = "03:00 PM",
                Text = "03:00 PM"
            });
            times.Add(new SelectListItem
            {
                Value = "03:30 PM",
                Text = "03:30 PM"
            });
            times.Add(new SelectListItem
            {
                Value = "04:00 PM",
                Text = "04:00 PM"
            });
            times.Add(new SelectListItem
            {
                Value = "04:30 PM",
                Text = "04:30 PM"
            });
            times.Add(new SelectListItem
            {
                Value = "05:00 PM",
                Text = "05:00 PM"
            });
            times.Add(new SelectListItem
            {
                Value = "05:30 PM",
                Text = "05:30 PM"
            });
            times.Add(new SelectListItem
            {
                Value = "06:00 PM",
                Text = "06:00 PM"
            });
            times.Add(new SelectListItem
            {
                Value = "06:30 PM",
                Text = "06:30 PM"
            });
            times.Add(new SelectListItem
            {
                Value = "07:00 PM",
                Text = "07:00 PM"
            });
            times.Add(new SelectListItem
            {
                Value = "07:30 PM",
                Text = "07:30 PM"
            });

            return times;
        }

        public string GenerateSectionCode(string day, string startTime, string endTime)
        {
            string sectionCode = "";

            switch (day)
            {
                case "Monday":
                    sectionCode += "M";
                    break;
                case "Tuesday":
                    sectionCode += "T";
                    break;
                case "Wednesday":
                    sectionCode += "W";
                    break;
                case "Thursday":
                    sectionCode += "H";
                    break;
                case "Friday":
                    sectionCode += "F";
                    break;
                case "Saturday":
                    sectionCode += "S";
                    break;
            }

            switch (startTime)
            {
                case "07:00 AM":
                    sectionCode += "A";
                    break;
                case "07:30 AM":
                    sectionCode += "B";
                    break;
                case "08:00 AM":
                    sectionCode += "C";
                    break;
                case "08:30 AM":
                    sectionCode += "D";
                    break;
                case "09:00 AM":
                    sectionCode += "E";
                    break;
                case "09:30 AM":
                    sectionCode += "F";
                    break;
                case "10:00 AM":
                    sectionCode += "G";
                    break;
                case "10:30 AM":
                    sectionCode += "H";
                    break;
                case "11:00 AM":
                    sectionCode += "I";
                    break;
                case "11:30 AM":
                    sectionCode += "J";
                    break;
                case "12:00 PM":
                    sectionCode += "K";
                    break;
                case "12:30 PM":
                    sectionCode += "L";
                    break;
                case "01:00 PM":
                    sectionCode += "M";
                    break;
                case "01:30 PM":
                    sectionCode += "N";
                    break;
                case "02:00 PM":
                    sectionCode += "O";
                    break;
                case "02:30 PM":
                    sectionCode += "P";
                    break;
                case "03:00 PM":
                    sectionCode += "Q";
                    break;
                case "03:30 PM":
                    sectionCode += "R";
                    break;
                case "04:00 PM":
                    sectionCode += "S";
                    break;
                case "04:30 PM":
                    sectionCode += "T";
                    break;
                case "05:00 PM":
                    sectionCode += "U";
                    break;
                case "05:30 PM":
                    sectionCode += "V";
                    break;
                case "06:00 PM":
                    sectionCode += "W";
                    break;
                case "06:30 PM":
                    sectionCode += "X";
                    break;
                case "07:00 PM":
                    sectionCode += "Y";
                    break;
                case "07:30 PM":
                    sectionCode += "Z";
                    break;
            }

            switch (endTime)
            {
                case "07:00 AM":
                    sectionCode += "A";
                    break;
                case "07:30 AM":
                    sectionCode += "B";
                    break;
                case "08:00 AM":
                    sectionCode += "C";
                    break;
                case "08:30 AM":
                    sectionCode += "D";
                    break;
                case "09:00 AM":
                    sectionCode += "E";
                    break;
                case "09:30 AM":
                    sectionCode += "F";
                    break;
                case "10:00 AM":
                    sectionCode += "G";
                    break;
                case "10:30 AM":
                    sectionCode += "H";
                    break;
                case "11:00 AM":
                    sectionCode += "I";
                    break;
                case "11:30 AM":
                    sectionCode += "J";
                    break;
                case "12:00 PM":
                    sectionCode += "K";
                    break;
                case "12:30 PM":
                    sectionCode += "L";
                    break;
                case "01:00 PM":
                    sectionCode += "M";
                    break;
                case "01:30 PM":
                    sectionCode += "N";
                    break;
                case "02:00 PM":
                    sectionCode += "O";
                    break;
                case "02:30 PM":
                    sectionCode += "P";
                    break;
                case "03:00 PM":
                    sectionCode += "Q";
                    break;
                case "03:30 PM":
                    sectionCode += "R";
                    break;
                case "04:00 PM":
                    sectionCode += "S";
                    break;
                case "04:30 PM":
                    sectionCode += "T";
                    break;
                case "05:00 PM":
                    sectionCode += "U";
                    break;
                case "05:30 PM":
                    sectionCode += "V";
                    break;
                case "06:00 PM":
                    sectionCode += "W";
                    break;
                case "06:30 PM":
                    sectionCode += "X";
                    break;
                case "07:00 PM":
                    sectionCode += "Y";
                    break;
                case "07:30 PM":
                    sectionCode += "Z";
                    break;
            }

            return sectionCode;
        }

        public string GenerateSchedule(string day, string startTime, string endTime)
        {
            string schedule;

            schedule = day + ", " + startTime + "-" + endTime;

            return schedule;
        }

        public bool CheckDuplicate(string day, string startTime, string endTime)
        {
            var SectionList = ViewAllSections();
            foreach (Section sec in SectionList)
            {
                if (sec.Day == day && sec.StartTime == startTime && sec.EndTime == endTime)
                {
                    return true;
                }
            }

            return false;
        }
    }
}
