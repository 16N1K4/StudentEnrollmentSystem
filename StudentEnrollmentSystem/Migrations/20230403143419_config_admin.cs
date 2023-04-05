using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace StudentEnrollmentSystem.Migrations
{
    public partial class config_admin : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "44637bc8-0d8f-4578-bef5-512da2eff401");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "9d19b4f7-d26d-49c3-94ad-4c26d4ed48cf");

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
                values: new object[] { "872105bc-4069-4727-8ae1-7c4da0e7621c", "e3141f96-9de1-4a77-bd68-f75ea610b41d", "Administrator", "ADMINISTRATOR" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "d7bcb002-de39-4cf1-8271-b0e740e3bdb3", "e66deb4c-9c6e-4bf9-9152-fc5a91de32bd", "Student", "STUDENT" });

            migrationBuilder.InsertData(
                table: "Departments",
                columns: new[] { "ID", "Name" },
                values: new object[] { -1, "Admin" });

            migrationBuilder.InsertData(
                table: "Courses",
                columns: new[] { "ID", "DeptID", "Name" },
                values: new object[] { -1, -1, "Admin" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "872105bc-4069-4727-8ae1-7c4da0e7621c");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "d7bcb002-de39-4cf1-8271-b0e740e3bdb3");

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "ID",
                keyValue: -1);

            migrationBuilder.DeleteData(
                table: "Departments",
                keyColumn: "ID",
                keyValue: -1);

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
                values: new object[] { "44637bc8-0d8f-4578-bef5-512da2eff401", "0272ce4e-7fff-4edc-b217-2908d7abc0b6", "Administrator", "ADMINISTRATOR" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "9d19b4f7-d26d-49c3-94ad-4c26d4ed48cf", "b0a59032-7b6b-4575-8f1a-5560754cd2a5", "Student", "STUDENT" });
        }
    }
}
