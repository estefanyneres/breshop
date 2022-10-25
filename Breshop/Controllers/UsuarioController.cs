using System;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Breshop.Models;
using Breshop.Intefaces;

namespace Breshop.Controllers
{
    public class UsuarioController : Controller
    {
        private readonly IUsuarioService _usuarioService;

        public UsuarioController(IUsuarioService produtoService)
        {
            _usuarioService = produtoService;
        }

        public async Task<IActionResult> Login()
        {
            try
            {
                Usuario usuario = new Usuario();

                return View(usuario);
            }
            catch (Exception)
            {
                Usuario usuario = new Usuario();

                return View(usuario);
            }
        }

        public async Task<IActionResult> LogarUsuario(Usuario usuario)
        {
            try
            {
                bool usuarioExistente = _usuarioService.ValidarUsuario(usuario);

                return View(usuario);
            }
            catch (Exception)
            {
                return View(usuario);
            }
        }
    }
}
