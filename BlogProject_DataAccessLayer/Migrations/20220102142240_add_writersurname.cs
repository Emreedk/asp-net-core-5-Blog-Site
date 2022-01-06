using Microsoft.EntityFrameworkCore.Migrations;

namespace BlogProject_DataAccessLayer.Migrations
{
    public partial class add_writersurname : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "WriterFullName",
                table: "Writers",
                newName: "WriterSurname");

            migrationBuilder.AddColumn<string>(
                name: "WriterName",
                table: "Writers",
                type: "nvarchar(max)",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "WriterName",
                table: "Writers");

            migrationBuilder.RenameColumn(
                name: "WriterSurname",
                table: "Writers",
                newName: "WriterFullName");
        }
    }
}
