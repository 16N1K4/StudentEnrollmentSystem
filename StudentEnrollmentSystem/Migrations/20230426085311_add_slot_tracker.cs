using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace StudentEnrollmentSystem.Migrations
{
    public partial class add_slot_tracker : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "1d6e01a5-4066-4d51-a6ea-0669e6990547");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "ae586af2-de59-4f8d-9ad5-b530efe802f7");

            migrationBuilder.AddColumn<int>(
                name: "StudentCount",
                table: "Subjects",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "31209b3d-f4e7-4f6f-bb1d-f91805dccae9", "fcdc371a-91cf-4139-a5ac-ff139f07d94a", "Student", "STUDENT" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "6b3b5d7d-80d4-4734-bb42-407492ec1821", "fd3ccb40-3780-42b8-978d-c6b24589f266", "Administrator", "ADMINISTRATOR" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "31209b3d-f4e7-4f6f-bb1d-f91805dccae9");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "6b3b5d7d-80d4-4734-bb42-407492ec1821");

            migrationBuilder.DropColumn(
                name: "StudentCount",
                table: "Subjects");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "1d6e01a5-4066-4d51-a6ea-0669e6990547", "e72b7274-ff39-40ff-b9cf-80d4f4decb2a", "Administrator", "ADMINISTRATOR" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "ae586af2-de59-4f8d-9ad5-b530efe802f7", "95b3c4f7-6bbd-4933-9aac-627bfa31daef", "Student", "STUDENT" });
        }
    }
}
