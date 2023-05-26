using Microsoft.EntityFrameworkCore.Migrations;

namespace DataAccessLayer.Migrations
{
    public partial class mig4 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "NewsLetterMailID",
                table: "Blogs",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Blogs_NewsLetterMailID",
                table: "Blogs",
                column: "NewsLetterMailID");

            migrationBuilder.AddForeignKey(
                name: "FK_Blogs_NewsLetters_NewsLetterMailID",
                table: "Blogs",
                column: "NewsLetterMailID",
                principalTable: "NewsLetters",
                principalColumn: "MailID",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Blogs_NewsLetters_NewsLetterMailID",
                table: "Blogs");

            migrationBuilder.DropIndex(
                name: "IX_Blogs_NewsLetterMailID",
                table: "Blogs");

            migrationBuilder.DropColumn(
                name: "NewsLetterMailID",
                table: "Blogs");
        }
    }
}
