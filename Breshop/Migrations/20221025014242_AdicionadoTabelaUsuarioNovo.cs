using Microsoft.EntityFrameworkCore.Migrations;

namespace Breshop.Migrations
{
    public partial class AdicionadoTabelaUsuarioNovo : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CEP",
                table: "Usuario");

            migrationBuilder.DropColumn(
                name: "Celular",
                table: "Usuario");

            migrationBuilder.DropColumn(
                name: "Endereco",
                table: "Usuario");

            migrationBuilder.DropColumn(
                name: "Nome",
                table: "Usuario");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "CEP",
                table: "Usuario",
                nullable: true);

            migrationBuilder.AddColumn<double>(
                name: "Celular",
                table: "Usuario",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<string>(
                name: "Endereco",
                table: "Usuario",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Nome",
                table: "Usuario",
                nullable: true);
        }
    }
}
