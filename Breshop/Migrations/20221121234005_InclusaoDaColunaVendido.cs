using Microsoft.EntityFrameworkCore.Migrations;

namespace Breshop.Migrations
{
    public partial class InclusaoDaColunaVendido : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Sexo",
                table: "Produto");

            migrationBuilder.AddColumn<bool>(
                name: "EstoqueDisponivel",
                table: "Produto",
                nullable: false,
                defaultValue: false);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "EstoqueDisponivel",
                table: "Produto");

            migrationBuilder.AddColumn<string>(
                name: "Sexo",
                table: "Produto",
                nullable: true);
        }
    }
}
