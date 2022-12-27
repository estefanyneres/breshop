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
            return View();
        }

        public IActionResult Checkout()
        {
            return View();
        }
    }
}
