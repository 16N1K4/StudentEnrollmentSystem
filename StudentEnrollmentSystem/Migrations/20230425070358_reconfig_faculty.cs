using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace StudentEnrollmentSystem.Migrations
{
    public partial class reconfig_faculty : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Faculties_Departments_DeptID",
                table: "Faculties");

            migrationBuilder.DropForeignKey(
                name: "FK_Subjects_Faculties_FacultyID",
                table: "Subjects");

            migrationBuilder.DropIndex(
                name: "IX_Faculties_DeptID",
                table: "Faculties");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "692c5135-002f-4bdc-be5a-0237ececf1a4");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "e7d10545-21f0-4af5-906c-e51d4ff51f68");

            migrationBuilder.DropColumn(
                name: "DeptID",
                table: "Faculties");

            migrationBuilder.AddColumn<int>(
                name: "DepartmentID",
                table: "Faculties",
                type: "int",
                nullable: true);

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "1d6e01a5-4066-4d51-a6ea-0669e6990547", "e72b7274-ff39-40ff-b9cf-80d4f4decb2a", "Administrator", "ADMINISTRATOR" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "ae586af2-de59-4f8d-9ad5-b530efe802f7", "95b3c4f7-6bbd-4933-9aac-627bfa31daef", "Student", "STUDENT" });

            migrationBuilder.CreateIndex(
                name: "IX_Faculties_DepartmentID",
                table: "Faculties",
                column: "DepartmentID");

            migrationBuilder.AddForeignKey(
                name: "FK_Faculties_Departments_DepartmentID",
                table: "Faculties",
                column: "DepartmentID",
                principalTable: "Departments",
                principalColumn: "ID");

            migrationBuilder.AddForeignKey(
                name: "FK_Subjects_Faculties_FacultyID",
                table: "Subjects",
                column: "FacultyID",
                principalTable: "Faculties",
                principalColumn: "ID",
                onDelete: ReferentialAction.SetNull);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Faculties_Departments_DepartmentID",
                table: "Faculties");

            migrationBuilder.DropForeignKey(
                name: "FK_Subjects_Faculties_FacultyID",
                table: "Subjects");

            migrationBuilder.DropIndex(
                name: "IX_Faculties_DepartmentID",
                table: "Faculties");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "1d6e01a5-4066-4d51-a6ea-0669e6990547");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "ae586af2-de59-4f8d-9ad5-b530efe802f7");

            migrationBuilder.DropColumn(
                name: "DepartmentID",
                table: "Faculties");

            migrationBuilder.AddColumn<int>(
                name: "DeptID",
                table: "Faculties",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "692c5135-002f-4bdc-be5a-0237ececf1a4", "ae1cac08-7f1b-46e0-bb92-e28de1209606", "Student", "STUDENT" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "e7d10545-21f0-4af5-906c-e51d4ff51f68", "d05bec7b-54f2-44ac-813a-a8409bd8724c", "Administrator", "ADMINISTRATOR" });

            migrationBuilder.UpdateData(
                table: "Faculties",
                keyColumn: "ID",
                keyValue: -1,
                column: "DeptID",
                value: -1);

            migrationBuilder.CreateIndex(
                name: "IX_Faculties_DeptID",
                table: "Faculties",
                column: "DeptID");

            migrationBuilder.AddForeignKey(
                name: "FK_Faculties_Departments_DeptID",
                table: "Faculties",
                column: "DeptID",
                principalTable: "Departments",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Subjects_Faculties_FacultyID",
                table: "Subjects",
                column: "FacultyID",
                principalTable: "Faculties",
                principalColumn: "ID");
        }
    }
}
