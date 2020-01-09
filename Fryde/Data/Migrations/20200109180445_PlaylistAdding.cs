using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Fryde.Data.Migrations
{
    public partial class PlaylistAdding : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "PlaylistId",
                table: "Music",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "Playlist",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(nullable: true),
                    Genre = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Playlist", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Music_PlaylistId",
                table: "Music",
                column: "PlaylistId");

            migrationBuilder.AddForeignKey(
                name: "FK_Music_Playlist_PlaylistId",
                table: "Music",
                column: "PlaylistId",
                principalTable: "Playlist",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Music_Playlist_PlaylistId",
                table: "Music");

            migrationBuilder.DropTable(
                name: "Playlist");

            migrationBuilder.DropIndex(
                name: "IX_Music_PlaylistId",
                table: "Music");

            migrationBuilder.DropColumn(
                name: "PlaylistId",
                table: "Music");
        }
    }
}
