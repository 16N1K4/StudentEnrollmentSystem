using Microsoft.EntityFrameworkCore;
using StudentEnrollmentSystem.Data;
using StudentEnrollmentSystem.IRepository;
using StudentEnrollmentSystem.Models;

namespace StudentEnrollmentSystem.Repository
{
    public class FacultyRepo : IFacultyRepo
    {
        SESContext _context;

        public FacultyRepo(SESContext context)
        {
            _context = context;
        }

        public List<Faculty> ViewAllFaculty()
        {
            return _context.Faculties.Where(fac => fac.ID > 0).ToList();
        }

        public Faculty ViewOneFaculty(int id)
        {
            return _context.Faculties.AsNoTracking().FirstOrDefault(fac => fac.ID == id);
        }

        public Faculty AddFaculty(Faculty NewFaculty)
        {
            _context.Faculties.Add(NewFaculty);
            _context.SaveChanges();

            return NewFaculty;
        }

        public Faculty UpdateFaculty(Faculty NewFaculty)
        {
            _context.Faculties.Update(NewFaculty);
            _context.SaveChanges();

            return NewFaculty;
        }

        public Faculty DeleteFaculty(int id)
        {
            var OldFaculty = ViewOneFaculty(id);
            if(OldFaculty != null)
            {
                _context.Faculties.Remove(OldFaculty);
                _context.SaveChanges();

                return OldFaculty;
            }

            return null;
        }
    }
}
