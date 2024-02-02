using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace geniusminimalAPI.Migrations
{
    /// <inheritdoc />
    public partial class newtables : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "articles",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    title = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    content = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    imagepath = table.Column<string>(name: "image_path", type: "nvarchar(max)", nullable: true),
                    datecreated = table.Column<DateTime>(name: "date_created", type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_articles", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "popularities",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    viewcount = table.Column<int>(name: "view_count", type: "int", nullable: false),
                    MusicianId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_popularities", x => x.id);
                    table.ForeignKey(
                        name: "FK_popularities_musicians_MusicianId",
                        column: x => x.MusicianId,
                        principalTable: "musicians",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_popularities_MusicianId",
                table: "popularities",
                column: "MusicianId",
                unique: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "articles");

            migrationBuilder.DropTable(
                name: "popularities");
        }
    }
}
