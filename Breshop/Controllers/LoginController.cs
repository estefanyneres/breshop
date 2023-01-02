using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;
using Breshop.Models;
using System.Threading.Tasks;
using Breshop.Interfaces;
using System;

namespace Breshop.Controllers
{
    public class LoginController : BaseController
    {
        private readonly IUsuarioService _usuarioService;

        public LoginController(IUsuarioService usuarioService)
        {
            _usuarioService = usuarioService;
        }

        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public async Task<JsonResult> AutenticarUsuario(Usuario usuario)
        {
            _usuarioAutenticado = _usuarioService.ValidaCredenciais(usuario);

            if (_usuarioAutenticado)
            {
                _IdUsuario = _usuarioService.SetarUsuario(usuario.IdUsuario);
                return Json(JsonConvert.SerializeObject(new { autenticado = "true", message = $"Usuario autenticado com sucesso." }));
            }

            return Json(JsonConvert.SerializeObject(new { autenticado = "false", message = $"Credenciais inválidas." }));
        }
    }
}
