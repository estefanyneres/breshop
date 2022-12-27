using Breshop.Models;

namespace Breshop.Interfaces
{
    public interface IUsuarioService
    {
        bool ValidaCredenciais(Usuario usuario);
    }
}
