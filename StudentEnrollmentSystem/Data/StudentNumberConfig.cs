using Microsoft.EntityFrameworkCore;
using StudentEnrollmentSystem.Models;

namespace StudentEnrollmentSystem.Data
{
    public static class StudentNumberConfig
    {
        public static void SetStudentNumbers(this ModelBuilder builder)
        {
            builder.HasSequence<int>("StudentNo")
                .StartsAt(999);

            builder.Entity<ApplicationUser>()
                .Property(u => u.StudentNumber)
                .HasDefaultValueSql("NEXT VALUE FOR StudentNo");
        }
    }
}
