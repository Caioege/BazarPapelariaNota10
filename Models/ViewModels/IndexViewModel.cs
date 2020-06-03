using X.PagedList;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BazarPapelaria10.Models.ViewModels
{
    public class IndexViewModel
    {
        public IPagedList<Produto> lista { get; set; }

        public Pessoa pessoa { get; set; }
    }
}
