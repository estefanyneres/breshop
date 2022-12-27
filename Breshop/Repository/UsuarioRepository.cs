using Breshop.Interfaces;
using Breshop.Models;
using System;
using System.Security.Cryptography;
using System.Text;

namespace Breshop.Services
{
    public class UsuarioRepository : IUsuarioRepository
    {
        public UsuarioRepository()
        {

        }

        public Usuario ObterCredenciais(int idUsuario)
        {
            try
            {
                return new Usuario
                {
                    Email = "cicero",
                    Senha = "64dbe645fc88e703210ae9b008668f52",
                };
            }
            catch
            {
                return new Usuario();
            }
        }
    }
}
