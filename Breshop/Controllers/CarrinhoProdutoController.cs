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

        public CarrinhoProdutoController(IProdutoService produtoService)
        {
            _produtoService = produtoService;
        }

        public IActionResult Index()
        {
            if (_usuarioAutenticado)
            {
                ViewData["RETORNO"] = _usuarioAutenticado;

                return View();
            }

            return RedirectToAction("Index" ,"Login");
        }

        public IActionResult Checkout()
        {
            if (_usuarioAutenticado)
            {
                List<Produto> produtos = _produtoService.ObterListaProdutosPorCategoria("Calcado");

                ViewData["RETORNO"] = _usuarioAutenticado;

                return View(produtos);
            }

            return RedirectToAction("Index" ,"Login");
        }
    }
}
