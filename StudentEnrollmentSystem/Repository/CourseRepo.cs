using Microsoft.EntityFrameworkCore;
using StudentEnrollmentSystem.Data;
using StudentEnrollmentSystem.IRepository;
using StudentEnrollmentSystem.Models;
using System.Linq;

namespace StudentEnrollmentSystem.Repository
{
    public class CourseRepo : ICourseRepo
    {
        SESContext _context;

        public CourseRepo(SESContext context)
        {
            _context = context;
        }

        public List<Course> ViewAllCourses()
        {
            return _context.Courses.Where(crs => crs.ID > 0).Include(crs => crs.Department).ToList();
        }

        public Course ViewOneCourse(int id)
        {
            return _context.Courses.Include(crs => crs.Department).AsNoTracking().FirstOrDefault(crs => crs.ID == id);
        }

        public Course AddCourse(Course NewCourse)
        {
            _context.Courses.Add(NewCourse);
            _context.SaveChanges();

            return NewCourse;
        }

        public Course UpdateCourse(Course NewCourse)
        {
            _context.Courses.Update(NewCourse);
            _context.SaveChanges();

            return NewCourse;
        }

        public Course DeleteCourse(int id)
        {
            var OldCourse = ViewOneCourse(id);
            if(OldCourse != null)
            {
                _context.Courses.Remove(OldCourse);
                _context.SaveChanges();

                return OldCourse;
            }

            return null;
        }

        public List<Department> FetchDepartmentList()
        {
            return _context.Departments.Where(dept => dept.ID > 0).ToList();
        }
    }
}
