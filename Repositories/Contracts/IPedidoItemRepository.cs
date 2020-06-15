using BazarPapelaria10.Models.PedidoAgregador;
using BazarPapelaria10.Models.ProdutoAgregador;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BazarPapelaria10.Repositories.Contracts
{
    public interface IPedidoItemRepository
    {
        void Cadastrar(PedidoItem pedidoItem);
        void Cadastrar(List<PedidoItem> pedidoItem, int PedidoId);
        void Excluir(int Id);
        //void AlterarQuantidadeProduto(Produto produto, List<PedidoItem> itens);
    }
}
