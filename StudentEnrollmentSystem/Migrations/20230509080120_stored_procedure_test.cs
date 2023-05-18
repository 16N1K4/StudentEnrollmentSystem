using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace StudentEnrollmentSystem.Migrations
{
    public partial class stored_procedure_test : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            string storedProcedure = @"CREATE OR ALTER PROCEDURE view_all_depts
            AS
            BEGIN
            SELECT * FROM Departments
            WHERE ID > 0
            END";

            migrationBuilder.Sql(storedProcedure);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            string storedProcedure = @"DROP PROCEDURE view_all_depts";

            migrationBuilder.Sql(storedProcedure);
        }
    }
}
