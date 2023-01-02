using Breshop.Models;
using System.Collections.Generic;

namespace Breshop.Interfaces
{
    public interface ICarrinhoService
    {
        bool AdicionarNoCarrinho(Produto produto, Usuario usuario);

        bool RemoverDoCarrinho(Produto produto, Usuario usuario);

        List<Produto> ObterProdutosCarrinhoPorIdUsuario (int IdUsuario);
    }
}
