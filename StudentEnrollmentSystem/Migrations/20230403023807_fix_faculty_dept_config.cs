using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace StudentEnrollmentSystem.Migrations
{
    public partial class fix_faculty_dept_config : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Faculties_Departments_DepartmentID",
                table: "Faculties");

            migrationBuilder.DropIndex(
                name: "IX_Faculties_DepartmentID",
                table: "Faculties");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "04582e64-7603-4206-af65-37888b9161ca");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "81702cfd-0c46-48ee-a871-f27c81b4c5a9");

            migrationBuilder.DropColumn(
                name: "DepartmentID",
                table: "Faculties");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "90fef586-2354-4a5d-84be-230d8d4ab65d", "07db3d07-8c34-48c5-b9a6-4ca713183b22", "Administrator", "ADMINISTRATOR" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "9c6be071-5e86-465e-bdf4-995feefe78be", "a275941c-aa2d-4970-82c7-0b17e41cab78", "Student", "STUDENT" });

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
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Faculties_Departments_DeptID",
                table: "Faculties");

            migrationBuilder.DropIndex(
                name: "IX_Faculties_DeptID",
                table: "Faculties");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "90fef586-2354-4a5d-84be-230d8d4ab65d");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "9c6be071-5e86-465e-bdf4-995feefe78be");

            migrationBuilder.AddColumn<int>(
                name: "DepartmentID",
                table: "Faculties",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "04582e64-7603-4206-af65-37888b9161ca", "a08a0828-0dcf-415f-b223-a72f70c49fd9", "Administrator", "ADMINISTRATOR" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "81702cfd-0c46-48ee-a871-f27c81b4c5a9", "c6c1ef16-f800-47a7-a021-fea56f61150e", "Student", "STUDENT" });

            migrationBuilder.CreateIndex(
                name: "IX_Faculties_DepartmentID",
                table: "Faculties",
                column: "DepartmentID");

            migrationBuilder.AddForeignKey(
                name: "FK_Faculties_Departments_DepartmentID",
                table: "Faculties",
                column: "DepartmentID",
                principalTable: "Departments",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
