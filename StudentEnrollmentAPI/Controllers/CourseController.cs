using Microsoft.AspNetCore.Mvc;
using StudentEnrollmentAPI.DTO;
using StudentEnrollmentAPI.IRepository;

namespace StudentEnrollmentAPI.Controllers
{
    [ApiController]
    [Route("api/v1/[controller]")]
    public class CourseController : ControllerBase
    {
        ICourseRepo _repo;

        public CourseController(ICourseRepo repo)
        {
            _repo = repo;
        }

        /*[HttpGet]
        public IActionResult ViewAllCourses()
        {
            var CourseList = _repo.ViewAllCourses();
            List <CourseDTO> courses = new List<CourseDTO>();
            foreach(var Course in CourseList)
            {
                courses.Add(new CourseDTO
                {
                    ID = Course.ID,
                    Name = Course.Name,
                    DeptID = Course.DeptID
                });
            }

            return Ok(courses);
        }*/
    }
}
