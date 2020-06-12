using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BazarPapelaria10.Models.ProdutoAgregador
{
    public class ProdutoItem : Produto
    {
        //QUANTITADE DE PRODUTOS NO CARRINHO
        public int QuantidadeProdutoCarrinho { get; set; }
        public int IdEntrega { get; set; }
    }
}
