using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace StudentEnrollmentSystem.Migrations
{
    public partial class create_section : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "bfb4234d-e4b6-400d-96f8-3d850a41ac4b");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "ef2f75f0-adf5-4a2d-b315-069ae76fb975");

            migrationBuilder.DropColumn(
                name: "Section",
                table: "Subjects");

            migrationBuilder.AddColumn<int>(
                name: "SectionID",
                table: "Subjects",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "Sections",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SectionCode = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Sections", x => x.ID);
                });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "01fc9dc8-74dc-4805-b32a-3b2879324630", "26eea44c-febe-4edc-98b2-35ad47218606", "Administrator", "ADMINISTRATOR" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "d3436964-4c24-4fb1-afe6-e67c60a8b712", "193f4d32-7807-4196-979a-550ed62fe608", "Student", "STUDENT" });

            migrationBuilder.CreateIndex(
                name: "IX_Subjects_SectionID",
                table: "Subjects",
                column: "SectionID");

            migrationBuilder.AddForeignKey(
                name: "FK_Subjects_Sections_SectionID",
                table: "Subjects",
                column: "SectionID",
                principalTable: "Sections",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Subjects_Sections_SectionID",
                table: "Subjects");

            migrationBuilder.DropTable(
                name: "Sections");

            migrationBuilder.DropIndex(
                name: "IX_Subjects_SectionID",
                table: "Subjects");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "01fc9dc8-74dc-4805-b32a-3b2879324630");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "d3436964-4c24-4fb1-afe6-e67c60a8b712");

            migrationBuilder.DropColumn(
                name: "SectionID",
                table: "Subjects");

            migrationBuilder.AddColumn<string>(
                name: "Section",
                table: "Subjects",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "bfb4234d-e4b6-400d-96f8-3d850a41ac4b", "8d8132f0-5ef3-45d9-8a75-5df307ae325b", "Administrator", "ADMINISTRATOR" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "ef2f75f0-adf5-4a2d-b315-069ae76fb975", "40eba514-d338-48f6-bc6e-d66ac4323a69", "Student", "STUDENT" });
        }
    }
}
