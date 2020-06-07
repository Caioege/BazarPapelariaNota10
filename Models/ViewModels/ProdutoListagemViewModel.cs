using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using X.PagedList;

namespace BazarPapelaria10.Models.ViewModels
{
    public class ProdutoListagemViewModel
    {
        public IPagedList<Produto> lista { get; set; }

        public Pessoa pessoa { get; set; }

        public List<SelectListItem> ordenacao
        {
            get
            {
                return new List<SelectListItem>()
                {
                    new SelectListItem("Alfabética", "A"),
                    new SelectListItem("Menor preço", "ME"),
                    new SelectListItem("Maior preço", "MA")
                };
            }
            private set { }
        }
    }
}
