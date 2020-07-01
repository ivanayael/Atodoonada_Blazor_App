using Microsoft.EntityFrameworkCore.Migrations;

namespace Atodoonada_Blazor_App.Migrations
{
    public partial class thirdCommit : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "NroConcursante",
                table: "AptoFisicos",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "NroConcursante",
                table: "AptoFisicos");
        }
    }
}
