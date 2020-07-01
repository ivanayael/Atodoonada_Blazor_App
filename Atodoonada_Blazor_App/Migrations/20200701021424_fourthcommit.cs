using Microsoft.EntityFrameworkCore.Migrations;

namespace Atodoonada_Blazor_App.Migrations
{
    public partial class fourthcommit : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "NroConcursante",
                table: "AptoFisicos");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "NroConcursante",
                table: "AptoFisicos",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }
    }
}
