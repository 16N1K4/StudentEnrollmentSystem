using Microsoft.EntityFrameworkCore;
using StudentEnrollmentAPI.Models;

namespace StudentEnrollmentAPI.Data
{
    public static class ERConfig
    {
        public static void ConfigureRelationships(this ModelBuilder builder)
        {
            //1 Student (ApplicationUser) to N StudentSubject
            builder.Entity<StudentSubject>()
                .HasOne<ApplicationUser>(stdsub => stdsub.Student)
                .WithMany(sub => sub.Subjects)
                .HasForeignKey(stdsub => stdsub.StudentID)
                .OnDelete(DeleteBehavior.Cascade);

            //1 Subject to N StudentSubject
            builder.Entity<StudentSubject>()
                .HasOne<Subject>(stdsub => stdsub.Subject)
                .WithMany(std => std.Students)
                .HasForeignKey(stdsub => stdsub.SubjectID)
                .OnDelete(DeleteBehavior.Cascade);

            //1 Department to N Faculty
            builder.Entity<Faculty>()
                .HasOne<Department>(fac => fac.Department)
                .WithMany(dept => dept.Faculties)
                .HasForeignKey(fac => fac.DeptID)
                .OnDelete(DeleteBehavior.Cascade);

            //1 Faculty to N Subject
            builder.Entity<Subject>()
                .HasOne<Faculty>(sub => sub.Faculty)
                .WithMany(fac => fac.Subjects)
                .HasForeignKey(sub => sub.FacultyID)
                .OnDelete(DeleteBehavior.SetNull);

            //1 Course to N Student (ApplicationUser)
            builder.Entity<ApplicationUser>()
                .HasOne<Course>(std => std.Course)
                .WithMany(crs => crs.Students)
                .HasForeignKey(std => std.CourseID)
                .OnDelete(DeleteBehavior.SetNull);

            //1 Course to N Subject
            builder.Entity<Subject>()
                .HasOne<Course>(sub => sub.Course)
                .WithMany(crs => crs.Subjects)
                .HasForeignKey(sub => sub.CourseID)
                .OnDelete(DeleteBehavior.Cascade);

            //1 Department to N Course
            builder.Entity<Course>()
                .HasOne<Department>(crs => crs.Department)
                .WithMany(dept => dept.Courses)
                .HasForeignKey(crs => crs.DeptID)
                .OnDelete(DeleteBehavior.Cascade);

            //1 Section to N Subject
            builder.Entity<Subject>()
                .HasOne<Section>(sub => sub.Section)
                .WithMany(sec => sec.Subjects)
                .HasForeignKey(sub => sub.SectionID)
                .OnDelete(DeleteBehavior.SetNull);
        }
    }
}
