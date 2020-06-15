using BazarPapelaria10.Models.ProdutoAgregador;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace BazarPapelaria10.Models.PedidoAgregador
{
    public class PedidoItem
    {
        public int Id { get; set; }
        public int PedidoId { get; set; }

        [ForeignKey("PedidoId")]
        public virtual Pedido Pedido { get; set; }
        public int ProdutoId { get; set; }

        [ForeignKey("ProdutoId")]
        public virtual Produto Produto { get; set; }
        public Decimal ValorItemCompra { get; set; }
        public Decimal Quantidade { get; set; }
    }
}
