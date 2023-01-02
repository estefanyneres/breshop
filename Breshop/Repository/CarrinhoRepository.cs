using Breshop.Interfaces;
using Breshop.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Breshop.Repository
{
    public class CarrinhoRepository : ICarrinhoRepository
    {
        private readonly BreshopContext _context;

        public CarrinhoRepository(BreshopContext context)
        {
            _context = context;
        }

        public bool AdicionarNoCarrinho(Produto produto, Usuario usuario)
        {
            try
            {
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        public Carrinho ObterCarrinhoPorIdUsuario(int IdUsuario)
        {
            try
            {
                return _context.Carrinho.FirstOrDefault(x => x.IdUsuario == IdUsuario && x.CarrinhoDisponivel);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public bool RemoverDoCarrinho(Produto produto, Usuario usuario)
        {
            try
            {
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }
    }
}
