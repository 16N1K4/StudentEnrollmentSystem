﻿using StudentEnrollmentSystem.Models;
using StudentEnrollmentSystem.ViewModels;

namespace StudentEnrollmentSystem.IRepository
{
    public interface ICourseRepo
    {
        public List<Course> ViewAllCourses();
        public CourseViewModel ViewOneCourse(int id);
        public Course AddCourse(Course NewCourse);
        public Course UpdateCourse(Course NewCourse);
        public Course DeleteCourse(int id);
        public List<Department> FetchDepartmentList();
        public Course CourseByID(int id);
    }
}
