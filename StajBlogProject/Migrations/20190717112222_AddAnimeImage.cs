using Microsoft.EntityFrameworkCore.Migrations;

namespace StajBlogProject.Migrations
{
    public partial class AddAnimeImage : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "ImageUrl",
                table: "Animes",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ImageUrl",
                table: "Animes");
        }
    }
}
