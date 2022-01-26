using Microsoft.EntityFrameworkCore.Migrations;

namespace BlogProject_DataAccessLayer.Migrations
{
    public partial class edit_messagetbl : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Messages_Writers_Receiver",
                table: "Messages");

            migrationBuilder.DropForeignKey(
                name: "FK_Messages_Writers_Sender",
                table: "Messages");

            migrationBuilder.RenameColumn(
                name: "Sender",
                table: "Messages",
                newName: "SenderId");

            migrationBuilder.RenameColumn(
                name: "Receiver",
                table: "Messages",
                newName: "ReceiverId");

            migrationBuilder.RenameIndex(
                name: "IX_Messages_Sender",
                table: "Messages",
                newName: "IX_Messages_SenderId");

            migrationBuilder.RenameIndex(
                name: "IX_Messages_Receiver",
                table: "Messages",
                newName: "IX_Messages_ReceiverId");

            migrationBuilder.AddForeignKey(
                name: "FK_Messages_Writers_ReceiverId",
                table: "Messages",
                column: "ReceiverId",
                principalTable: "Writers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Messages_Writers_SenderId",
                table: "Messages",
                column: "SenderId",
                principalTable: "Writers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Messages_Writers_ReceiverId",
                table: "Messages");

            migrationBuilder.DropForeignKey(
                name: "FK_Messages_Writers_SenderId",
                table: "Messages");

            migrationBuilder.RenameColumn(
                name: "SenderId",
                table: "Messages",
                newName: "Sender");

            migrationBuilder.RenameColumn(
                name: "ReceiverId",
                table: "Messages",
                newName: "Receiver");

            migrationBuilder.RenameIndex(
                name: "IX_Messages_SenderId",
                table: "Messages",
                newName: "IX_Messages_Sender");

            migrationBuilder.RenameIndex(
                name: "IX_Messages_ReceiverId",
                table: "Messages",
                newName: "IX_Messages_Receiver");

            migrationBuilder.AddForeignKey(
                name: "FK_Messages_Writers_Receiver",
                table: "Messages",
                column: "Receiver",
                principalTable: "Writers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Messages_Writers_Sender",
                table: "Messages",
                column: "Sender",
                principalTable: "Writers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
