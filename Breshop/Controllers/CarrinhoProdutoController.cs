using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Breshop.Models;
using Breshop.Interfaces;

namespace Breshop.Controllers
{
    public class CarrinhoProdutoController : BaseController
    {
        private readonly IProdutoService _produtoService;
        private readonly ICarrinhoService _carrinhoService;

        public CarrinhoProdutoController(IProdutoService produtoService, ICarrinhoService carrinhoService)
        {
            _produtoService = produtoService;
            _carrinhoService = carrinhoService;
        }

        public IActionResult Index()
        {
            if (_usuarioAutenticado)
            {
                ViewData["RETORNO"] = _usuarioAutenticado;
                ViewData["IDUSUARIO"] = _IdUsuario;

                return View();
            }

            return RedirectToAction("Index", "Login");
        }

        public IActionResult Checkout(int idUsuario)
        {
            if (_usuarioAutenticado)
            {
                List<Produto> produtos = _carrinhoService.ObterProdutosCarrinhoPorIdUsuario(idUsuario);

                ViewData["RETORNO"] = _usuarioAutenticado;
                ViewData["IDUSUARIO"] = _IdUsuario;

                return View(produtos);
            }

            return RedirectToAction("Index", "Login");
        }

        public void AdicionarProdutoCarrinho([FromRoute] int idUsuario, [FromRoute] int idProduto)
        {
            if (_usuarioAutenticado)
            {
                List<Produto> produtos = _carrinhoService.ObterProdutosCarrinhoPorIdUsuario(idUsuario);

                ViewData["RETORNO"] = _usuarioAutenticado;
                ViewData["IDUSUARIO"] = _IdUsuario;
            }
        }
    }
}
