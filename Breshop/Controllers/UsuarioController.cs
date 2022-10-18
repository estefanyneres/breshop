using System;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Breshop.Models;

namespace Breshop.Controllers
{
    public class UsuarioController : Controller
    {

        public UsuarioController()
        {
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

        public async Task<IActionResult> LogarUsuario()
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
    }
}
