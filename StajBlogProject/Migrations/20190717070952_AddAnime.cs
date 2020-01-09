using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace StajBlogProject.Migrations
{
    public partial class AddAnime : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "AnimeId",
                table: "AnimeEpisodes",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "Animes",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Title = table.Column<string>(nullable: true),
                    Summary = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Animes", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_AnimeEpisodes_AnimeId",
                table: "AnimeEpisodes",
                column: "AnimeId");

            migrationBuilder.AddForeignKey(
                name: "FK_AnimeEpisodes_Animes_AnimeId",
                table: "AnimeEpisodes",
                column: "AnimeId",
                principalTable: "Animes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AnimeEpisodes_Animes_AnimeId",
                table: "AnimeEpisodes");

            migrationBuilder.DropTable(
                name: "Animes");

            migrationBuilder.DropIndex(
                name: "IX_AnimeEpisodes_AnimeId",
                table: "AnimeEpisodes");

            migrationBuilder.DropColumn(
                name: "AnimeId",
                table: "AnimeEpisodes");
        }
    }
}
