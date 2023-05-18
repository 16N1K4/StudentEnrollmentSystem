using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace StudentEnrollmentSystem.Migrations
{
    public partial class stored_procedure_API : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            string storedProcedure2 = @"CREATE OR ALTER PROCEDURE view_all_courses
            AS
            BEGIN
            SELECT * FROM Courses
            WHERE ID > 0
            END";

            migrationBuilder.Sql(storedProcedure2);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            string storedProcedure2 = @"DROP PROCEDURE view_all_courses";

            migrationBuilder.Sql(storedProcedure2);
        }
    }
}
