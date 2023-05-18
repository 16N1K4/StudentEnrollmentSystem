using Microsoft.EntityFrameworkCore;
using StudentEnrollmentSystem.Data;
using StudentEnrollmentSystem.IRepository;
using StudentEnrollmentSystem.Models;
using Newtonsoft.Json;
using System.Linq;
using System.Net;
using StudentEnrollmentSystem.ViewModels;

namespace StudentEnrollmentSystem.Repository
{
    public class CourseRepo : ICourseRepo
    {
        SESContext _context;
        IConfiguration _config;
        string baseURL = "http://localhost:5010/api/v1";
        HttpClient client = new HttpClient();

        public CourseRepo(SESContext context, IConfiguration config)
        {
            _context = context;
            _config = config;
            client.DefaultRequestHeaders.Add("ApiKey", _config.GetValue<string>("ApiKey"));
        }

        public List<Course> ViewAllCourses()
        {
            var response = client.GetAsync(baseURL + "/course").Result;
            if (response.IsSuccessStatusCode)
            {
                var content = response.Content.ReadAsStringAsync().Result;
                List<Course> courses = JsonConvert.DeserializeObject<List<Course>>(content);
                return courses;
            }

            return null;
            //return _context.Courses.Where(crs => crs.ID > 0).Include(crs => crs.Department).ToList();
        }

        public CourseViewModel ViewOneCourse(int id)
        {
            var response = client.GetAsync(baseURL + "/course/" + id).Result;
            if (response.IsSuccessStatusCode)
            {
                var content = response.Content.ReadAsStringAsync().Result;
                CourseViewModel crs = JsonConvert.DeserializeObject<CourseViewModel>(content);
                if (content != null)
                {
                    return crs;
                }
            }

            return null;
            //return _context.Courses.Include(crs => crs.Department).AsNoTracking().FirstOrDefault(crs => crs.ID == id);
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
            var response = client.DeleteAsync(baseURL + "/course/" + id).Result;
            if (response.IsSuccessStatusCode)
            {
                return _context.Courses.FirstOrDefault(crs => crs.ID == id);
            }
            return null;
        }

        public List<Department> FetchDepartmentList()
        {
            return _context.Departments.Where(dept => dept.ID > 0).ToList();
        }
    }
}
