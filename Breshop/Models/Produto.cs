using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Breshop.Models
{
    public class Produto
    {
        [Key]
        [Column("CD_PRODUTO")]
        public int IdProduto { get; set; }

        [Column("DS_DESCRICAO")]
        public string Descricao { get; set; }

        [Column("DS_TAMANHO")]
        public string Tamanho { get; set; }
        
        [Column("VL_TAMANHO")]
        public double Preco { get; set; }

        [Column("NM_MARCA")]
        public string Marca { get; set; }
        
        [Column("NM_CATEGORIA")]
        public string Categoria { get; set; }

        [Column("DS_URL_IMAGEM")]
        public string UrlImagem { get; set; }

        [Column("IC_STATUS_PRODUTO")]
        public string StatusProduto { get; set; }

        [NotMapped]
        public IFormFile Imagem { get; set; }
    }
}
