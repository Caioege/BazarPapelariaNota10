using BazarPapelaria10.Models.PedidoAgregador;
using BazarPapelaria10.Models.ProdutoAgregador;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace BazarPapelaria10.Models
{
    public class Pedido
    {
        public int Id { get; set; }
        public int ClienteId { get; set; }

        [ForeignKey("ClienteId")]
        public virtual Pessoa Pessoa { get; set; }
        public int EnderecoEntregaId { get; set; }

        [ForeignKey("EnderecoEntregaId")]
        public virtual EnderecoEntrega EnderecoEntrega { get; set; }
        public int Pagamento { get; set; }
        public decimal ValorTotal { get; set; }
        public int Status { get; set; }
        public DateTime DtCriacao { get; set; }
        public DateTime DtAlteracao { get; set; }

        [NotMapped]
        public virtual List<PedidoItem> Itens { get; set; }

    }
}
