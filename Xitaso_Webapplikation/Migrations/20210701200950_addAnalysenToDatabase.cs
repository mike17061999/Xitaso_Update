using Microsoft.EntityFrameworkCore.Migrations;

namespace Xitaso_Webapplikation.Migrations
{
    public partial class addAnalysenToDatabase : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Analysekategorie_Analysen_AnalyseId",
                table: "Analysekategorie");

            migrationBuilder.DropForeignKey(
                name: "FK_Analysen_Projekte_ProjektId",
                table: "Analysen");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Analysen",
                table: "Analysen");

            migrationBuilder.RenameTable(
                name: "Analysen",
                newName: "Analyse");

            migrationBuilder.RenameIndex(
                name: "IX_Analysen_ProjektId",
                table: "Analyse",
                newName: "IX_Analyse_ProjektId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Analyse",
                table: "Analyse",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Analyse_Projekte_ProjektId",
                table: "Analyse",
                column: "ProjektId",
                principalTable: "Projekte",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Analysekategorie_Analyse_AnalyseId",
                table: "Analysekategorie",
                column: "AnalyseId",
                principalTable: "Analyse",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Analyse_Projekte_ProjektId",
                table: "Analyse");

            migrationBuilder.DropForeignKey(
                name: "FK_Analysekategorie_Analyse_AnalyseId",
                table: "Analysekategorie");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Analyse",
                table: "Analyse");

            migrationBuilder.RenameTable(
                name: "Analyse",
                newName: "Analysen");

            migrationBuilder.RenameIndex(
                name: "IX_Analyse_ProjektId",
                table: "Analysen",
                newName: "IX_Analysen_ProjektId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Analysen",
                table: "Analysen",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Analysekategorie_Analysen_AnalyseId",
                table: "Analysekategorie",
                column: "AnalyseId",
                principalTable: "Analysen",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Analysen_Projekte_ProjektId",
                table: "Analysen",
                column: "ProjektId",
                principalTable: "Projekte",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
