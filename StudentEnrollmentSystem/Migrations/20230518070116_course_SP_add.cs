using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace StudentEnrollmentSystem.Migrations
{
    public partial class course_SP_add : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            string storedProcedure = @"CREATE OR ALTER PROCEDURE add_course(@courseName AS NVARCHAR, @DeptID AS INT)
            AS
            BEGIN
            INSERT INTO Courses (Name, DeptID)
            VALUES(@courseName, @DeptID)
            END";

            migrationBuilder.Sql(storedProcedure);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            string storedProcedure = @"DROP PROCEDURE add_course";

            migrationBuilder.Sql(storedProcedure);
        }
    }
}
