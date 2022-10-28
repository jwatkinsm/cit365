using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ScriptureJournal.Migrations
{
    public partial class Dateadded : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "ReleaseDate",
                table: "ScriptureNote",
                newName: "DateAdded");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "DateAdded",
                table: "ScriptureNote",
                newName: "ReleaseDate");
        }
    }
}
