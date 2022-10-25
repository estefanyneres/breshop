
using Breshop.Intefaces;
using Breshop.Models;
using Breshop.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Breshop.Services
{
    public class UsuarioService : IUsuarioService
    {
        private readonly IUsuarioRepository _usuarioRepository;

        public UsuarioService(IUsuarioRepository usuarioRepository)
        {
            _usuarioRepository = usuarioRepository;
        }

        public bool ValidarUsuario(Usuario usuario)
        {
            try
            {
                bool usuarioExistente = _usuarioRepository.ValidarUsuario(usuario);

                return usuarioExistente;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
