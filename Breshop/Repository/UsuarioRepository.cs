using Breshop.Intefaces;
using Breshop.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Breshop.Repository
{
    public class UsuarioRepository : IUsuarioRepository
    {
        private readonly BreshopContext _context;

        public UsuarioRepository(BreshopContext context)
        {
            _context = context;
        }

        public bool ValidarUsuario(Usuario usuario)
        {
            Usuario usuarioExistente = _context.Usuario.FirstOrDefault(x => x.IdUsuario == usuario.IdUsuario);
            try
            {
                if (usuarioExistente != null)
                {
                    return true;
                }

                return false; 

            }
            catch (Exception)
            {
                return false;
            }
        }

    }
}
