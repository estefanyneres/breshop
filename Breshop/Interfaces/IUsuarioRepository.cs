using Breshop.Models;

namespace Breshop.Interfaces
{
    public interface IUsuarioRepository
    {
        Usuario ObterCredenciais(int idUsuario);
    }
}
