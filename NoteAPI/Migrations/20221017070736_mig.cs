using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace NoteAPI.Migrations
{
    public partial class mig : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Notes",
                keyColumn: "Id",
                keyValue: 3,
                column: "Content",
                value: "Sök semester från jobb vecka 28-32, boka resa!");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Notes",
                keyColumn: "Id",
                keyValue: 3,
                column: "Content",
                value: "Semester vecka 28-32, boka resa!");
        }
    }
}
