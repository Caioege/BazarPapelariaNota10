using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BazarPapelaria10.Models.PedidoAgregador
{
    public class Agregador
    {
        public Pedido pedido;
        public Pessoa cliente;
        public EnderecoEntrega enderecos;
        public List<PedidoItem> itens;
    }
}
