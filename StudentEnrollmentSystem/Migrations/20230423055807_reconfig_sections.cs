using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace StudentEnrollmentSystem.Migrations
{
    public partial class reconfig_sections : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "01c4af82-e7e4-441f-a04e-b976cf24d2f5");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "e6f7f994-1a74-4e45-acce-ff2a74cc3a9a");

            migrationBuilder.AlterColumn<string>(
                name: "SectionCode",
                table: "Sections",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AddColumn<string>(
                name: "Day",
                table: "Sections",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "EndTime",
                table: "Sections",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "FullSchedule",
                table: "Sections",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "StartTime",
                table: "Sections",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

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
                columns: new[] { "Day", "EndTime", "FullSchedule", "StartTime" },
                values: new object[] { "Monday", "8:30AM", "Monday, 7:00AM-8:30AM", "7:00AM" });

            migrationBuilder.UpdateData(
                table: "Sections",
                keyColumn: "ID",
                keyValue: 2,
                columns: new[] { "Day", "EndTime", "FullSchedule", "StartTime" },
                values: new object[] { "Monday", "10:00AM", "Monday, 8:30AM-10:00AM", "8:30AM" });

            migrationBuilder.UpdateData(
                table: "Sections",
                keyColumn: "ID",
                keyValue: 3,
                columns: new[] { "Day", "EndTime", "FullSchedule", "StartTime" },
                values: new object[] { "Monday", "11:30AM", "Monday, 10:00AM-11:30AM", "10:00AM" });

            migrationBuilder.UpdateData(
                table: "Sections",
                keyColumn: "ID",
                keyValue: 4,
                columns: new[] { "Day", "EndTime", "FullSchedule", "StartTime" },
                values: new object[] { "Monday", "1:00PM", "Monday, 11:30AM-1:00PM", "11:30AM" });

            migrationBuilder.UpdateData(
                table: "Sections",
                keyColumn: "ID",
                keyValue: 5,
                columns: new[] { "Day", "EndTime", "FullSchedule", "StartTime" },
                values: new object[] { "Monday", "2:30PM", "Monday, 1:00PM-2:30PM", "1:00PM" });

            migrationBuilder.UpdateData(
                table: "Sections",
                keyColumn: "ID",
                keyValue: 6,
                columns: new[] { "Day", "EndTime", "FullSchedule", "StartTime" },
                values: new object[] { "Monday", "4:00PM", "Monday, 2:30PM-4:00PM", "2:30PM" });

            migrationBuilder.UpdateData(
                table: "Sections",
                keyColumn: "ID",
                keyValue: 7,
                columns: new[] { "Day", "EndTime", "FullSchedule", "StartTime" },
                values: new object[] { "Monday", "5:30PM", "Monday, 4:00PM-5:30PM", "4:00PM" });

            migrationBuilder.UpdateData(
                table: "Sections",
                keyColumn: "ID",
                keyValue: 8,
                columns: new[] { "Day", "EndTime", "FullSchedule", "StartTime" },
                values: new object[] { "Monday", "7:00PM", "Monday, 5:30PM-7:00PM", "5:30PM" });

            migrationBuilder.UpdateData(
                table: "Sections",
                keyColumn: "ID",
                keyValue: 9,
                columns: new[] { "Day", "EndTime", "FullSchedule", "StartTime" },
                values: new object[] { "Monday", "8:30PM", "Monday, 7:00PM-8:30PM", "7:00PM" });

            migrationBuilder.UpdateData(
                table: "Sections",
                keyColumn: "ID",
                keyValue: 10,
                columns: new[] { "Day", "EndTime", "FullSchedule", "StartTime" },
                values: new object[] { "Tuesday", "8:30AM", "Tuesday, 7:00AM-8:30AM", "7:00AM" });

            migrationBuilder.UpdateData(
                table: "Sections",
                keyColumn: "ID",
                keyValue: 11,
                columns: new[] { "Day", "EndTime", "FullSchedule", "StartTime" },
                values: new object[] { "Tuesday", "10:00AM", "Tuesday, 8:30AM-10:00AM", "8:30AM" });

            migrationBuilder.UpdateData(
                table: "Sections",
                keyColumn: "ID",
                keyValue: 12,
                columns: new[] { "Day", "EndTime", "FullSchedule", "StartTime" },
                values: new object[] { "Tuesday", "11:30AM", "Tuesday, 10:00AM-11:30AM", "10:00AM" });

            migrationBuilder.UpdateData(
                table: "Sections",
                keyColumn: "ID",
                keyValue: 13,
                columns: new[] { "Day", "EndTime", "FullSchedule", "StartTime" },
                values: new object[] { "Tuesday", "1:00PM", "Tuesday, 11:30AM-1:00PM", "11:30AM" });

            migrationBuilder.UpdateData(
                table: "Sections",
                keyColumn: "ID",
                keyValue: 14,
                columns: new[] { "Day", "EndTime", "FullSchedule", "StartTime" },
                values: new object[] { "Tuesday", "2:30PM", "Tuesday, 1:00PM-2:30PM", "1:00PM" });

            migrationBuilder.UpdateData(
                table: "Sections",
                keyColumn: "ID",
                keyValue: 15,
                columns: new[] { "Day", "EndTime", "FullSchedule", "StartTime" },
                values: new object[] { "Tuesday", "4:00PM", "Tuesday, 2:30PM-4:00PM", "2:30PM" });

            migrationBuilder.UpdateData(
                table: "Sections",
                keyColumn: "ID",
                keyValue: 16,
                columns: new[] { "Day", "EndTime", "FullSchedule", "StartTime" },
                values: new object[] { "Tuesday", "5:30PM", "Tuesday, 4:00PM-5:30PM", "4:00PM" });

            migrationBuilder.UpdateData(
                table: "Sections",
                keyColumn: "ID",
                keyValue: 17,
                columns: new[] { "Day", "EndTime", "FullSchedule", "StartTime" },
                values: new object[] { "Tuesday", "7:00PM", "Tuesday, 5:30PM-7:00PM", "5:30PM" });

            migrationBuilder.UpdateData(
                table: "Sections",
                keyColumn: "ID",
                keyValue: 18,
                columns: new[] { "Day", "EndTime", "FullSchedule", "StartTime" },
                values: new object[] { "Tuesday", "8:30PM", "Tuesday, 7:00PM-8:30PM", "7:00PM" });

            migrationBuilder.UpdateData(
                table: "Sections",
                keyColumn: "ID",
                keyValue: 19,
                columns: new[] { "Day", "EndTime", "FullSchedule", "StartTime" },
                values: new object[] { "Wednesday", "8:30AM", "Wednesday, 7:00AM-8:30AM", "7:00AM" });

            migrationBuilder.UpdateData(
                table: "Sections",
                keyColumn: "ID",
                keyValue: 20,
                columns: new[] { "Day", "EndTime", "FullSchedule", "StartTime" },
                values: new object[] { "Wednesday", "10:00AM", "Wednesday, 8:30AM-10:00AM", "8:30AM" });

            migrationBuilder.UpdateData(
                table: "Sections",
                keyColumn: "ID",
                keyValue: 21,
                columns: new[] { "Day", "EndTime", "FullSchedule", "StartTime" },
                values: new object[] { "Wednesday", "11:30AM", "Wednesday, 10:00AM-11:30AM", "10:00AM" });

            migrationBuilder.UpdateData(
                table: "Sections",
                keyColumn: "ID",
                keyValue: 22,
                columns: new[] { "Day", "EndTime", "FullSchedule", "StartTime" },
                values: new object[] { "Wednesday", "1:00PM", "Wednesday, 11:30AM-1:00PM", "11:30AM" });

            migrationBuilder.UpdateData(
                table: "Sections",
                keyColumn: "ID",
                keyValue: 23,
                columns: new[] { "Day", "EndTime", "FullSchedule", "StartTime" },
                values: new object[] { "Wednesday", "2:30PM", "Wednesday, 1:00PM-2:30PM", "1:00PM" });

            migrationBuilder.UpdateData(
                table: "Sections",
                keyColumn: "ID",
                keyValue: 24,
                columns: new[] { "Day", "EndTime", "FullSchedule", "StartTime" },
                values: new object[] { "Wednesday", "4:00PM", "Wednesday, 2:30PM-4:00PM", "2:30PM" });

            migrationBuilder.UpdateData(
                table: "Sections",
                keyColumn: "ID",
                keyValue: 25,
                columns: new[] { "Day", "EndTime", "FullSchedule", "StartTime" },
                values: new object[] { "Wednesday", "5:30PM", "Wednesday, 4:00PM-5:30PM", "4:00PM" });

            migrationBuilder.UpdateData(
                table: "Sections",
                keyColumn: "ID",
                keyValue: 26,
                columns: new[] { "Day", "EndTime", "FullSchedule", "StartTime" },
                values: new object[] { "Wednesday", "7:00PM", "Wednesday, 5:30PM-7:00PM", "5:30PM" });

            migrationBuilder.UpdateData(
                table: "Sections",
                keyColumn: "ID",
                keyValue: 27,
                columns: new[] { "Day", "EndTime", "FullSchedule", "StartTime" },
                values: new object[] { "Wednesday", "8:30PM", "Wednesday, 7:00PM-8:30PM", "7:00PM" });

            migrationBuilder.UpdateData(
                table: "Sections",
                keyColumn: "ID",
                keyValue: 28,
                columns: new[] { "Day", "EndTime", "FullSchedule", "StartTime" },
                values: new object[] { "Thursday", "8:30AM", "Thursday, 7:00AM-8:30AM", "7:00AM" });

            migrationBuilder.UpdateData(
                table: "Sections",
                keyColumn: "ID",
                keyValue: 29,
                columns: new[] { "Day", "EndTime", "FullSchedule", "StartTime" },
                values: new object[] { "Thursday", "10:00AM", "Thursday, 8:30AM-10:00AM", "8:30AM" });

            migrationBuilder.UpdateData(
                table: "Sections",
                keyColumn: "ID",
                keyValue: 30,
                columns: new[] { "Day", "EndTime", "FullSchedule", "StartTime" },
                values: new object[] { "Thursday", "11:30AM", "Thursday, 10:00AM-11:30AM", "10:00AM" });

            migrationBuilder.UpdateData(
                table: "Sections",
                keyColumn: "ID",
                keyValue: 31,
                columns: new[] { "Day", "EndTime", "FullSchedule", "StartTime" },
                values: new object[] { "Thursday", "1:00PM", "Thursday, 11:30AM-1:00PM", "11:30AM" });

            migrationBuilder.UpdateData(
                table: "Sections",
                keyColumn: "ID",
                keyValue: 32,
                columns: new[] { "Day", "EndTime", "FullSchedule", "StartTime" },
                values: new object[] { "Thursday", "2:30PM", "Thursday, 1:00PM-2:30PM", "1:00PM" });

            migrationBuilder.UpdateData(
                table: "Sections",
                keyColumn: "ID",
                keyValue: 33,
                columns: new[] { "Day", "EndTime", "FullSchedule", "StartTime" },
                values: new object[] { "Thursday", "4:00PM", "Thursday, 2:30PM-4:00PM", "2:30PM" });

            migrationBuilder.UpdateData(
                table: "Sections",
                keyColumn: "ID",
                keyValue: 34,
                columns: new[] { "Day", "EndTime", "FullSchedule", "StartTime" },
                values: new object[] { "Thursday", "5:30PM", "Thursday, 4:00PM-5:30PM", "4:00PM" });

            migrationBuilder.UpdateData(
                table: "Sections",
                keyColumn: "ID",
                keyValue: 35,
                columns: new[] { "Day", "EndTime", "FullSchedule", "StartTime" },
                values: new object[] { "Thursday", "7:00PM", "Thursday, 5:30PM-7:00PM", "5:30PM" });

            migrationBuilder.UpdateData(
                table: "Sections",
                keyColumn: "ID",
                keyValue: 36,
                columns: new[] { "Day", "EndTime", "FullSchedule", "StartTime" },
                values: new object[] { "Thursday", "8:30PM", "Thursday, 7:00PM-8:30PM", "7:00PM" });

            migrationBuilder.UpdateData(
                table: "Sections",
                keyColumn: "ID",
                keyValue: 37,
                columns: new[] { "Day", "EndTime", "FullSchedule", "StartTime" },
                values: new object[] { "Friday", "8:30AM", "Friday, 7:00AM-8:30AM", "7:00AM" });

            migrationBuilder.UpdateData(
                table: "Sections",
                keyColumn: "ID",
                keyValue: 38,
                columns: new[] { "Day", "EndTime", "FullSchedule", "StartTime" },
                values: new object[] { "Friday", "10:00AM", "Friday, 8:30AM-10:00AM", "8:30AM" });

            migrationBuilder.UpdateData(
                table: "Sections",
                keyColumn: "ID",
                keyValue: 39,
                columns: new[] { "Day", "EndTime", "FullSchedule", "StartTime" },
                values: new object[] { "Friday", "11:30AM", "Friday, 10:00AM-11:30AM", "10:00AM" });

            migrationBuilder.UpdateData(
                table: "Sections",
                keyColumn: "ID",
                keyValue: 40,
                columns: new[] { "Day", "EndTime", "FullSchedule", "StartTime" },
                values: new object[] { "Friday", "1:00PM", "Friday, 11:30AM-1:00PM", "11:30AM" });

            migrationBuilder.UpdateData(
                table: "Sections",
                keyColumn: "ID",
                keyValue: 41,
                columns: new[] { "Day", "EndTime", "FullSchedule", "StartTime" },
                values: new object[] { "Friday", "2:30PM", "Friday, 1:00PM-2:30PM", "1:00PM" });

            migrationBuilder.UpdateData(
                table: "Sections",
                keyColumn: "ID",
                keyValue: 42,
                columns: new[] { "Day", "EndTime", "FullSchedule", "StartTime" },
                values: new object[] { "Friday", "4:00PM", "Friday, 2:30PM-4:00PM", "2:30PM" });

            migrationBuilder.UpdateData(
                table: "Sections",
                keyColumn: "ID",
                keyValue: 43,
                columns: new[] { "Day", "EndTime", "FullSchedule", "StartTime" },
                values: new object[] { "Friday", "5:30PM", "Friday, 4:00PM-5:30PM", "4:00PM" });

            migrationBuilder.UpdateData(
                table: "Sections",
                keyColumn: "ID",
                keyValue: 44,
                columns: new[] { "Day", "EndTime", "FullSchedule", "StartTime" },
                values: new object[] { "Friday", "7:00PM", "Friday, 5:30PM-7:00PM", "5:30PM" });

            migrationBuilder.UpdateData(
                table: "Sections",
                keyColumn: "ID",
                keyValue: 45,
                columns: new[] { "Day", "EndTime", "FullSchedule", "StartTime" },
                values: new object[] { "Friday", "8:30PM", "Friday, 7:00PM-8:30PM", "7:00PM" });

            migrationBuilder.UpdateData(
                table: "Sections",
                keyColumn: "ID",
                keyValue: 46,
                columns: new[] { "Day", "EndTime", "FullSchedule", "StartTime" },
                values: new object[] { "Saturday", "8:30AM", "Saturday, 7:00AM-8:30AM", "7:00AM" });

            migrationBuilder.UpdateData(
                table: "Sections",
                keyColumn: "ID",
                keyValue: 47,
                columns: new[] { "Day", "EndTime", "FullSchedule", "StartTime" },
                values: new object[] { "Saturday", "10:00AM", "Saturday, 8:30AM-10:00AM", "8:30AM" });

            migrationBuilder.UpdateData(
                table: "Sections",
                keyColumn: "ID",
                keyValue: 48,
                columns: new[] { "Day", "EndTime", "FullSchedule", "StartTime" },
                values: new object[] { "Saturday", "11:30AM", "Saturday, 10:00AM-11:30AM", "10:00AM" });

            migrationBuilder.UpdateData(
                table: "Sections",
                keyColumn: "ID",
                keyValue: 49,
                columns: new[] { "Day", "EndTime", "FullSchedule", "StartTime" },
                values: new object[] { "Saturday", "1:00PM", "Saturday, 11:30AM-1:00PM", "11:30AM" });

            migrationBuilder.UpdateData(
                table: "Sections",
                keyColumn: "ID",
                keyValue: 50,
                columns: new[] { "Day", "EndTime", "FullSchedule", "StartTime" },
                values: new object[] { "Saturday", "2:30PM", "Saturday, 1:00PM-2:30PM", "1:00PM" });

            migrationBuilder.UpdateData(
                table: "Sections",
                keyColumn: "ID",
                keyValue: 51,
                columns: new[] { "Day", "EndTime", "FullSchedule", "StartTime" },
                values: new object[] { "Saturday", "4:00PM", "Saturday, 2:30PM-4:00PM", "2:30PM" });

            migrationBuilder.UpdateData(
                table: "Sections",
                keyColumn: "ID",
                keyValue: 52,
                columns: new[] { "Day", "EndTime", "FullSchedule", "StartTime" },
                values: new object[] { "Saturday", "5:30PM", "Saturday, 4:00PM-5:30PM", "4:00PM" });

            migrationBuilder.UpdateData(
                table: "Sections",
                keyColumn: "ID",
                keyValue: 53,
                columns: new[] { "Day", "EndTime", "FullSchedule", "StartTime" },
                values: new object[] { "Saturday", "7:00PM", "Saturday, 5:30PM-7:00PM", "5:30PM" });

            migrationBuilder.UpdateData(
                table: "Sections",
                keyColumn: "ID",
                keyValue: 54,
                columns: new[] { "Day", "EndTime", "FullSchedule", "StartTime" },
                values: new object[] { "Saturday", "8:30PM", "saturday, 7:00PM-8:30PM", "7:00PM" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "747c9aba-15d5-4a37-97cb-46e4a2e4c3cf");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "c1742731-5847-4179-a6e9-481c8e72a7da");

            migrationBuilder.DropColumn(
                name: "Day",
                table: "Sections");

            migrationBuilder.DropColumn(
                name: "EndTime",
                table: "Sections");

            migrationBuilder.DropColumn(
                name: "FullSchedule",
                table: "Sections");

            migrationBuilder.DropColumn(
                name: "StartTime",
                table: "Sections");

            migrationBuilder.AlterColumn<string>(
                name: "SectionCode",
                table: "Sections",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "01c4af82-e7e4-441f-a04e-b976cf24d2f5", "871e0e8c-bf40-4255-94ae-664e69ebed84", "Administrator", "ADMINISTRATOR" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "e6f7f994-1a74-4e45-acce-ff2a74cc3a9a", "f62cde67-a4d9-4ede-808e-024afb51e3ff", "Student", "STUDENT" });
        }
    }
}
