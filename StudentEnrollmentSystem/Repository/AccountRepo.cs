using Microsoft.EntityFrameworkCore;
using StudentEnrollmentSystem.Data;
using StudentEnrollmentSystem.Models;
using StudentEnrollmentSystem.IRepository;

namespace StudentEnrollmentSystem.Repository
{
    public class AccountRepo : IAccountRepo
    {
        SESContext _context;

        public AccountRepo(SESContext context)
        {
            _context = context;
        }

        public List<ApplicationUser> ViewAllStudents()
        {
            return _context.Users.Where(u => u.CourseID > 0).Include(u => u.Course).ToList();
        }

        public ApplicationUser ViewOneStudent(string id)
        {
            return _context.Users.Include(u => u.Course).FirstOrDefault(u => u.Id == id);
        }

    }
}
