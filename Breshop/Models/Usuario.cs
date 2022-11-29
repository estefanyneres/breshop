using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Breshop.Models
{
    public class Usuario
    {
        [Key]
        [Column("CD_USUARIO")]
        public int IdUsuario { get; set; }

        [Column("DS_EMAIL")]
        public string Email { get; set; }

        [Column("DS_SENHA")]
        public string Senha { get; set; }

    }
}
