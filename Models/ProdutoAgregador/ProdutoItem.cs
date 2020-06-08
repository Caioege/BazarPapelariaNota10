using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BazarPapelaria10.Models.ProdutoAgregador
{
    public class ProdutoItem : Produto
    {
        //QUANITADE DE PRODUTOS NO CARRINHO
        public int QuantidadeProdutoCarrinho { get; set; }
    }
}
