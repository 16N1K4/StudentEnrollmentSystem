using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace StudentEnrollmentSystem.Migrations
{
    public partial class course_SP_update : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            string storedProcedure = @"CREATE OR ALTER PROCEDURE update_course(@courseID AS INT, @courseName AS NVARCHAR(250), @deptID AS INT)
            AS
            BEGIN
            UPDATE Courses
            SET Name = @courseName, DeptID = @deptID
            WHERE ID = @courseID
            END";

            migrationBuilder.Sql(storedProcedure);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            string storedProcedure = @"DROP PROCEDURE update_course";

            migrationBuilder.Sql(storedProcedure);
        }
    }
}
