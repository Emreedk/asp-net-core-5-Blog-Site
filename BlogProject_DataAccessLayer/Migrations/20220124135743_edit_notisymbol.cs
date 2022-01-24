using Microsoft.EntityFrameworkCore.Migrations;

namespace BlogProject_DataAccessLayer.Migrations
{
    public partial class edit_notisymbol : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "NotificationTypeSymblol",
                table: "Notifications",
                newName: "NotificationTypeSymbol");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "NotificationTypeSymbol",
                table: "Notifications",
                newName: "NotificationTypeSymblol");
        }
    }
}
