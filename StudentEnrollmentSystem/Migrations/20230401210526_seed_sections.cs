using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace StudentEnrollmentSystem.Migrations
{
    public partial class seed_sections : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "01fc9dc8-74dc-4805-b32a-3b2879324630");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "d3436964-4c24-4fb1-afe6-e67c60a8b712");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "04582e64-7603-4206-af65-37888b9161ca", "a08a0828-0dcf-415f-b223-a72f70c49fd9", "Administrator", "ADMINISTRATOR" },
                    { "81702cfd-0c46-48ee-a871-f27c81b4c5a9", "c6c1ef16-f800-47a7-a021-fea56f61150e", "Student", "STUDENT" }
                });

            migrationBuilder.InsertData(
                table: "Sections",
                columns: new[] { "ID", "SectionCode" },
                values: new object[,]
                {
                    { 1, "MAB" },
                    { 2, "MBC" },
                    { 3, "MCD" },
                    { 4, "MDE" },
                    { 5, "MEF" },
                    { 6, "MFG" },
                    { 7, "MGH" },
                    { 8, "MHI" },
                    { 9, "MIJ" },
                    { 10, "TAB" },
                    { 11, "TBC" },
                    { 12, "TCD" },
                    { 13, "TDE" },
                    { 14, "TEF" },
                    { 15, "TFG" },
                    { 16, "TGH" },
                    { 17, "THI" },
                    { 18, "TIJ" },
                    { 19, "WAB" },
                    { 20, "WBC" },
                    { 21, "WCD" },
                    { 22, "WDE" },
                    { 23, "WEF" },
                    { 24, "WFG" },
                    { 25, "WGH" },
                    { 26, "WHI" },
                    { 27, "WIJ" },
                    { 28, "HAB" },
                    { 29, "HBC" },
                    { 30, "HCD" },
                    { 31, "HDE" },
                    { 32, "HEF" },
                    { 33, "HFG" },
                    { 34, "HGH" },
                    { 35, "HHI" },
                    { 36, "HIJ" },
                    { 37, "FAB" },
                    { 38, "FBC" },
                    { 39, "FCD" },
                    { 40, "FDE" }
                });

            migrationBuilder.InsertData(
                table: "Sections",
                columns: new[] { "ID", "SectionCode" },
                values: new object[,]
                {
                    { 41, "FEF" },
                    { 42, "FFG" },
                    { 43, "FGH" },
                    { 44, "FHI" },
                    { 45, "FIJ" },
                    { 46, "SAB" },
                    { 47, "SBC" },
                    { 48, "SCD" },
                    { 49, "SDE" },
                    { 50, "SEF" },
                    { 51, "SFG" },
                    { 52, "SGH" },
                    { 53, "SHI" },
                    { 54, "SIJ" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "04582e64-7603-4206-af65-37888b9161ca");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "81702cfd-0c46-48ee-a871-f27c81b4c5a9");

            migrationBuilder.DeleteData(
                table: "Sections",
                keyColumn: "ID",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Sections",
                keyColumn: "ID",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Sections",
                keyColumn: "ID",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Sections",
                keyColumn: "ID",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Sections",
                keyColumn: "ID",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Sections",
                keyColumn: "ID",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Sections",
                keyColumn: "ID",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Sections",
                keyColumn: "ID",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Sections",
                keyColumn: "ID",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Sections",
                keyColumn: "ID",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Sections",
                keyColumn: "ID",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Sections",
                keyColumn: "ID",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Sections",
                keyColumn: "ID",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Sections",
                keyColumn: "ID",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Sections",
                keyColumn: "ID",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Sections",
                keyColumn: "ID",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Sections",
                keyColumn: "ID",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Sections",
                keyColumn: "ID",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Sections",
                keyColumn: "ID",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "Sections",
                keyColumn: "ID",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "Sections",
                keyColumn: "ID",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "Sections",
                keyColumn: "ID",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "Sections",
                keyColumn: "ID",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "Sections",
                keyColumn: "ID",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "Sections",
                keyColumn: "ID",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "Sections",
                keyColumn: "ID",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "Sections",
                keyColumn: "ID",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "Sections",
                keyColumn: "ID",
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "Sections",
                keyColumn: "ID",
                keyValue: 29);

            migrationBuilder.DeleteData(
                table: "Sections",
                keyColumn: "ID",
                keyValue: 30);

            migrationBuilder.DeleteData(
                table: "Sections",
                keyColumn: "ID",
                keyValue: 31);

            migrationBuilder.DeleteData(
                table: "Sections",
                keyColumn: "ID",
                keyValue: 32);

            migrationBuilder.DeleteData(
                table: "Sections",
                keyColumn: "ID",
                keyValue: 33);

            migrationBuilder.DeleteData(
                table: "Sections",
                keyColumn: "ID",
                keyValue: 34);

            migrationBuilder.DeleteData(
                table: "Sections",
                keyColumn: "ID",
                keyValue: 35);

            migrationBuilder.DeleteData(
                table: "Sections",
                keyColumn: "ID",
                keyValue: 36);

            migrationBuilder.DeleteData(
                table: "Sections",
                keyColumn: "ID",
                keyValue: 37);

            migrationBuilder.DeleteData(
                table: "Sections",
                keyColumn: "ID",
                keyValue: 38);

            migrationBuilder.DeleteData(
                table: "Sections",
                keyColumn: "ID",
                keyValue: 39);

            migrationBuilder.DeleteData(
                table: "Sections",
                keyColumn: "ID",
                keyValue: 40);

            migrationBuilder.DeleteData(
                table: "Sections",
                keyColumn: "ID",
                keyValue: 41);

            migrationBuilder.DeleteData(
                table: "Sections",
                keyColumn: "ID",
                keyValue: 42);

            migrationBuilder.DeleteData(
                table: "Sections",
                keyColumn: "ID",
                keyValue: 43);

            migrationBuilder.DeleteData(
                table: "Sections",
                keyColumn: "ID",
                keyValue: 44);

            migrationBuilder.DeleteData(
                table: "Sections",
                keyColumn: "ID",
                keyValue: 45);

            migrationBuilder.DeleteData(
                table: "Sections",
                keyColumn: "ID",
                keyValue: 46);

            migrationBuilder.DeleteData(
                table: "Sections",
                keyColumn: "ID",
                keyValue: 47);

            migrationBuilder.DeleteData(
                table: "Sections",
                keyColumn: "ID",
                keyValue: 48);

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
                values: new object[] { "01fc9dc8-74dc-4805-b32a-3b2879324630", "26eea44c-febe-4edc-98b2-35ad47218606", "Administrator", "ADMINISTRATOR" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "d3436964-4c24-4fb1-afe6-e67c60a8b712", "193f4d32-7807-4196-979a-550ed62fe608", "Student", "STUDENT" });
        }
    }
}
