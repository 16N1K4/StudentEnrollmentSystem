using StudentEnrollmentSystem.Models;

namespace StudentEnrollmentSystem.IRepository
{
    public interface IFacultyRepo
    {
        public List<Faculty> ViewAllFaculty();
        public Faculty ViewOneFaculty(int id);
        public Faculty AddFaculty(Faculty NewFaculty);
        public Faculty UpdateFaculty(Faculty NewFaculty);
        public Faculty DeleteFaculty(int id);
        public List<Department> FetchDepartmentList();
    }
}
