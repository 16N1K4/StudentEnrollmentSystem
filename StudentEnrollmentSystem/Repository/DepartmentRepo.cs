using Microsoft.EntityFrameworkCore;
using StudentEnrollmentSystem.Data;
using StudentEnrollmentSystem.IRepository;
using StudentEnrollmentSystem.Models;

namespace StudentEnrollmentSystem.Repository
{
    public class DepartmentRepo : IDepartmentRepo
    {
        SESContext _context;

        public DepartmentRepo(SESContext context)
        {
            _context = context;
        }

        public List<Department> ViewAllDepartments()
        {
            //return _context.Departments.Where(dept => dept.ID > 0).ToList();
            return _context.Departments.FromSqlRaw("EXEC view_all_depts").ToList();
        }

        public Department ViewOneDepartment(int id)
        {
            return _context.Departments.AsNoTracking().FirstOrDefault(dept => dept.ID == id);
        }

        public Department AddDepartment(Department NewDept)
        {
            _context.Departments.Add(NewDept);
            _context.SaveChanges();

            return NewDept;
        }

        public Department UpdateDepartment(Department NewDept)
        {
            _context.Departments.Update(NewDept);
            _context.SaveChanges();

            return NewDept;
        }

        public Department DeleteDepartment(int id)
        {
            var OldDept = ViewOneDepartment(id);
            if(OldDept != null)
            {
                _context.Departments.Remove(OldDept);
                _context.SaveChanges();

                return OldDept;
            }

            return null;
        }
    }
}
