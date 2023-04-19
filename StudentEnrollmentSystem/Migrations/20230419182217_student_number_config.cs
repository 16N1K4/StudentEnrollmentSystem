using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace StudentEnrollmentSystem.Migrations
{
    public partial class student_number_config : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "872105bc-4069-4727-8ae1-7c4da0e7621c");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "d7bcb002-de39-4cf1-8271-b0e740e3bdb3");

            migrationBuilder.CreateSequence<int>(
                name: "StudentNo",
                startValue: 999L);

            migrationBuilder.AddColumn<int>(
                name: "StudentNumber",
                table: "AspNetUsers",
                type: "int",
                nullable: false,
                defaultValueSql: "NEXT VALUE FOR StudentNo");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "01c4af82-e7e4-441f-a04e-b976cf24d2f5", "871e0e8c-bf40-4255-94ae-664e69ebed84", "Administrator", "ADMINISTRATOR" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "e6f7f994-1a74-4e45-acce-ff2a74cc3a9a", "f62cde67-a4d9-4ede-808e-024afb51e3ff", "Student", "STUDENT" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropSequence(
                name: "StudentNo");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "01c4af82-e7e4-441f-a04e-b976cf24d2f5");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "e6f7f994-1a74-4e45-acce-ff2a74cc3a9a");

            migrationBuilder.DropColumn(
                name: "StudentNumber",
                table: "AspNetUsers");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "872105bc-4069-4727-8ae1-7c4da0e7621c", "e3141f96-9de1-4a77-bd68-f75ea610b41d", "Administrator", "ADMINISTRATOR" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "d7bcb002-de39-4cf1-8271-b0e740e3bdb3", "e66deb4c-9c6e-4bf9-9152-fc5a91de32bd", "Student", "STUDENT" });
        }
    }
}
