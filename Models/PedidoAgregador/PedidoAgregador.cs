using BazarPapelaria10.Models.ProdutoAgregador;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BazarPapelaria10.Models.PedidoAgregador
{
    public class PedidoAgregador : Pedido
    {
        public List<ProdutoItem> produtos;
        public List<PedidoItem> pedidos;
    }
}
