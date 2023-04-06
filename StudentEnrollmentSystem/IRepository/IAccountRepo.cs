using StudentEnrollmentSystem.Models;

namespace StudentEnrollmentSystem.IRepository
{
    public interface IAccountRepo
    {
        public List<ApplicationUser> ViewAllStudents();
        public ApplicationUser ViewOneStudent(string id);
    }
}
