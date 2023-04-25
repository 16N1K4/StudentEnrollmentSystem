using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace StudentEnrollmentSystem.Migrations
{
    public partial class configure_set_null : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AspNetUsers_Courses_CourseID",
                table: "AspNetUsers");

            migrationBuilder.DropForeignKey(
                name: "FK_Subjects_Sections_SectionID",
                table: "Subjects");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "7e141c1e-cf90-45bb-89b8-d75c7ae92a81");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "9786882b-4b1a-4d8e-bc38-e12c6096416d");

            migrationBuilder.AlterColumn<int>(
                name: "SectionID",
                table: "Subjects",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "FacultyID",
                table: "Subjects",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "CourseID",
                table: "AspNetUsers",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "692c5135-002f-4bdc-be5a-0237ececf1a4", "ae1cac08-7f1b-46e0-bb92-e28de1209606", "Student", "STUDENT" },
                    { "e7d10545-21f0-4af5-906c-e51d4ff51f68", "d05bec7b-54f2-44ac-813a-a8409bd8724c", "Administrator", "ADMINISTRATOR" }
                });

            migrationBuilder.InsertData(
                table: "Courses",
                columns: new[] { "ID", "DeptID", "Name" },
                values: new object[] { -2, -1, "NULL" });

            migrationBuilder.InsertData(
                table: "Faculties",
                columns: new[] { "ID", "DeptID", "Email", "FirstName", "FullName", "LastName" },
                values: new object[] { -1, -1, "", "NULL", null, "" });

            migrationBuilder.InsertData(
                table: "Sections",
                columns: new[] { "ID", "Day", "EndTime", "FullSchedule", "SectionCode", "StartTime" },
                values: new object[] { -1, "", "", "NULL", "NULL", "" });

            migrationBuilder.AddForeignKey(
                name: "FK_AspNetUsers_Courses_CourseID",
                table: "AspNetUsers",
                column: "CourseID",
                principalTable: "Courses",
                principalColumn: "ID",
                onDelete: ReferentialAction.SetNull);

            migrationBuilder.AddForeignKey(
                name: "FK_Subjects_Sections_SectionID",
                table: "Subjects",
                column: "SectionID",
                principalTable: "Sections",
                principalColumn: "ID",
                onDelete: ReferentialAction.SetNull);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AspNetUsers_Courses_CourseID",
                table: "AspNetUsers");

            migrationBuilder.DropForeignKey(
                name: "FK_Subjects_Sections_SectionID",
                table: "Subjects");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "692c5135-002f-4bdc-be5a-0237ececf1a4");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "e7d10545-21f0-4af5-906c-e51d4ff51f68");

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "ID",
                keyValue: -2);

            migrationBuilder.DeleteData(
                table: "Faculties",
                keyColumn: "ID",
                keyValue: -1);

            migrationBuilder.DeleteData(
                table: "Sections",
                keyColumn: "ID",
                keyValue: -1);

            migrationBuilder.AlterColumn<int>(
                name: "SectionID",
                table: "Subjects",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "FacultyID",
                table: "Subjects",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "CourseID",
                table: "AspNetUsers",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "7e141c1e-cf90-45bb-89b8-d75c7ae92a81", "19b99484-ec7d-427c-83f4-141d8d191574", "Student", "STUDENT" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "9786882b-4b1a-4d8e-bc38-e12c6096416d", "6dfa7c9d-6c2b-4cba-b0d7-6f5e919a5f01", "Administrator", "ADMINISTRATOR" });

            migrationBuilder.AddForeignKey(
                name: "FK_AspNetUsers_Courses_CourseID",
                table: "AspNetUsers",
                column: "CourseID",
                principalTable: "Courses",
                principalColumn: "ID");

            migrationBuilder.AddForeignKey(
                name: "FK_Subjects_Sections_SectionID",
                table: "Subjects",
                column: "SectionID",
                principalTable: "Sections",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
