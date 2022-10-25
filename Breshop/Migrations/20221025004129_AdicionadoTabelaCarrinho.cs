using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Breshop.Migrations
{
    public partial class AdicionadoTabelaCarrinho : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Sexo",
                table: "Produto");

            migrationBuilder.AddColumn<string>(
                name: "Senha",
                table: "Usuario",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "Carrinho",
                columns: table => new
                {
                    IdCarrinho = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    IdProduto = table.Column<int>(nullable: false),
                    Valor = table.Column<decimal>(nullable: false),
                    Quantidade = table.Column<int>(nullable: false),
                    MetodoPagamento = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Carrinho", x => x.IdCarrinho);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Carrinho");

            migrationBuilder.DropColumn(
                name: "Senha",
                table: "Usuario");

            migrationBuilder.AddColumn<string>(
                name: "Sexo",
                table: "Produto",
                nullable: true);
        }
    }
}
