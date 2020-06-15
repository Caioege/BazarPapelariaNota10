using BazarPapelaria10.Models;
using BazarPapelaria10.Models.PedidoAgregador;
using BazarPapelaria10.Models.ProdutoAgregador;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using X.PagedList;

namespace BazarPapelaria10.Repositories.Contracts
{
    public interface IPedidoRepository
    {
        void Cadastrar(PedidoAgregador pedido);
        void Atualizar(Pedido pedido);
        void Excluir(int Id);
        Pedido ObterPedido(int Id);
        Agregador VisualizarPedido(int Id);
        IEnumerable<Pedido> ObterTodosPedidos();
        IPagedList<Pedido> ObterTodosPedidos(int? pagina, int clienteId);
        IPagedList<Pedido> ObterTodosPedidos(int? pagina);

        void Cadastrar(PedidoItem pedidoItem);
        void Cadastrar(List<PedidoItem> pedidoItem, int PedidoId);
        void ExcluirPedidoItem(int Id);

        void Atualizar(Produto produto);
    }
}
