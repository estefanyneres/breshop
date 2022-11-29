using Microsoft.EntityFrameworkCore.Migrations;

namespace Breshop.Migrations
{
    public partial class AleterandoTabUsuario : Migration
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
                name: "Sexo",
                table: "Produto");

            migrationBuilder.RenameColumn(
                name: "Email",
                table: "Usuario",
                newName: "DS_EMAIL");

            migrationBuilder.RenameColumn(
                name: "IdUsuario",
                table: "Usuario",
                newName: "CD_USUARIO");

            migrationBuilder.RenameColumn(
                name: "Nome",
                table: "Usuario",
                newName: "DS_SENHA");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "DS_EMAIL",
                table: "Usuario",
                newName: "Email");

            migrationBuilder.RenameColumn(
                name: "CD_USUARIO",
                table: "Usuario",
                newName: "IdUsuario");

            migrationBuilder.RenameColumn(
                name: "DS_SENHA",
                table: "Usuario",
                newName: "Nome");

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
                name: "Sexo",
                table: "Produto",
                nullable: true);
        }
    }
}
