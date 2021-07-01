using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Xitaso_Webapplikation.Migrations
{
    public partial class addProjekteToDatabase : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Projekte",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ProjectDescription = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    StartTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    EndTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ProjectFinished = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Projekte", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Analyse",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Comment = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastChanged = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ProjektId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Analyse", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Analyse_Projekte_ProjektId",
                        column: x => x.ProjektId,
                        principalTable: "Projekte",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Analysekategorie",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AnalyseId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Analysekategorie", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Analysekategorie_Analyse_AnalyseId",
                        column: x => x.AnalyseId,
                        principalTable: "Analyse",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Frage",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IstBewertung = table.Column<int>(type: "int", nullable: false),
                    SollBewertung = table.Column<int>(type: "int", nullable: false),
                    AnalysekategorieId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Frage", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Frage_Analysekategorie_AnalysekategorieId",
                        column: x => x.AnalysekategorieId,
                        principalTable: "Analysekategorie",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Analyse_ProjektId",
                table: "Analyse",
                column: "ProjektId");

            migrationBuilder.CreateIndex(
                name: "IX_Analysekategorie_AnalyseId",
                table: "Analysekategorie",
                column: "AnalyseId");

            migrationBuilder.CreateIndex(
                name: "IX_Frage_AnalysekategorieId",
                table: "Frage",
                column: "AnalysekategorieId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Frage");

            migrationBuilder.DropTable(
                name: "Analysekategorie");

            migrationBuilder.DropTable(
                name: "Analyse");

            migrationBuilder.DropTable(
                name: "Projekte");
        }
    }
}
