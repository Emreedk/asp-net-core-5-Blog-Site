using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace BlogProject_DataAccessLayer.Migrations
{
    public partial class edit_messagetable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Message2s");

            migrationBuilder.DropColumn(
                name: "Reciever",
                table: "Messages");

            migrationBuilder.AlterColumn<int>(
                name: "Sender",
                table: "Messages",
                type: "int",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Receiver",
                table: "Messages",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Messages_Receiver",
                table: "Messages",
                column: "Receiver");

            migrationBuilder.CreateIndex(
                name: "IX_Messages_Sender",
                table: "Messages",
                column: "Sender");

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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Messages_Writers_Receiver",
                table: "Messages");

            migrationBuilder.DropForeignKey(
                name: "FK_Messages_Writers_Sender",
                table: "Messages");

            migrationBuilder.DropIndex(
                name: "IX_Messages_Receiver",
                table: "Messages");

            migrationBuilder.DropIndex(
                name: "IX_Messages_Sender",
                table: "Messages");

            migrationBuilder.DropColumn(
                name: "Receiver",
                table: "Messages");

            migrationBuilder.AlterColumn<string>(
                name: "Sender",
                table: "Messages",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Reciever",
                table: "Messages",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "Message2s",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MessageDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    MessageDetails = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MessageStatus = table.Column<bool>(type: "bit", nullable: false),
                    Receiver = table.Column<int>(type: "int", nullable: true),
                    Sender = table.Column<int>(type: "int", nullable: true),
                    Subject = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Message2s", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Message2s_Writers_Receiver",
                        column: x => x.Receiver,
                        principalTable: "Writers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Message2s_Writers_Sender",
                        column: x => x.Sender,
                        principalTable: "Writers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Message2s_Receiver",
                table: "Message2s",
                column: "Receiver");

            migrationBuilder.CreateIndex(
                name: "IX_Message2s_Sender",
                table: "Message2s",
                column: "Sender");
        }
    }
}
