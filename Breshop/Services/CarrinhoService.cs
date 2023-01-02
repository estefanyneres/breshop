using Breshop.Interfaces;
using Breshop.Models;
using System;
using System.Collections.Generic;

namespace Breshop.Services
{
    public class CarrinhoService : ICarrinhoService
    {
        private readonly ICarrinhoRepository _carrinhoRepository;

        public CarrinhoService(ICarrinhoRepository carrinhoRepository)
        {
            _carrinhoRepository = carrinhoRepository;
        }

        public bool AdicionarNoCarrinho(Produto produto, Usuario usuario)
        {
            throw new NotImplementedException();
        }

        public List<Produto> ObterProdutosCarrinhoPorIdUsuario(int IdUsuario)
        {
            try
            {
                if (IdUsuario != 0)
                {
                    _carrinhoRepository.ObterCarrinhoPorIdUsuario(IdUsuario);
                }

                return new List<Produto>();
            }
            catch (Exception ex)
            {
                return new List<Produto>();
            }
        }

        public bool RemoverDoCarrinho(Produto produto, Usuario usuario)
        {
            throw new NotImplementedException();
        }
    }
}
