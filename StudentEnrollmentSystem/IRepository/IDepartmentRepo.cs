using StudentEnrollmentSystem.Models;

namespace StudentEnrollmentSystem.IRepository
{
    public interface IDepartmentRepo
    {
        public List<Department> ViewAllDepartments();
        public Department ViewOneDepartment(int id);
        public Department AddDepartment(Department NewDept);
        public Department UpdateDepartment(Department NewDept);
        public Department DeleteDepartment(int id);
    }
}
