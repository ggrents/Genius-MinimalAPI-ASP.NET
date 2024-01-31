using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace geniusminimalAPI.Migrations
{
    /// <inheritdoc />
    public partial class initial : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "musicians",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    surname = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Nickname = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    age = table.Column<int>(type: "int", nullable: false),
                    BirthDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    info = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_musicians", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "releases",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    imagePath = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MusicianId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_releases", x => x.id);
                    table.ForeignKey(
                        name: "FK_releases_musicians_MusicianId",
                        column: x => x.MusicianId,
                        principalTable: "musicians",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "tracks",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ReleaseId = table.Column<int>(type: "int", nullable: false),
                    LyricsId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tracks", x => x.id);
                    table.ForeignKey(
                        name: "FK_tracks_releases_ReleaseId",
                        column: x => x.ReleaseId,
                        principalTable: "releases",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "lyrics",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    content = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TrackId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_lyrics", x => x.id);
                    table.ForeignKey(
                        name: "FK_lyrics_tracks_TrackId",
                        column: x => x.TrackId,
                        principalTable: "tracks",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "annotations",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    content = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    firstsymbol = table.Column<int>(name: "first_symbol", type: "int", nullable: false),
                    lastsymbol = table.Column<int>(name: "last_symbol", type: "int", nullable: false),
                    LyricsId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_annotations", x => x.id);
                    table.ForeignKey(
                        name: "FK_annotations_lyrics_LyricsId",
                        column: x => x.LyricsId,
                        principalTable: "lyrics",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_annotations_LyricsId",
                table: "annotations",
                column: "LyricsId");

            migrationBuilder.CreateIndex(
                name: "IX_lyrics_TrackId",
                table: "lyrics",
                column: "TrackId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_releases_MusicianId",
                table: "releases",
                column: "MusicianId");

            migrationBuilder.CreateIndex(
                name: "IX_tracks_ReleaseId",
                table: "tracks",
                column: "ReleaseId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "annotations");

            migrationBuilder.DropTable(
                name: "lyrics");

            migrationBuilder.DropTable(
                name: "tracks");

            migrationBuilder.DropTable(
                name: "releases");

            migrationBuilder.DropTable(
                name: "musicians");
        }
    }
}
