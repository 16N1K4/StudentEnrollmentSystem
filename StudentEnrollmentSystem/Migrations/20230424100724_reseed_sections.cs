using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace StudentEnrollmentSystem.Migrations
{
    public partial class reseed_sections : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "747c9aba-15d5-4a37-97cb-46e4a2e4c3cf");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "c1742731-5847-4179-a6e9-481c8e72a7da");

            migrationBuilder.DeleteData(
                table: "Sections",
                keyColumn: "ID",
                keyValue: 49);

            migrationBuilder.DeleteData(
                table: "Sections",
                keyColumn: "ID",
                keyValue: 50);

            migrationBuilder.DeleteData(
                table: "Sections",
                keyColumn: "ID",
                keyValue: 51);

            migrationBuilder.DeleteData(
                table: "Sections",
                keyColumn: "ID",
                keyValue: 52);

            migrationBuilder.DeleteData(
                table: "Sections",
                keyColumn: "ID",
                keyValue: 53);

            migrationBuilder.DeleteData(
                table: "Sections",
                keyColumn: "ID",
                keyValue: 54);

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
                columns: new[] { "EndTime", "FullSchedule", "SectionCode", "StartTime" },
                values: new object[] { "8:30 AM", "Monday, 7:00 AM-8:30 AM", "MAD", "7:00 AM" });

            migrationBuilder.UpdateData(
                table: "Sections",
                keyColumn: "ID",
                keyValue: 2,
                columns: new[] { "EndTime", "FullSchedule", "SectionCode", "StartTime" },
                values: new object[] { "10:00 AM", "Monday, 8:30 AM-10:00 AM", "MDG", "8:30 AM" });

            migrationBuilder.UpdateData(
                table: "Sections",
                keyColumn: "ID",
                keyValue: 3,
                columns: new[] { "EndTime", "FullSchedule", "SectionCode", "StartTime" },
                values: new object[] { "11:30 AM", "Monday, 10:00 AM-11:30 AM", "MGJ", "10:00 AM" });

            migrationBuilder.UpdateData(
                table: "Sections",
                keyColumn: "ID",
                keyValue: 4,
                columns: new[] { "EndTime", "FullSchedule", "SectionCode", "StartTime" },
                values: new object[] { "1:00 PM", "Monday, 11:30 AM-1:00 PM", "MJM", "11:30 AM" });

            migrationBuilder.UpdateData(
                table: "Sections",
                keyColumn: "ID",
                keyValue: 5,
                columns: new[] { "EndTime", "FullSchedule", "SectionCode", "StartTime" },
                values: new object[] { "2:30 PM", "Monday, 1:00 PM-2:30 PM", "MMP", "1:00 PM" });

            migrationBuilder.UpdateData(
                table: "Sections",
                keyColumn: "ID",
                keyValue: 6,
                columns: new[] { "EndTime", "FullSchedule", "SectionCode", "StartTime" },
                values: new object[] { "4:00 PM", "Monday, 2:30 PM-4:00 PM", "MPS", "2:30 PM" });

            migrationBuilder.UpdateData(
                table: "Sections",
                keyColumn: "ID",
                keyValue: 7,
                columns: new[] { "EndTime", "FullSchedule", "SectionCode", "StartTime" },
                values: new object[] { "5:30 PM", "Monday, 4:00 PM-5:30 PM", "MSV", "4:00 PM" });

            migrationBuilder.UpdateData(
                table: "Sections",
                keyColumn: "ID",
                keyValue: 8,
                columns: new[] { "EndTime", "FullSchedule", "SectionCode", "StartTime" },
                values: new object[] { "7:00 PM", "Monday, 5:30 PM-7:00 PM", "MVY", "5:30 PM" });

            migrationBuilder.UpdateData(
                table: "Sections",
                keyColumn: "ID",
                keyValue: 9,
                columns: new[] { "Day", "EndTime", "FullSchedule", "SectionCode", "StartTime" },
                values: new object[] { "Tuesday", "8:30 AM", "Tuesday, 7:00 AM-8:30 AM", "TAD", "7:00 AM" });

            migrationBuilder.UpdateData(
                table: "Sections",
                keyColumn: "ID",
                keyValue: 10,
                columns: new[] { "EndTime", "FullSchedule", "SectionCode", "StartTime" },
                values: new object[] { "10:00 AM", "Tuesday, 8:30 AM-10:00 AM", "TDG", "8:30 AM" });

            migrationBuilder.UpdateData(
                table: "Sections",
                keyColumn: "ID",
                keyValue: 11,
                columns: new[] { "EndTime", "FullSchedule", "SectionCode", "StartTime" },
                values: new object[] { "11:30 AM", "Tuesday, 10:00 AM-11:30 AM", "TGJ", "10:00 AM" });

            migrationBuilder.UpdateData(
                table: "Sections",
                keyColumn: "ID",
                keyValue: 12,
                columns: new[] { "EndTime", "FullSchedule", "SectionCode", "StartTime" },
                values: new object[] { "1:00 PM", "Tuesday, 11:30 AM-1:00 PM", "TJM", "11:30 AM" });

            migrationBuilder.UpdateData(
                table: "Sections",
                keyColumn: "ID",
                keyValue: 13,
                columns: new[] { "EndTime", "FullSchedule", "SectionCode", "StartTime" },
                values: new object[] { "2:30 PM", "Tuesday, 1:00 PM-2:30 PM", "TMP", "1:00 PM" });

            migrationBuilder.UpdateData(
                table: "Sections",
                keyColumn: "ID",
                keyValue: 14,
                columns: new[] { "EndTime", "FullSchedule", "SectionCode", "StartTime" },
                values: new object[] { "4:00 PM", "Tuesday, 2:30 PM-4:00 PM", "TPS", "2:30 PM" });

            migrationBuilder.UpdateData(
                table: "Sections",
                keyColumn: "ID",
                keyValue: 15,
                columns: new[] { "EndTime", "FullSchedule", "SectionCode", "StartTime" },
                values: new object[] { "5:30 PM", "Tuesday, 4:00 PM-5:30 PM", "TSV", "4:00 PM" });

            migrationBuilder.UpdateData(
                table: "Sections",
                keyColumn: "ID",
                keyValue: 16,
                columns: new[] { "EndTime", "FullSchedule", "SectionCode", "StartTime" },
                values: new object[] { "7:00 PM", "Tuesday, 5:30 PM-7:00 PM", "TVY", "5:30 PM" });

            migrationBuilder.UpdateData(
                table: "Sections",
                keyColumn: "ID",
                keyValue: 17,
                columns: new[] { "Day", "EndTime", "FullSchedule", "SectionCode", "StartTime" },
                values: new object[] { "Wednesday", "8:30 AM", "Wednesday, 7:00 AM-8:30 AM", "WAD", "7:00 AM" });

            migrationBuilder.UpdateData(
                table: "Sections",
                keyColumn: "ID",
                keyValue: 18,
                columns: new[] { "Day", "EndTime", "FullSchedule", "SectionCode", "StartTime" },
                values: new object[] { "Wednesday", "10:00 AM", "Wednesday, 8:30 AM-10:00 AM", "WDG", "8:30 AM" });

            migrationBuilder.UpdateData(
                table: "Sections",
                keyColumn: "ID",
                keyValue: 19,
                columns: new[] { "EndTime", "FullSchedule", "SectionCode", "StartTime" },
                values: new object[] { "11:30 AM", "Wednesday, 10:00 AM-11:30 AM", "WGJ", "10:00 AM" });

            migrationBuilder.UpdateData(
                table: "Sections",
                keyColumn: "ID",
                keyValue: 20,
                columns: new[] { "EndTime", "FullSchedule", "SectionCode", "StartTime" },
                values: new object[] { "1:00 PM", "Wednesday, 11:30 AM-1:00 PM", "WJM", "11:30 AM" });

            migrationBuilder.UpdateData(
                table: "Sections",
                keyColumn: "ID",
                keyValue: 21,
                columns: new[] { "EndTime", "FullSchedule", "SectionCode", "StartTime" },
                values: new object[] { "2:30 PM", "Wednesday, 1:00 PM-2:30 PM", "WMP", "1:00 PM" });

            migrationBuilder.UpdateData(
                table: "Sections",
                keyColumn: "ID",
                keyValue: 22,
                columns: new[] { "EndTime", "FullSchedule", "SectionCode", "StartTime" },
                values: new object[] { "4:00 PM", "Wednesday, 2:30 PM-4:00 PM", "WPS", "2:30 PM" });

            migrationBuilder.UpdateData(
                table: "Sections",
                keyColumn: "ID",
                keyValue: 23,
                columns: new[] { "EndTime", "FullSchedule", "SectionCode", "StartTime" },
                values: new object[] { "5:30 PM", "Wednesday, 4:00 PM-5:30 PM", "WSV", "4:00 PM" });

            migrationBuilder.UpdateData(
                table: "Sections",
                keyColumn: "ID",
                keyValue: 24,
                columns: new[] { "EndTime", "FullSchedule", "SectionCode", "StartTime" },
                values: new object[] { "7:00 PM", "Wednesday, 5:30 PM-7:00 PM", "WVY", "5:30 PM" });

            migrationBuilder.UpdateData(
                table: "Sections",
                keyColumn: "ID",
                keyValue: 25,
                columns: new[] { "Day", "EndTime", "FullSchedule", "SectionCode", "StartTime" },
                values: new object[] { "Thursday", "8:30 AM", "Thursday, 7:00 AM-8:30 AM", "HAD", "7:00 AM" });

            migrationBuilder.UpdateData(
                table: "Sections",
                keyColumn: "ID",
                keyValue: 26,
                columns: new[] { "Day", "EndTime", "FullSchedule", "SectionCode", "StartTime" },
                values: new object[] { "Thursday", "10:00 AM", "Thursday, 8:30 AM-10:00 AM", "HDG", "8:30 AM" });

            migrationBuilder.UpdateData(
                table: "Sections",
                keyColumn: "ID",
                keyValue: 27,
                columns: new[] { "Day", "EndTime", "FullSchedule", "SectionCode", "StartTime" },
                values: new object[] { "Thursday", "11:30 AM", "Thursday, 10:00 AM-11:30 AM", "HGJ", "10:00 AM" });

            migrationBuilder.UpdateData(
                table: "Sections",
                keyColumn: "ID",
                keyValue: 28,
                columns: new[] { "EndTime", "FullSchedule", "SectionCode", "StartTime" },
                values: new object[] { "1:00 PM", "Thursday, 11:30 AM-1:00 PM", "HJM", "11:30 AM" });

            migrationBuilder.UpdateData(
                table: "Sections",
                keyColumn: "ID",
                keyValue: 29,
                columns: new[] { "EndTime", "FullSchedule", "SectionCode", "StartTime" },
                values: new object[] { "2:30 PM", "Thursday, 1:00 PM-2:30 PM", "HMP", "1:00 PM" });

            migrationBuilder.UpdateData(
                table: "Sections",
                keyColumn: "ID",
                keyValue: 30,
                columns: new[] { "EndTime", "FullSchedule", "SectionCode", "StartTime" },
                values: new object[] { "4:00 PM", "Thursday, 2:30 PM-4:00 PM", "HPS", "2:30 PM" });

            migrationBuilder.UpdateData(
                table: "Sections",
                keyColumn: "ID",
                keyValue: 31,
                columns: new[] { "EndTime", "FullSchedule", "SectionCode", "StartTime" },
                values: new object[] { "5:30 PM", "Thursday, 4:00 PM-5:30 PM", "HSV", "4:00 PM" });

            migrationBuilder.UpdateData(
                table: "Sections",
                keyColumn: "ID",
                keyValue: 32,
                columns: new[] { "EndTime", "FullSchedule", "SectionCode", "StartTime" },
                values: new object[] { "7:00 PM", "Thursday, 5:30 PM-7:00 PM", "HVY", "5:30 PM" });

            migrationBuilder.UpdateData(
                table: "Sections",
                keyColumn: "ID",
                keyValue: 33,
                columns: new[] { "Day", "EndTime", "FullSchedule", "SectionCode", "StartTime" },
                values: new object[] { "Friday", "8:30 AM", "Friday, 7:00 AM-8:30 AM", "FAD", "7:00 AM" });

            migrationBuilder.UpdateData(
                table: "Sections",
                keyColumn: "ID",
                keyValue: 34,
                columns: new[] { "Day", "EndTime", "FullSchedule", "SectionCode", "StartTime" },
                values: new object[] { "Friday", "10:00 AM", "Friday, 8:30 AM-10:00 AM", "FDG", "8:30 AM" });

            migrationBuilder.UpdateData(
                table: "Sections",
                keyColumn: "ID",
                keyValue: 35,
                columns: new[] { "Day", "EndTime", "FullSchedule", "SectionCode", "StartTime" },
                values: new object[] { "Friday", "11:30 AM", "Friday, 10:00 AM-11:30 AM", "FGJ", "10:00 AM" });

            migrationBuilder.UpdateData(
                table: "Sections",
                keyColumn: "ID",
                keyValue: 36,
                columns: new[] { "Day", "EndTime", "FullSchedule", "SectionCode", "StartTime" },
                values: new object[] { "Friday", "1:00 PM", "Friday, 11:30 AM-1:00 PM", "FJM", "11:30 AM" });

            migrationBuilder.UpdateData(
                table: "Sections",
                keyColumn: "ID",
                keyValue: 37,
                columns: new[] { "EndTime", "FullSchedule", "SectionCode", "StartTime" },
                values: new object[] { "2:30 PM", "Friday, 1:00 PM-2:30 PM", "FMP", "1:00 PM" });

            migrationBuilder.UpdateData(
                table: "Sections",
                keyColumn: "ID",
                keyValue: 38,
                columns: new[] { "EndTime", "FullSchedule", "SectionCode", "StartTime" },
                values: new object[] { "4:00 PM", "Friday, 2:30 PM-4:00 PM", "FPS", "2:30 PM" });

            migrationBuilder.UpdateData(
                table: "Sections",
                keyColumn: "ID",
                keyValue: 39,
                columns: new[] { "EndTime", "FullSchedule", "SectionCode", "StartTime" },
                values: new object[] { "5:30 PM", "Friday, 4:00 PM-5:30 PM", "FSV", "4:00 PM" });

            migrationBuilder.UpdateData(
                table: "Sections",
                keyColumn: "ID",
                keyValue: 40,
                columns: new[] { "EndTime", "FullSchedule", "SectionCode", "StartTime" },
                values: new object[] { "7:00 PM", "Friday, 5:30 PM-7:00 PM", "FVY", "5:30 PM" });

            migrationBuilder.UpdateData(
                table: "Sections",
                keyColumn: "ID",
                keyValue: 41,
                columns: new[] { "Day", "EndTime", "FullSchedule", "SectionCode", "StartTime" },
                values: new object[] { "Saturday", "8:30 AM", "Saturday, 7:00 AM-8:30 AM", "SAD", "7:00 AM" });

            migrationBuilder.UpdateData(
                table: "Sections",
                keyColumn: "ID",
                keyValue: 42,
                columns: new[] { "Day", "EndTime", "FullSchedule", "SectionCode", "StartTime" },
                values: new object[] { "Saturday", "10:00 AM", "Saturday, 8:30 AM-10:00 AM", "SDG", "8:30 AM" });

            migrationBuilder.UpdateData(
                table: "Sections",
                keyColumn: "ID",
                keyValue: 43,
                columns: new[] { "Day", "EndTime", "FullSchedule", "SectionCode", "StartTime" },
                values: new object[] { "Saturday", "11:30 AM", "Saturday, 10:00 AM-11:30 AM", "SGJ", "10:00 AM" });

            migrationBuilder.UpdateData(
                table: "Sections",
                keyColumn: "ID",
                keyValue: 44,
                columns: new[] { "Day", "EndTime", "FullSchedule", "SectionCode", "StartTime" },
                values: new object[] { "Saturday", "1:00 PM", "Saturday, 11:30 AM-1:00 PM", "SJM", "11:30 AM" });

            migrationBuilder.UpdateData(
                table: "Sections",
                keyColumn: "ID",
                keyValue: 45,
                columns: new[] { "Day", "EndTime", "FullSchedule", "SectionCode", "StartTime" },
                values: new object[] { "Saturday", "2:30 PM", "Saturday, 1:00 PM-2:30 PM", "SMP", "1:00 PM" });

            migrationBuilder.UpdateData(
                table: "Sections",
                keyColumn: "ID",
                keyValue: 46,
                columns: new[] { "EndTime", "FullSchedule", "SectionCode", "StartTime" },
                values: new object[] { "4:00 PM", "Saturday, 2:30 PM-4:00 PM", "SPS", "2:30 PM" });

            migrationBuilder.UpdateData(
                table: "Sections",
                keyColumn: "ID",
                keyValue: 47,
                columns: new[] { "EndTime", "FullSchedule", "SectionCode", "StartTime" },
                values: new object[] { "5:30 PM", "Saturday, 4:00 PM-5:30 PM", "SSV", "4:00 PM" });

            migrationBuilder.UpdateData(
                table: "Sections",
                keyColumn: "ID",
                keyValue: 48,
                columns: new[] { "EndTime", "FullSchedule", "SectionCode", "StartTime" },
                values: new object[] { "7:00 PM", "Saturday, 5:30 PM-7:00 PM", "SVY", "5:30 PM" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
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
                    { "747c9aba-15d5-4a37-97cb-46e4a2e4c3cf", "8c4145ff-cb96-4aee-bb1c-b51b9a3edf66", "Administrator", "ADMINISTRATOR" },
                    { "c1742731-5847-4179-a6e9-481c8e72a7da", "e5a82be4-136a-42da-9cad-c77731b93b06", "Student", "STUDENT" }
                });

            migrationBuilder.UpdateData(
                table: "Sections",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "EndTime", "FullSchedule", "SectionCode", "StartTime" },
                values: new object[] { "8:30AM", "Monday, 7:00AM-8:30AM", "MAB", "7:00AM" });

            migrationBuilder.UpdateData(
                table: "Sections",
                keyColumn: "ID",
                keyValue: 2,
                columns: new[] { "EndTime", "FullSchedule", "SectionCode", "StartTime" },
                values: new object[] { "10:00AM", "Monday, 8:30AM-10:00AM", "MBC", "8:30AM" });

            migrationBuilder.UpdateData(
                table: "Sections",
                keyColumn: "ID",
                keyValue: 3,
                columns: new[] { "EndTime", "FullSchedule", "SectionCode", "StartTime" },
                values: new object[] { "11:30AM", "Monday, 10:00AM-11:30AM", "MCD", "10:00AM" });

            migrationBuilder.UpdateData(
                table: "Sections",
                keyColumn: "ID",
                keyValue: 4,
                columns: new[] { "EndTime", "FullSchedule", "SectionCode", "StartTime" },
                values: new object[] { "1:00PM", "Monday, 11:30AM-1:00PM", "MDE", "11:30AM" });

            migrationBuilder.UpdateData(
                table: "Sections",
                keyColumn: "ID",
                keyValue: 5,
                columns: new[] { "EndTime", "FullSchedule", "SectionCode", "StartTime" },
                values: new object[] { "2:30PM", "Monday, 1:00PM-2:30PM", "MEF", "1:00PM" });

            migrationBuilder.UpdateData(
                table: "Sections",
                keyColumn: "ID",
                keyValue: 6,
                columns: new[] { "EndTime", "FullSchedule", "SectionCode", "StartTime" },
                values: new object[] { "4:00PM", "Monday, 2:30PM-4:00PM", "MFG", "2:30PM" });

            migrationBuilder.UpdateData(
                table: "Sections",
                keyColumn: "ID",
                keyValue: 7,
                columns: new[] { "EndTime", "FullSchedule", "SectionCode", "StartTime" },
                values: new object[] { "5:30PM", "Monday, 4:00PM-5:30PM", "MGH", "4:00PM" });

            migrationBuilder.UpdateData(
                table: "Sections",
                keyColumn: "ID",
                keyValue: 8,
                columns: new[] { "EndTime", "FullSchedule", "SectionCode", "StartTime" },
                values: new object[] { "7:00PM", "Monday, 5:30PM-7:00PM", "MHI", "5:30PM" });

            migrationBuilder.UpdateData(
                table: "Sections",
                keyColumn: "ID",
                keyValue: 9,
                columns: new[] { "Day", "EndTime", "FullSchedule", "SectionCode", "StartTime" },
                values: new object[] { "Monday", "8:30PM", "Monday, 7:00PM-8:30PM", "MIJ", "7:00PM" });

            migrationBuilder.UpdateData(
                table: "Sections",
                keyColumn: "ID",
                keyValue: 10,
                columns: new[] { "EndTime", "FullSchedule", "SectionCode", "StartTime" },
                values: new object[] { "8:30AM", "Tuesday, 7:00AM-8:30AM", "TAB", "7:00AM" });

            migrationBuilder.UpdateData(
                table: "Sections",
                keyColumn: "ID",
                keyValue: 11,
                columns: new[] { "EndTime", "FullSchedule", "SectionCode", "StartTime" },
                values: new object[] { "10:00AM", "Tuesday, 8:30AM-10:00AM", "TBC", "8:30AM" });

            migrationBuilder.UpdateData(
                table: "Sections",
                keyColumn: "ID",
                keyValue: 12,
                columns: new[] { "EndTime", "FullSchedule", "SectionCode", "StartTime" },
                values: new object[] { "11:30AM", "Tuesday, 10:00AM-11:30AM", "TCD", "10:00AM" });

            migrationBuilder.UpdateData(
                table: "Sections",
                keyColumn: "ID",
                keyValue: 13,
                columns: new[] { "EndTime", "FullSchedule", "SectionCode", "StartTime" },
                values: new object[] { "1:00PM", "Tuesday, 11:30AM-1:00PM", "TDE", "11:30AM" });

            migrationBuilder.UpdateData(
                table: "Sections",
                keyColumn: "ID",
                keyValue: 14,
                columns: new[] { "EndTime", "FullSchedule", "SectionCode", "StartTime" },
                values: new object[] { "2:30PM", "Tuesday, 1:00PM-2:30PM", "TEF", "1:00PM" });

            migrationBuilder.UpdateData(
                table: "Sections",
                keyColumn: "ID",
                keyValue: 15,
                columns: new[] { "EndTime", "FullSchedule", "SectionCode", "StartTime" },
                values: new object[] { "4:00PM", "Tuesday, 2:30PM-4:00PM", "TFG", "2:30PM" });

            migrationBuilder.UpdateData(
                table: "Sections",
                keyColumn: "ID",
                keyValue: 16,
                columns: new[] { "EndTime", "FullSchedule", "SectionCode", "StartTime" },
                values: new object[] { "5:30PM", "Tuesday, 4:00PM-5:30PM", "TGH", "4:00PM" });

            migrationBuilder.UpdateData(
                table: "Sections",
                keyColumn: "ID",
                keyValue: 17,
                columns: new[] { "Day", "EndTime", "FullSchedule", "SectionCode", "StartTime" },
                values: new object[] { "Tuesday", "7:00PM", "Tuesday, 5:30PM-7:00PM", "THI", "5:30PM" });

            migrationBuilder.UpdateData(
                table: "Sections",
                keyColumn: "ID",
                keyValue: 18,
                columns: new[] { "Day", "EndTime", "FullSchedule", "SectionCode", "StartTime" },
                values: new object[] { "Tuesday", "8:30PM", "Tuesday, 7:00PM-8:30PM", "TIJ", "7:00PM" });

            migrationBuilder.UpdateData(
                table: "Sections",
                keyColumn: "ID",
                keyValue: 19,
                columns: new[] { "EndTime", "FullSchedule", "SectionCode", "StartTime" },
                values: new object[] { "8:30AM", "Wednesday, 7:00AM-8:30AM", "WAB", "7:00AM" });

            migrationBuilder.UpdateData(
                table: "Sections",
                keyColumn: "ID",
                keyValue: 20,
                columns: new[] { "EndTime", "FullSchedule", "SectionCode", "StartTime" },
                values: new object[] { "10:00AM", "Wednesday, 8:30AM-10:00AM", "WBC", "8:30AM" });

            migrationBuilder.UpdateData(
                table: "Sections",
                keyColumn: "ID",
                keyValue: 21,
                columns: new[] { "EndTime", "FullSchedule", "SectionCode", "StartTime" },
                values: new object[] { "11:30AM", "Wednesday, 10:00AM-11:30AM", "WCD", "10:00AM" });

            migrationBuilder.UpdateData(
                table: "Sections",
                keyColumn: "ID",
                keyValue: 22,
                columns: new[] { "EndTime", "FullSchedule", "SectionCode", "StartTime" },
                values: new object[] { "1:00PM", "Wednesday, 11:30AM-1:00PM", "WDE", "11:30AM" });

            migrationBuilder.UpdateData(
                table: "Sections",
                keyColumn: "ID",
                keyValue: 23,
                columns: new[] { "EndTime", "FullSchedule", "SectionCode", "StartTime" },
                values: new object[] { "2:30PM", "Wednesday, 1:00PM-2:30PM", "WEF", "1:00PM" });

            migrationBuilder.UpdateData(
                table: "Sections",
                keyColumn: "ID",
                keyValue: 24,
                columns: new[] { "EndTime", "FullSchedule", "SectionCode", "StartTime" },
                values: new object[] { "4:00PM", "Wednesday, 2:30PM-4:00PM", "WFG", "2:30PM" });

            migrationBuilder.UpdateData(
                table: "Sections",
                keyColumn: "ID",
                keyValue: 25,
                columns: new[] { "Day", "EndTime", "FullSchedule", "SectionCode", "StartTime" },
                values: new object[] { "Wednesday", "5:30PM", "Wednesday, 4:00PM-5:30PM", "WGH", "4:00PM" });

            migrationBuilder.UpdateData(
                table: "Sections",
                keyColumn: "ID",
                keyValue: 26,
                columns: new[] { "Day", "EndTime", "FullSchedule", "SectionCode", "StartTime" },
                values: new object[] { "Wednesday", "7:00PM", "Wednesday, 5:30PM-7:00PM", "WHI", "5:30PM" });

            migrationBuilder.UpdateData(
                table: "Sections",
                keyColumn: "ID",
                keyValue: 27,
                columns: new[] { "Day", "EndTime", "FullSchedule", "SectionCode", "StartTime" },
                values: new object[] { "Wednesday", "8:30PM", "Wednesday, 7:00PM-8:30PM", "WIJ", "7:00PM" });

            migrationBuilder.UpdateData(
                table: "Sections",
                keyColumn: "ID",
                keyValue: 28,
                columns: new[] { "EndTime", "FullSchedule", "SectionCode", "StartTime" },
                values: new object[] { "8:30AM", "Thursday, 7:00AM-8:30AM", "HAB", "7:00AM" });

            migrationBuilder.UpdateData(
                table: "Sections",
                keyColumn: "ID",
                keyValue: 29,
                columns: new[] { "EndTime", "FullSchedule", "SectionCode", "StartTime" },
                values: new object[] { "10:00AM", "Thursday, 8:30AM-10:00AM", "HBC", "8:30AM" });

            migrationBuilder.UpdateData(
                table: "Sections",
                keyColumn: "ID",
                keyValue: 30,
                columns: new[] { "EndTime", "FullSchedule", "SectionCode", "StartTime" },
                values: new object[] { "11:30AM", "Thursday, 10:00AM-11:30AM", "HCD", "10:00AM" });

            migrationBuilder.UpdateData(
                table: "Sections",
                keyColumn: "ID",
                keyValue: 31,
                columns: new[] { "EndTime", "FullSchedule", "SectionCode", "StartTime" },
                values: new object[] { "1:00PM", "Thursday, 11:30AM-1:00PM", "HDE", "11:30AM" });

            migrationBuilder.UpdateData(
                table: "Sections",
                keyColumn: "ID",
                keyValue: 32,
                columns: new[] { "EndTime", "FullSchedule", "SectionCode", "StartTime" },
                values: new object[] { "2:30PM", "Thursday, 1:00PM-2:30PM", "HEF", "1:00PM" });

            migrationBuilder.UpdateData(
                table: "Sections",
                keyColumn: "ID",
                keyValue: 33,
                columns: new[] { "Day", "EndTime", "FullSchedule", "SectionCode", "StartTime" },
                values: new object[] { "Thursday", "4:00PM", "Thursday, 2:30PM-4:00PM", "HFG", "2:30PM" });

            migrationBuilder.UpdateData(
                table: "Sections",
                keyColumn: "ID",
                keyValue: 34,
                columns: new[] { "Day", "EndTime", "FullSchedule", "SectionCode", "StartTime" },
                values: new object[] { "Thursday", "5:30PM", "Thursday, 4:00PM-5:30PM", "HGH", "4:00PM" });

            migrationBuilder.UpdateData(
                table: "Sections",
                keyColumn: "ID",
                keyValue: 35,
                columns: new[] { "Day", "EndTime", "FullSchedule", "SectionCode", "StartTime" },
                values: new object[] { "Thursday", "7:00PM", "Thursday, 5:30PM-7:00PM", "HHI", "5:30PM" });

            migrationBuilder.UpdateData(
                table: "Sections",
                keyColumn: "ID",
                keyValue: 36,
                columns: new[] { "Day", "EndTime", "FullSchedule", "SectionCode", "StartTime" },
                values: new object[] { "Thursday", "8:30PM", "Thursday, 7:00PM-8:30PM", "HIJ", "7:00PM" });

            migrationBuilder.UpdateData(
                table: "Sections",
                keyColumn: "ID",
                keyValue: 37,
                columns: new[] { "EndTime", "FullSchedule", "SectionCode", "StartTime" },
                values: new object[] { "8:30AM", "Friday, 7:00AM-8:30AM", "FAB", "7:00AM" });

            migrationBuilder.UpdateData(
                table: "Sections",
                keyColumn: "ID",
                keyValue: 38,
                columns: new[] { "EndTime", "FullSchedule", "SectionCode", "StartTime" },
                values: new object[] { "10:00AM", "Friday, 8:30AM-10:00AM", "FBC", "8:30AM" });

            migrationBuilder.UpdateData(
                table: "Sections",
                keyColumn: "ID",
                keyValue: 39,
                columns: new[] { "EndTime", "FullSchedule", "SectionCode", "StartTime" },
                values: new object[] { "11:30AM", "Friday, 10:00AM-11:30AM", "FCD", "10:00AM" });

            migrationBuilder.UpdateData(
                table: "Sections",
                keyColumn: "ID",
                keyValue: 40,
                columns: new[] { "EndTime", "FullSchedule", "SectionCode", "StartTime" },
                values: new object[] { "1:00PM", "Friday, 11:30AM-1:00PM", "FDE", "11:30AM" });

            migrationBuilder.UpdateData(
                table: "Sections",
                keyColumn: "ID",
                keyValue: 41,
                columns: new[] { "Day", "EndTime", "FullSchedule", "SectionCode", "StartTime" },
                values: new object[] { "Friday", "2:30PM", "Friday, 1:00PM-2:30PM", "FEF", "1:00PM" });

            migrationBuilder.UpdateData(
                table: "Sections",
                keyColumn: "ID",
                keyValue: 42,
                columns: new[] { "Day", "EndTime", "FullSchedule", "SectionCode", "StartTime" },
                values: new object[] { "Friday", "4:00PM", "Friday, 2:30PM-4:00PM", "FFG", "2:30PM" });

            migrationBuilder.UpdateData(
                table: "Sections",
                keyColumn: "ID",
                keyValue: 43,
                columns: new[] { "Day", "EndTime", "FullSchedule", "SectionCode", "StartTime" },
                values: new object[] { "Friday", "5:30PM", "Friday, 4:00PM-5:30PM", "FGH", "4:00PM" });

            migrationBuilder.UpdateData(
                table: "Sections",
                keyColumn: "ID",
                keyValue: 44,
                columns: new[] { "Day", "EndTime", "FullSchedule", "SectionCode", "StartTime" },
                values: new object[] { "Friday", "7:00PM", "Friday, 5:30PM-7:00PM", "FHI", "5:30PM" });

            migrationBuilder.UpdateData(
                table: "Sections",
                keyColumn: "ID",
                keyValue: 45,
                columns: new[] { "Day", "EndTime", "FullSchedule", "SectionCode", "StartTime" },
                values: new object[] { "Friday", "8:30PM", "Friday, 7:00PM-8:30PM", "FIJ", "7:00PM" });

            migrationBuilder.UpdateData(
                table: "Sections",
                keyColumn: "ID",
                keyValue: 46,
                columns: new[] { "EndTime", "FullSchedule", "SectionCode", "StartTime" },
                values: new object[] { "8:30AM", "Saturday, 7:00AM-8:30AM", "SAB", "7:00AM" });

            migrationBuilder.UpdateData(
                table: "Sections",
                keyColumn: "ID",
                keyValue: 47,
                columns: new[] { "EndTime", "FullSchedule", "SectionCode", "StartTime" },
                values: new object[] { "10:00AM", "Saturday, 8:30AM-10:00AM", "SBC", "8:30AM" });

            migrationBuilder.UpdateData(
                table: "Sections",
                keyColumn: "ID",
                keyValue: 48,
                columns: new[] { "EndTime", "FullSchedule", "SectionCode", "StartTime" },
                values: new object[] { "11:30AM", "Saturday, 10:00AM-11:30AM", "SCD", "10:00AM" });

            migrationBuilder.InsertData(
                table: "Sections",
                columns: new[] { "ID", "Day", "EndTime", "FullSchedule", "SectionCode", "StartTime" },
                values: new object[,]
                {
                    { 49, "Saturday", "1:00PM", "Saturday, 11:30AM-1:00PM", "SDE", "11:30AM" },
                    { 50, "Saturday", "2:30PM", "Saturday, 1:00PM-2:30PM", "SEF", "1:00PM" },
                    { 51, "Saturday", "4:00PM", "Saturday, 2:30PM-4:00PM", "SFG", "2:30PM" },
                    { 52, "Saturday", "5:30PM", "Saturday, 4:00PM-5:30PM", "SGH", "4:00PM" },
                    { 53, "Saturday", "7:00PM", "Saturday, 5:30PM-7:00PM", "SHI", "5:30PM" },
                    { 54, "Saturday", "8:30PM", "saturday, 7:00PM-8:30PM", "SIJ", "7:00PM" }
                });
        }
    }
}
