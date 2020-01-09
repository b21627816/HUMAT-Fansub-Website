using Microsoft.EntityFrameworkCore.Migrations;

namespace StajBlogProject.Migrations
{
    public partial class AddAnimeIDtoEpisode : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AnimeEpisodes_Animes_AnimeId",
                table: "AnimeEpisodes");

            migrationBuilder.AlterColumn<int>(
                name: "AnimeId",
                table: "AnimeEpisodes",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_AnimeEpisodes_Animes_AnimeId",
                table: "AnimeEpisodes",
                column: "AnimeId",
                principalTable: "Animes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AnimeEpisodes_Animes_AnimeId",
                table: "AnimeEpisodes");

            migrationBuilder.AlterColumn<int>(
                name: "AnimeId",
                table: "AnimeEpisodes",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AddForeignKey(
                name: "FK_AnimeEpisodes_Animes_AnimeId",
                table: "AnimeEpisodes",
                column: "AnimeId",
                principalTable: "Animes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
