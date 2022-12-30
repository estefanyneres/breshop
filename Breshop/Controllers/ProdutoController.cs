using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Breshop.Models;
using Breshop.Interfaces;

namespace Breshop.Controllers
{
    public class ProdutoController : BaseController
    {
        private readonly IProdutoService _produtoService;


        public ProdutoController(IProdutoService produtoService)
        {
            _produtoService = produtoService;
        }

        public async Task<IActionResult> Ofertas()
        {
            try
            {
                if (_usuarioAutenticado)
                {
                    List<Produto> produtos = _produtoService.ObterListaProdutosPorCategoria("Ofertas");

                    ViewData["RETORNO"] = _usuarioAutenticado;

                    return View(produtos);
                }

                return RedirectToAction("Index" ,"Login");
            }
            catch (Exception)
            {
                List<Produto> produtos = new List<Produto>();

                return View(produtos);
            }
        }

        public async Task<IActionResult> Calcado(int? id)
        {
            try
            {
                if (_usuarioAutenticado)
                {
                    List<Produto> produtos = _produtoService.ObterListaProdutosPorCategoria("Calcado");

                    ViewData["RETORNO"] = _usuarioAutenticado;

                    return View(produtos);
                }

                return RedirectToAction("Index" ,"Login");
            }
            catch (Exception)
            {
                List<Produto> produtos = new List<Produto>();

                return View(produtos);
            }
        }

        public async Task<IActionResult> Feminino(int? id)
        {
            try
            {
                if (_usuarioAutenticado)
                {
                    List<Produto> produtos = _produtoService.ObterListaProdutosPorCategoria("Feminino");

                    ViewData["RETORNO"] = _usuarioAutenticado;

                    return View(produtos);
                }

                return RedirectToAction("Index" ,"Login");
            }
            catch (Exception)
            {
                List<Produto> produtos = new List<Produto>();

                return View(produtos);
            }
        }

        public async Task<IActionResult> Masculino(int? id)
        {
            try
            {
                if (_usuarioAutenticado)
                {
                    List<Produto> produtos = _produtoService.ObterListaProdutosPorCategoria("Masculino");

                    ViewData["RETORNO"] = _usuarioAutenticado;

                    return View(produtos);
                }

                return RedirectToAction("Index" ,"Login");
            }
            catch (Exception)
            {
                List<Produto> produtos = new List<Produto>();

                return View(produtos);
            }
        }

        public async Task<IActionResult> Acessorio(int? id)
        {
            try
            {
                if (_usuarioAutenticado)
                {
                    List<Produto> produtos = _produtoService.ObterListaProdutosPorCategoria("Acessorio");

                    ViewData["RETORNO"] = _usuarioAutenticado;

                    return View(produtos);
                }

                return RedirectToAction("Index" ,"Login");
            }
            catch (Exception)
            {
                List<Produto> produtos = new List<Produto>();

                return View(produtos);
            }
        }

        public IActionResult Error(int? id)
        {
            return NotFound();
        }
    }
}
