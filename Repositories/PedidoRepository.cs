using BazarPapelaria10.Database;
using BazarPapelaria10.Models;
using BazarPapelaria10.Models.PedidoAgregador;
using BazarPapelaria10.Models.ProdutoAgregador;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using X.PagedList;

namespace BazarPapelaria10.Repositories.Contracts
{
    public class PedidoRepository : IPedidoRepository
    {
        private IConfiguration _conf;
        private BazarPapelaria10Context _banco;

        public PedidoRepository(BazarPapelaria10Context banco, IConfiguration configuration)
        {
            _banco = banco;
            _conf = configuration;
        }

        #region PEDIDO

        public void Atualizar(Pedido pedido)
        {
            pedido.DtAlteracao = System.DateTime.Now;
            _banco.Update(pedido);
            _banco.SaveChanges();
        }

        public void Cadastrar(PedidoAgregador pedido)
        {
            pedido.DtCriacao = System.DateTime.Now;
            pedido.DtAlteracao = System.DateTime.Now;

            _banco.Add(pedido);
            _banco.SaveChanges();
        }

        public void Excluir(int Id)
        {
            Pedido pedido = ObterPedido(Id);
            _banco.Remove(pedido);
            _banco.SaveChanges();
        }

        public Pedido ObterPedido(int Id)
        {
            return _banco.Pedido.Include(a => a.Pessoa).Where(a => a.Id == Id).FirstOrDefault();
        }

        public PedidoAgregador ObterPedidoPA(int Id)
        {
            //int numeroPagina = pagina ?? 1;
            PedidoAgregador pedido = new PedidoAgregador();

            //var pedido = _banco.Pedido.Include(a => a.Pessoa).Where(a => a.ClienteId == clienteId).ToPagedList<Pedido>(numeroPagina, _conf.GetValue<int>("RegistrosPorPagina"));

            return pedido;
        }

        public IPagedList<Pedido> ObterTodosPedidos(int? pagina, int clienteId)
        {
            int numeroPagina = pagina ?? 1;

            return _banco.Pedido.Include(a => a.Pessoa).Where(a => a.ClienteId == clienteId).ToPagedList<Pedido>(numeroPagina, _conf.GetValue<int>("RegistrosPorPagina"));
        }

        public IEnumerable<Pedido> ObterTodosPedidos()
        {
            return _banco.Pedido;
        }

        #endregion

        #region PEDIDOITEM
        public void Cadastrar(PedidoItem pedidoItem)
        {
            var existe = _banco.PedidoItem.Find(pedidoItem.Id);
            if (existe != null)
            {
                pedidoItem.Id += 1;
            }

            _banco.Add(pedidoItem);
            _banco.SaveChanges();
        }

        public void Cadastrar(List<PedidoItem> pedidoItem, int PedidoId)
        {
            if (pedidoItem != null && pedidoItem.Count > 0)
            {
                foreach (var pedido in pedidoItem)
                {
                    pedido.PedidoId = PedidoId;
                    this.Cadastrar(pedido);
                }
            }
        }

        public void ExcluirPedidoItem(int Id)
        {
            PedidoItem pedidoItem = _banco.PedidoItem.Find(Id);
            _banco.Remove(pedidoItem);
            _banco.SaveChanges();
        }

        #endregion

        public void Atualizar(Produto produto)
        {
            produto.Dtalteracao = System.DateTime.Now;
            _banco.Update(produto);
            _banco.SaveChanges();
        }
    }
}
