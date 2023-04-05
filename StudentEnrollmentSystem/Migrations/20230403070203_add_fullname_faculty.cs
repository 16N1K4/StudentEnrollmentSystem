using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace StudentEnrollmentSystem.Migrations
{
    public partial class add_fullname_faculty : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "90fef586-2354-4a5d-84be-230d8d4ab65d");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "9c6be071-5e86-465e-bdf4-995feefe78be");

            migrationBuilder.AddColumn<string>(
                name: "FullName",
                table: "Faculties",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "44637bc8-0d8f-4578-bef5-512da2eff401", "0272ce4e-7fff-4edc-b217-2908d7abc0b6", "Administrator", "ADMINISTRATOR" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "9d19b4f7-d26d-49c3-94ad-4c26d4ed48cf", "b0a59032-7b6b-4575-8f1a-5560754cd2a5", "Student", "STUDENT" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "44637bc8-0d8f-4578-bef5-512da2eff401");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "9d19b4f7-d26d-49c3-94ad-4c26d4ed48cf");

            migrationBuilder.DropColumn(
                name: "FullName",
                table: "Faculties");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "90fef586-2354-4a5d-84be-230d8d4ab65d", "07db3d07-8c34-48c5-b9a6-4ca713183b22", "Administrator", "ADMINISTRATOR" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "9c6be071-5e86-465e-bdf4-995feefe78be", "a275941c-aa2d-4970-82c7-0b17e41cab78", "Student", "STUDENT" });
        }
    }
}
