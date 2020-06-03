using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace BazarPapelaria10.Models
{
    public class Imagem
    {
        public int Id { get; set; }
        public string Caminho { get; set; }
        
        public int ProdutoCodprod { get; set; }
        [ForeignKey("ProdutoCodprod")]
        public virtual Produto Produto { get; set; }
    }
}
