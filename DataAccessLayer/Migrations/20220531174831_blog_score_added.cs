using Microsoft.EntityFrameworkCore.Migrations;

namespace DataAccessLayer.Migrations
{
    public partial class blog_score_added : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Comments_Comments_CommmentStatusCommentID",
                table: "Comments");

            migrationBuilder.DropIndex(
                name: "IX_Comments_CommmentStatusCommentID",
                table: "Comments");

            migrationBuilder.DropColumn(
                name: "CommmentStatusCommentID",
                table: "Comments");

            migrationBuilder.AddColumn<int>(
                name: "BlogScore",
                table: "Comments",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "BlogScore",
                table: "Comments");

            migrationBuilder.AddColumn<int>(
                name: "CommmentStatusCommentID",
                table: "Comments",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Comments_CommmentStatusCommentID",
                table: "Comments",
                column: "CommmentStatusCommentID");

            migrationBuilder.AddForeignKey(
                name: "FK_Comments_Comments_CommmentStatusCommentID",
                table: "Comments",
                column: "CommmentStatusCommentID",
                principalTable: "Comments",
                principalColumn: "CommentID",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
