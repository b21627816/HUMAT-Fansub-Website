using Microsoft.EntityFrameworkCore.Migrations;

namespace StajBlogProject.Migrations
{
    public partial class AddTextOnlyToPost : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "TextOnly",
                table: "Posts",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "TextOnly",
                table: "Posts");
        }
    }
}
