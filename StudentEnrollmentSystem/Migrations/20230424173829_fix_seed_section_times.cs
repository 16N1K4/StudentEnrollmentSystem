using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace StudentEnrollmentSystem.Migrations
{
    public partial class fix_seed_section_times : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "03ee7b87-22be-480b-b789-5ade53e3a0d3");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "89e1bbc4-24fc-4eef-b8cc-6020dc9b4286");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "7e141c1e-cf90-45bb-89b8-d75c7ae92a81", "19b99484-ec7d-427c-83f4-141d8d191574", "Student", "STUDENT" },
                    { "9786882b-4b1a-4d8e-bc38-e12c6096416d", "6dfa7c9d-6c2b-4cba-b0d7-6f5e919a5f01", "Administrator", "ADMINISTRATOR" }
                });

            migrationBuilder.UpdateData(
                table: "Sections",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "EndTime", "FullSchedule", "StartTime" },
                values: new object[] { "08:30 AM", "Monday, 07:00 AM-08:30 AM", "07:00 AM" });

            migrationBuilder.UpdateData(
                table: "Sections",
                keyColumn: "ID",
                keyValue: 2,
                columns: new[] { "FullSchedule", "StartTime" },
                values: new object[] { "Monday, 08:30 AM-10:00 AM", "08:30 AM" });

            migrationBuilder.UpdateData(
                table: "Sections",
                keyColumn: "ID",
                keyValue: 4,
                columns: new[] { "EndTime", "FullSchedule" },
                values: new object[] { "01:00 PM", "Monday, 11:30 AM-01:00 PM" });

            migrationBuilder.UpdateData(
                table: "Sections",
                keyColumn: "ID",
                keyValue: 5,
                columns: new[] { "EndTime", "FullSchedule", "StartTime" },
                values: new object[] { "02:30 PM", "Monday, 01:00 PM-02:30 PM", "01:00 PM" });

            migrationBuilder.UpdateData(
                table: "Sections",
                keyColumn: "ID",
                keyValue: 6,
                columns: new[] { "EndTime", "FullSchedule", "StartTime" },
                values: new object[] { "04:00 PM", "Monday, 02:30 PM-04:00 PM", "02:30 PM" });

            migrationBuilder.UpdateData(
                table: "Sections",
                keyColumn: "ID",
                keyValue: 7,
                columns: new[] { "EndTime", "FullSchedule", "StartTime" },
                values: new object[] { "05:30 PM", "Monday, 04:00 PM-05:30 PM", "04:00 PM" });

            migrationBuilder.UpdateData(
                table: "Sections",
                keyColumn: "ID",
                keyValue: 8,
                columns: new[] { "EndTime", "FullSchedule", "StartTime" },
                values: new object[] { "07:00 PM", "Monday, 05:30 PM-07:00 PM", "05:30 PM" });

            migrationBuilder.UpdateData(
                table: "Sections",
                keyColumn: "ID",
                keyValue: 9,
                columns: new[] { "EndTime", "FullSchedule", "StartTime" },
                values: new object[] { "08:30 AM", "Tuesday, 07:00 AM-08:30 AM", "07:00 AM" });

            migrationBuilder.UpdateData(
                table: "Sections",
                keyColumn: "ID",
                keyValue: 10,
                columns: new[] { "FullSchedule", "StartTime" },
                values: new object[] { "Tuesday, 08:30 AM-10:00 AM", "08:30 AM" });

            migrationBuilder.UpdateData(
                table: "Sections",
                keyColumn: "ID",
                keyValue: 12,
                columns: new[] { "EndTime", "FullSchedule" },
                values: new object[] { "01:00 PM", "Tuesday, 11:30 AM-01:00 PM" });

            migrationBuilder.UpdateData(
                table: "Sections",
                keyColumn: "ID",
                keyValue: 13,
                columns: new[] { "EndTime", "FullSchedule", "StartTime" },
                values: new object[] { "02:30 PM", "Tuesday, 01:00 PM-02:30 PM", "01:00 PM" });

            migrationBuilder.UpdateData(
                table: "Sections",
                keyColumn: "ID",
                keyValue: 14,
                columns: new[] { "EndTime", "FullSchedule", "StartTime" },
                values: new object[] { "04:00 PM", "Tuesday, 02:30 PM-04:00 PM", "02:30 PM" });

            migrationBuilder.UpdateData(
                table: "Sections",
                keyColumn: "ID",
                keyValue: 15,
                columns: new[] { "EndTime", "FullSchedule", "StartTime" },
                values: new object[] { "05:30 PM", "Tuesday, 04:00 PM-05:30 PM", "04:00 PM" });

            migrationBuilder.UpdateData(
                table: "Sections",
                keyColumn: "ID",
                keyValue: 16,
                columns: new[] { "EndTime", "FullSchedule", "StartTime" },
                values: new object[] { "07:00 PM", "Tuesday, 05:30 PM-07:00 PM", "05:30 PM" });

            migrationBuilder.UpdateData(
                table: "Sections",
                keyColumn: "ID",
                keyValue: 17,
                columns: new[] { "EndTime", "FullSchedule", "StartTime" },
                values: new object[] { "08:30 AM", "Wednesday, 07:00 AM-08:30 AM", "07:00 AM" });

            migrationBuilder.UpdateData(
                table: "Sections",
                keyColumn: "ID",
                keyValue: 18,
                columns: new[] { "FullSchedule", "StartTime" },
                values: new object[] { "Wednesday, 08:30 AM-10:00 AM", "08:30 AM" });

            migrationBuilder.UpdateData(
                table: "Sections",
                keyColumn: "ID",
                keyValue: 20,
                columns: new[] { "EndTime", "FullSchedule" },
                values: new object[] { "01:00 PM", "Wednesday, 11:30 AM-01:00 PM" });

            migrationBuilder.UpdateData(
                table: "Sections",
                keyColumn: "ID",
                keyValue: 21,
                columns: new[] { "EndTime", "FullSchedule", "StartTime" },
                values: new object[] { "02:30 PM", "Wednesday, 01:00 PM-02:30 PM", "01:00 PM" });

            migrationBuilder.UpdateData(
                table: "Sections",
                keyColumn: "ID",
                keyValue: 22,
                columns: new[] { "EndTime", "FullSchedule", "StartTime" },
                values: new object[] { "04:00 PM", "Wednesday, 02:30 PM-04:00 PM", "02:30 PM" });

            migrationBuilder.UpdateData(
                table: "Sections",
                keyColumn: "ID",
                keyValue: 23,
                columns: new[] { "EndTime", "FullSchedule", "StartTime" },
                values: new object[] { "05:30 PM", "Wednesday, 04:00 PM-05:30 PM", "04:00 PM" });

            migrationBuilder.UpdateData(
                table: "Sections",
                keyColumn: "ID",
                keyValue: 24,
                columns: new[] { "EndTime", "FullSchedule", "StartTime" },
                values: new object[] { "07:00 PM", "Wednesday, 05:30 PM-07:00 PM", "05:30 PM" });

            migrationBuilder.UpdateData(
                table: "Sections",
                keyColumn: "ID",
                keyValue: 25,
                columns: new[] { "EndTime", "FullSchedule", "StartTime" },
                values: new object[] { "08:30 AM", "Thursday, 07:00 AM-08:30 AM", "07:00 AM" });

            migrationBuilder.UpdateData(
                table: "Sections",
                keyColumn: "ID",
                keyValue: 26,
                columns: new[] { "FullSchedule", "StartTime" },
                values: new object[] { "Thursday, 08:30 AM-10:00 AM", "08:30 AM" });

            migrationBuilder.UpdateData(
                table: "Sections",
                keyColumn: "ID",
                keyValue: 28,
                columns: new[] { "EndTime", "FullSchedule" },
                values: new object[] { "01:00 PM", "Thursday, 11:30 AM-01:00 PM" });

            migrationBuilder.UpdateData(
                table: "Sections",
                keyColumn: "ID",
                keyValue: 29,
                columns: new[] { "EndTime", "FullSchedule", "StartTime" },
                values: new object[] { "02:30 PM", "Thursday, 01:00 PM-02:30 PM", "01:00 PM" });

            migrationBuilder.UpdateData(
                table: "Sections",
                keyColumn: "ID",
                keyValue: 30,
                columns: new[] { "EndTime", "FullSchedule", "StartTime" },
                values: new object[] { "04:00 PM", "Thursday, 02:30 PM-04:00 PM", "02:30 PM" });

            migrationBuilder.UpdateData(
                table: "Sections",
                keyColumn: "ID",
                keyValue: 31,
                columns: new[] { "EndTime", "FullSchedule", "StartTime" },
                values: new object[] { "05:30 PM", "Thursday, 04:00 PM-05:30 PM", "04:00 PM" });

            migrationBuilder.UpdateData(
                table: "Sections",
                keyColumn: "ID",
                keyValue: 32,
                columns: new[] { "EndTime", "FullSchedule", "StartTime" },
                values: new object[] { "07:00 PM", "Thursday, 05:30 PM-07:00 PM", "05:30 PM" });

            migrationBuilder.UpdateData(
                table: "Sections",
                keyColumn: "ID",
                keyValue: 33,
                columns: new[] { "EndTime", "FullSchedule", "StartTime" },
                values: new object[] { "08:30 AM", "Friday, 07:00 AM-08:30 AM", "07:00 AM" });

            migrationBuilder.UpdateData(
                table: "Sections",
                keyColumn: "ID",
                keyValue: 34,
                columns: new[] { "FullSchedule", "StartTime" },
                values: new object[] { "Friday, 08:30 AM-10:00 AM", "08:30 AM" });

            migrationBuilder.UpdateData(
                table: "Sections",
                keyColumn: "ID",
                keyValue: 36,
                columns: new[] { "EndTime", "FullSchedule" },
                values: new object[] { "01:00 PM", "Friday, 11:30 AM-01:00 PM" });

            migrationBuilder.UpdateData(
                table: "Sections",
                keyColumn: "ID",
                keyValue: 37,
                columns: new[] { "EndTime", "FullSchedule", "StartTime" },
                values: new object[] { "02:30 PM", "Friday, 01:00 PM-02:30 PM", "01:00 PM" });

            migrationBuilder.UpdateData(
                table: "Sections",
                keyColumn: "ID",
                keyValue: 38,
                columns: new[] { "EndTime", "FullSchedule", "StartTime" },
                values: new object[] { "04:00 PM", "Friday, 02:30 PM-04:00 PM", "02:30 PM" });

            migrationBuilder.UpdateData(
                table: "Sections",
                keyColumn: "ID",
                keyValue: 39,
                columns: new[] { "EndTime", "FullSchedule", "StartTime" },
                values: new object[] { "05:30 PM", "Friday, 04:00 PM-05:30 PM", "04:00 PM" });

            migrationBuilder.UpdateData(
                table: "Sections",
                keyColumn: "ID",
                keyValue: 40,
                columns: new[] { "EndTime", "FullSchedule", "StartTime" },
                values: new object[] { "07:00 PM", "Friday, 05:30 PM-07:00 PM", "05:30 PM" });

            migrationBuilder.UpdateData(
                table: "Sections",
                keyColumn: "ID",
                keyValue: 41,
                columns: new[] { "EndTime", "FullSchedule", "StartTime" },
                values: new object[] { "08:30 AM", "Saturday, 07:00 AM-08:30 AM", "07:00 AM" });

            migrationBuilder.UpdateData(
                table: "Sections",
                keyColumn: "ID",
                keyValue: 42,
                columns: new[] { "FullSchedule", "StartTime" },
                values: new object[] { "Saturday, 08:30 AM-10:00 AM", "08:30 AM" });

            migrationBuilder.UpdateData(
                table: "Sections",
                keyColumn: "ID",
                keyValue: 44,
                columns: new[] { "EndTime", "FullSchedule" },
                values: new object[] { "01:00 PM", "Saturday, 11:30 AM-01:00 PM" });

            migrationBuilder.UpdateData(
                table: "Sections",
                keyColumn: "ID",
                keyValue: 45,
                columns: new[] { "EndTime", "FullSchedule", "StartTime" },
                values: new object[] { "02:30 PM", "Saturday, 01:00 PM-02:30 PM", "01:00 PM" });

            migrationBuilder.UpdateData(
                table: "Sections",
                keyColumn: "ID",
                keyValue: 46,
                columns: new[] { "EndTime", "FullSchedule", "StartTime" },
                values: new object[] { "04:00 PM", "Saturday, 02:30 PM-04:00 PM", "02:30 PM" });

            migrationBuilder.UpdateData(
                table: "Sections",
                keyColumn: "ID",
                keyValue: 47,
                columns: new[] { "EndTime", "FullSchedule", "StartTime" },
                values: new object[] { "05:30 PM", "Saturday, 04:00 PM-05:30 PM", "04:00 PM" });

            migrationBuilder.UpdateData(
                table: "Sections",
                keyColumn: "ID",
                keyValue: 48,
                columns: new[] { "EndTime", "FullSchedule", "StartTime" },
                values: new object[] { "07:00 PM", "Saturday, 05:30 PM-07:00 PM", "05:30 PM" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "7e141c1e-cf90-45bb-89b8-d75c7ae92a81");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "9786882b-4b1a-4d8e-bc38-e12c6096416d");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "03ee7b87-22be-480b-b789-5ade53e3a0d3", "2c71f256-e52e-4ce5-92b9-c587ede3b5f2", "Administrator", "ADMINISTRATOR" },
                    { "89e1bbc4-24fc-4eef-b8cc-6020dc9b4286", "f6e4f24d-924b-4ad9-8f65-120ccc7933e0", "Student", "STUDENT" }
                });

            migrationBuilder.UpdateData(
                table: "Sections",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "EndTime", "FullSchedule", "StartTime" },
                values: new object[] { "8:30 AM", "Monday, 7:00 AM-8:30 AM", "7:00 AM" });

            migrationBuilder.UpdateData(
                table: "Sections",
                keyColumn: "ID",
                keyValue: 2,
                columns: new[] { "FullSchedule", "StartTime" },
                values: new object[] { "Monday, 8:30 AM-10:00 AM", "8:30 AM" });

            migrationBuilder.UpdateData(
                table: "Sections",
                keyColumn: "ID",
                keyValue: 4,
                columns: new[] { "EndTime", "FullSchedule" },
                values: new object[] { "1:00 PM", "Monday, 11:30 AM-1:00 PM" });

            migrationBuilder.UpdateData(
                table: "Sections",
                keyColumn: "ID",
                keyValue: 5,
                columns: new[] { "EndTime", "FullSchedule", "StartTime" },
                values: new object[] { "2:30 PM", "Monday, 1:00 PM-2:30 PM", "1:00 PM" });

            migrationBuilder.UpdateData(
                table: "Sections",
                keyColumn: "ID",
                keyValue: 6,
                columns: new[] { "EndTime", "FullSchedule", "StartTime" },
                values: new object[] { "4:00 PM", "Monday, 2:30 PM-4:00 PM", "2:30 PM" });

            migrationBuilder.UpdateData(
                table: "Sections",
                keyColumn: "ID",
                keyValue: 7,
                columns: new[] { "EndTime", "FullSchedule", "StartTime" },
                values: new object[] { "5:30 PM", "Monday, 4:00 PM-5:30 PM", "4:00 PM" });

            migrationBuilder.UpdateData(
                table: "Sections",
                keyColumn: "ID",
                keyValue: 8,
                columns: new[] { "EndTime", "FullSchedule", "StartTime" },
                values: new object[] { "7:00 PM", "Monday, 5:30 PM-7:00 PM", "5:30 PM" });

            migrationBuilder.UpdateData(
                table: "Sections",
                keyColumn: "ID",
                keyValue: 9,
                columns: new[] { "EndTime", "FullSchedule", "StartTime" },
                values: new object[] { "8:30 AM", "Tuesday, 7:00 AM-8:30 AM", "7:00 AM" });

            migrationBuilder.UpdateData(
                table: "Sections",
                keyColumn: "ID",
                keyValue: 10,
                columns: new[] { "FullSchedule", "StartTime" },
                values: new object[] { "Tuesday, 8:30 AM-10:00 AM", "8:30 AM" });

            migrationBuilder.UpdateData(
                table: "Sections",
                keyColumn: "ID",
                keyValue: 12,
                columns: new[] { "EndTime", "FullSchedule" },
                values: new object[] { "1:00 PM", "Tuesday, 11:30 AM-1:00 PM" });

            migrationBuilder.UpdateData(
                table: "Sections",
                keyColumn: "ID",
                keyValue: 13,
                columns: new[] { "EndTime", "FullSchedule", "StartTime" },
                values: new object[] { "2:30 PM", "Tuesday, 1:00 PM-2:30 PM", "1:00 PM" });

            migrationBuilder.UpdateData(
                table: "Sections",
                keyColumn: "ID",
                keyValue: 14,
                columns: new[] { "EndTime", "FullSchedule", "StartTime" },
                values: new object[] { "4:00 PM", "Tuesday, 2:30 PM-4:00 PM", "2:30 PM" });

            migrationBuilder.UpdateData(
                table: "Sections",
                keyColumn: "ID",
                keyValue: 15,
                columns: new[] { "EndTime", "FullSchedule", "StartTime" },
                values: new object[] { "5:30 PM", "Tuesday, 4:00 PM-5:30 PM", "4:00 PM" });

            migrationBuilder.UpdateData(
                table: "Sections",
                keyColumn: "ID",
                keyValue: 16,
                columns: new[] { "EndTime", "FullSchedule", "StartTime" },
                values: new object[] { "7:00 PM", "Tuesday, 5:30 PM-7:00 PM", "5:30 PM" });

            migrationBuilder.UpdateData(
                table: "Sections",
                keyColumn: "ID",
                keyValue: 17,
                columns: new[] { "EndTime", "FullSchedule", "StartTime" },
                values: new object[] { "8:30 AM", "Wednesday, 7:00 AM-8:30 AM", "7:00 AM" });

            migrationBuilder.UpdateData(
                table: "Sections",
                keyColumn: "ID",
                keyValue: 18,
                columns: new[] { "FullSchedule", "StartTime" },
                values: new object[] { "Wednesday, 8:30 AM-10:00 AM", "8:30 AM" });

            migrationBuilder.UpdateData(
                table: "Sections",
                keyColumn: "ID",
                keyValue: 20,
                columns: new[] { "EndTime", "FullSchedule" },
                values: new object[] { "1:00 PM", "Wednesday, 11:30 AM-1:00 PM" });

            migrationBuilder.UpdateData(
                table: "Sections",
                keyColumn: "ID",
                keyValue: 21,
                columns: new[] { "EndTime", "FullSchedule", "StartTime" },
                values: new object[] { "2:30 PM", "Wednesday, 1:00 PM-2:30 PM", "1:00 PM" });

            migrationBuilder.UpdateData(
                table: "Sections",
                keyColumn: "ID",
                keyValue: 22,
                columns: new[] { "EndTime", "FullSchedule", "StartTime" },
                values: new object[] { "4:00 PM", "Wednesday, 2:30 PM-4:00 PM", "2:30 PM" });

            migrationBuilder.UpdateData(
                table: "Sections",
                keyColumn: "ID",
                keyValue: 23,
                columns: new[] { "EndTime", "FullSchedule", "StartTime" },
                values: new object[] { "5:30 PM", "Wednesday, 4:00 PM-5:30 PM", "4:00 PM" });

            migrationBuilder.UpdateData(
                table: "Sections",
                keyColumn: "ID",
                keyValue: 24,
                columns: new[] { "EndTime", "FullSchedule", "StartTime" },
                values: new object[] { "7:00 PM", "Wednesday, 5:30 PM-7:00 PM", "5:30 PM" });

            migrationBuilder.UpdateData(
                table: "Sections",
                keyColumn: "ID",
                keyValue: 25,
                columns: new[] { "EndTime", "FullSchedule", "StartTime" },
                values: new object[] { "8:30 AM", "Thursday, 7:00 AM-8:30 AM", "7:00 AM" });

            migrationBuilder.UpdateData(
                table: "Sections",
                keyColumn: "ID",
                keyValue: 26,
                columns: new[] { "FullSchedule", "StartTime" },
                values: new object[] { "Thursday, 8:30 AM-10:00 AM", "8:30 AM" });

            migrationBuilder.UpdateData(
                table: "Sections",
                keyColumn: "ID",
                keyValue: 28,
                columns: new[] { "EndTime", "FullSchedule" },
                values: new object[] { "1:00 PM", "Thursday, 11:30 AM-1:00 PM" });

            migrationBuilder.UpdateData(
                table: "Sections",
                keyColumn: "ID",
                keyValue: 29,
                columns: new[] { "EndTime", "FullSchedule", "StartTime" },
                values: new object[] { "2:30 PM", "Thursday, 1:00 PM-2:30 PM", "1:00 PM" });

            migrationBuilder.UpdateData(
                table: "Sections",
                keyColumn: "ID",
                keyValue: 30,
                columns: new[] { "EndTime", "FullSchedule", "StartTime" },
                values: new object[] { "4:00 PM", "Thursday, 2:30 PM-4:00 PM", "2:30 PM" });

            migrationBuilder.UpdateData(
                table: "Sections",
                keyColumn: "ID",
                keyValue: 31,
                columns: new[] { "EndTime", "FullSchedule", "StartTime" },
                values: new object[] { "5:30 PM", "Thursday, 4:00 PM-5:30 PM", "4:00 PM" });

            migrationBuilder.UpdateData(
                table: "Sections",
                keyColumn: "ID",
                keyValue: 32,
                columns: new[] { "EndTime", "FullSchedule", "StartTime" },
                values: new object[] { "7:00 PM", "Thursday, 5:30 PM-7:00 PM", "5:30 PM" });

            migrationBuilder.UpdateData(
                table: "Sections",
                keyColumn: "ID",
                keyValue: 33,
                columns: new[] { "EndTime", "FullSchedule", "StartTime" },
                values: new object[] { "8:30 AM", "Friday, 7:00 AM-8:30 AM", "7:00 AM" });

            migrationBuilder.UpdateData(
                table: "Sections",
                keyColumn: "ID",
                keyValue: 34,
                columns: new[] { "FullSchedule", "StartTime" },
                values: new object[] { "Friday, 8:30 AM-10:00 AM", "8:30 AM" });

            migrationBuilder.UpdateData(
                table: "Sections",
                keyColumn: "ID",
                keyValue: 36,
                columns: new[] { "EndTime", "FullSchedule" },
                values: new object[] { "1:00 PM", "Friday, 11:30 AM-1:00 PM" });

            migrationBuilder.UpdateData(
                table: "Sections",
                keyColumn: "ID",
                keyValue: 37,
                columns: new[] { "EndTime", "FullSchedule", "StartTime" },
                values: new object[] { "2:30 PM", "Friday, 1:00 PM-2:30 PM", "1:00 PM" });

            migrationBuilder.UpdateData(
                table: "Sections",
                keyColumn: "ID",
                keyValue: 38,
                columns: new[] { "EndTime", "FullSchedule", "StartTime" },
                values: new object[] { "4:00 PM", "Friday, 2:30 PM-4:00 PM", "2:30 PM" });

            migrationBuilder.UpdateData(
                table: "Sections",
                keyColumn: "ID",
                keyValue: 39,
                columns: new[] { "EndTime", "FullSchedule", "StartTime" },
                values: new object[] { "5:30 PM", "Friday, 4:00 PM-5:30 PM", "4:00 PM" });

            migrationBuilder.UpdateData(
                table: "Sections",
                keyColumn: "ID",
                keyValue: 40,
                columns: new[] { "EndTime", "FullSchedule", "StartTime" },
                values: new object[] { "7:00 PM", "Friday, 5:30 PM-7:00 PM", "5:30 PM" });

            migrationBuilder.UpdateData(
                table: "Sections",
                keyColumn: "ID",
                keyValue: 41,
                columns: new[] { "EndTime", "FullSchedule", "StartTime" },
                values: new object[] { "8:30 AM", "Saturday, 7:00 AM-8:30 AM", "7:00 AM" });

            migrationBuilder.UpdateData(
                table: "Sections",
                keyColumn: "ID",
                keyValue: 42,
                columns: new[] { "FullSchedule", "StartTime" },
                values: new object[] { "Saturday, 8:30 AM-10:00 AM", "8:30 AM" });

            migrationBuilder.UpdateData(
                table: "Sections",
                keyColumn: "ID",
                keyValue: 44,
                columns: new[] { "EndTime", "FullSchedule" },
                values: new object[] { "1:00 PM", "Saturday, 11:30 AM-1:00 PM" });

            migrationBuilder.UpdateData(
                table: "Sections",
                keyColumn: "ID",
                keyValue: 45,
                columns: new[] { "EndTime", "FullSchedule", "StartTime" },
                values: new object[] { "2:30 PM", "Saturday, 1:00 PM-2:30 PM", "1:00 PM" });

            migrationBuilder.UpdateData(
                table: "Sections",
                keyColumn: "ID",
                keyValue: 46,
                columns: new[] { "EndTime", "FullSchedule", "StartTime" },
                values: new object[] { "4:00 PM", "Saturday, 2:30 PM-4:00 PM", "2:30 PM" });

            migrationBuilder.UpdateData(
                table: "Sections",
                keyColumn: "ID",
                keyValue: 47,
                columns: new[] { "EndTime", "FullSchedule", "StartTime" },
                values: new object[] { "5:30 PM", "Saturday, 4:00 PM-5:30 PM", "4:00 PM" });

            migrationBuilder.UpdateData(
                table: "Sections",
                keyColumn: "ID",
                keyValue: 48,
                columns: new[] { "EndTime", "FullSchedule", "StartTime" },
                values: new object[] { "7:00 PM", "Saturday, 5:30 PM-7:00 PM", "5:30 PM" });
        }
    }
}
