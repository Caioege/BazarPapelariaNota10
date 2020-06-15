using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BazarPapelaria10.Models.Constants
{
    public class StatusPedidoConstant
    {
        public string DescStatus { get; set; }
        public int Id { get; set; }

        public StatusPedidoConstant()
        {

        }

        public StatusPedidoConstant(string DescStatusN, int IdN)
        {
            DescStatus = DescStatusN;
            Id = IdN;
        }

        public List<StatusPedidoConstant> GetStatus()
        {
            List<StatusPedidoConstant> status = new List<StatusPedidoConstant>();
            status.Add(new StatusPedidoConstant("Solicitado", 0));
            status.Add(new StatusPedidoConstant("Em análise", 1));
            status.Add(new StatusPedidoConstant("Em preparação", 2));
            status.Add(new StatusPedidoConstant("Aguardando Pagamento", 3));
            status.Add(new StatusPedidoConstant("Saiu para entrega", 4));
            status.Add(new StatusPedidoConstant("Entregue", 5));
            status.Add(new StatusPedidoConstant("Cancelado", 6));

            return status;
        }
    }
}
