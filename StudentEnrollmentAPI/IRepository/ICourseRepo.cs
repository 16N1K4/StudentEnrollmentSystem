using StudentEnrollmentAPI.Models;

namespace StudentEnrollmentAPI.IRepository
{
    public interface ICourseRepo
    {
        public List<Course> ViewAllCourses();
    }
}
