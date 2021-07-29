using Microsoft.EntityFrameworkCore.Migrations;

namespace TechTreeMVCWebApplication.Data.Migrations
{
    public partial class ExtendAspUsersTables : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_UserCategory_AspNetUsers_UserId",
                table: "UserCategory");

            migrationBuilder.DropIndex(
                name: "IX_UserCategory_UserId",
                table: "UserCategory");

            migrationBuilder.AlterColumn<string>(
                name: "UserId",
                table: "UserCategory",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "UserID",
                table: "UserCategory",
                type: "nvarchar(450)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_UserCategory_UserID",
                table: "UserCategory",
                column: "UserID");

            migrationBuilder.AddForeignKey(
                name: "FK_UserCategory_AspNetUsers_UserID",
                table: "UserCategory",
                column: "UserID",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_UserCategory_AspNetUsers_UserID",
                table: "UserCategory");

            migrationBuilder.DropIndex(
                name: "IX_UserCategory_UserID",
                table: "UserCategory");

            migrationBuilder.AlterColumn<string>(
                name: "UserId",
                table: "UserCategory",
                type: "nvarchar(450)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "UserID",
                table: "UserCategory",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)",
                oldNullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_UserCategory_UserId",
                table: "UserCategory",
                column: "UserId");

            migrationBuilder.AddForeignKey(
                name: "FK_UserCategory_AspNetUsers_UserId",
                table: "UserCategory",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
