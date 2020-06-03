using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace BazarPapelaria10.Models
{
    public class Prodcateg
    {
        public int Id { get; set; }
        public DateTime Dtcriacao { get; set; }
        public DateTime Dtalteracao { get; set; }
        public int ProdutoCodProd { get; set; }
        [ForeignKey("ProdutoCodProd")]
        public virtual Produto Produto { get; set; }
        public int CategoriaCodCateg { get; set; }
        [ForeignKey("CategoriaCodCateg")]
        public virtual Categoria Categoria { get; set; }
    }
}
