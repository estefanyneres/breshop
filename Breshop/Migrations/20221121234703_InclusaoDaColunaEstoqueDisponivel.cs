using Microsoft.EntityFrameworkCore.Migrations;

namespace Breshop.Migrations
{
    public partial class InclusaoDaColunaEstoqueDisponivel : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Vendido",
                table: "Produto",
                newName: "EstoqueDisponivel");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "EstoqueDisponivel",
                table: "Produto",
                newName: "Vendido");
        }
    }
}
