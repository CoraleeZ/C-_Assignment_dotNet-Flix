using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Dotnet_Flix.Migrations
{
    public partial class first : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Moviees",
                columns: table => new
                {
                    MovieId = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Title = table.Column<string>(nullable: false),
                    Genre = table.Column<string>(nullable: false),
                    Released = table.Column<DateTime>(nullable: false),
                    CreatedAt = table.Column<DateTime>(nullable: false),
                    UpdatedAt = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Moviees", x => x.MovieId);
                });

            migrationBuilder.CreateTable(
                name: "Useres",
                columns: table => new
                {
                    UserId = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Firstname = table.Column<string>(maxLength: 50, nullable: false),
                    Lastname = table.Column<string>(maxLength: 50, nullable: false),
                    Email = table.Column<string>(nullable: false),
                    Password = table.Column<string>(nullable: false),
                    CreatedAt = table.Column<DateTime>(nullable: false),
                    UpdatedAt = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Useres", x => x.UserId);
                });

            migrationBuilder.CreateTable(
                name: "Check_outes",
                columns: table => new
                {
                    Check_outId = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    UserId = table.Column<int>(nullable: false),
                    MovieId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Check_outes", x => x.Check_outId);
                    table.ForeignKey(
                        name: "FK_Check_outes_Moviees_MovieId",
                        column: x => x.MovieId,
                        principalTable: "Moviees",
                        principalColumn: "MovieId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Check_outes_Useres_UserId",
                        column: x => x.UserId,
                        principalTable: "Useres",
                        principalColumn: "UserId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Ratees",
                columns: table => new
                {
                    RateId = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    rate = table.Column<int>(nullable: false),
                    UserId = table.Column<int>(nullable: false),
                    MovieId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Ratees", x => x.RateId);
                    table.ForeignKey(
                        name: "FK_Ratees_Moviees_MovieId",
                        column: x => x.MovieId,
                        principalTable: "Moviees",
                        principalColumn: "MovieId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Ratees_Useres_UserId",
                        column: x => x.UserId,
                        principalTable: "Useres",
                        principalColumn: "UserId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Check_outes_MovieId",
                table: "Check_outes",
                column: "MovieId");

            migrationBuilder.CreateIndex(
                name: "IX_Check_outes_UserId",
                table: "Check_outes",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_Ratees_MovieId",
                table: "Ratees",
                column: "MovieId");

            migrationBuilder.CreateIndex(
                name: "IX_Ratees_UserId",
                table: "Ratees",
                column: "UserId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Check_outes");

            migrationBuilder.DropTable(
                name: "Ratees");

            migrationBuilder.DropTable(
                name: "Moviees");

            migrationBuilder.DropTable(
                name: "Useres");
        }
    }
}
