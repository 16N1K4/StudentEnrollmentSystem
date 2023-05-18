using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace StudentEnrollmentSystem.Migrations
{
    public partial class course_stored_procedure_CRUD : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            string storedProcedure = @"CREATE OR ALTER PROCEDURE view_one_course(@courseID AS INT)
            AS
            BEGIN
            SELECT * FROM Courses
            WHERE ID = @courseID
            END";

            migrationBuilder.Sql(storedProcedure);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            string storedProcedure = @"DROP PROCEDURE view_one_course";

            migrationBuilder.Sql(storedProcedure);
        }
    }
}
