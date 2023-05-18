using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace StudentEnrollmentSystem.Migrations
{
    public partial class course_SP_delete : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            string storedProcedure = @"CREATE OR ALTER PROCEDURE delete_course(@courseID AS INT)
            AS
            BEGIN
            DELETE FROM Courses
            WHERE ID = @courseID
            END";

            migrationBuilder.Sql(storedProcedure);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            string storedProcedure = @"DROP PROCEDURE delete_course";

            migrationBuilder.Sql(storedProcedure);
        }
    }
}
