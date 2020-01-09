using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace StajBlogProject.Migrations
{
    public partial class AddMangas : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Mangas",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Title = table.Column<string>(nullable: true),
                    Summary = table.Column<string>(nullable: true),
                    ImageUrl = table.Column<string>(nullable: true),
                    UploadDate = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Mangas", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_MangaChapters_MangaId",
                table: "MangaChapters",
                column: "MangaId");

            migrationBuilder.AddForeignKey(
                name: "FK_MangaChapters_Mangas_MangaId",
                table: "MangaChapters",
                column: "MangaId",
                principalTable: "Mangas",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_MangaChapters_Mangas_MangaId",
                table: "MangaChapters");

            migrationBuilder.DropTable(
                name: "Mangas");

            migrationBuilder.DropIndex(
                name: "IX_MangaChapters_MangaId",
                table: "MangaChapters");
        }
    }
}
