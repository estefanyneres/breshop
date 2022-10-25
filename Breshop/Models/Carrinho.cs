using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Breshop.Models
{
    public class Carrinho
    {
        [Key]
        public int IdCarrinho { get; set; }

        [ForeignKey("IdProduto")]
        public int IdProduto { get; set; }

        public Decimal Valor { get; set; }

        public int Quantidade { get; set; }

        public string MetodoPagamento { get; set; }
    }
}
