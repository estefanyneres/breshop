using Breshop.Models;
using System.Collections.Generic;

namespace Breshop.Interfaces
{
    public interface ICarrinhoRepository
    {
        bool AdicionarNoCarrinho(Produto produto, Usuario usuario);

        bool RemoverDoCarrinho(Produto produto, Usuario usuario);

        Carrinho ObterCarrinhoPorIdUsuario(int IdUsuario);
    }
}
