using Microsoft.EntityFrameworkCore;
using StudentEnrollmentAPI.Data;
using StudentEnrollmentAPI.IRepository;
using StudentEnrollmentAPI.Models;

namespace StudentEnrollmentAPI.Repository
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
    }
}
