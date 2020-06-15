using BazarPapelaria10.Database;
using BazarPapelaria10.Models.PedidoAgregador;
using BazarPapelaria10.Models.ProdutoAgregador;
using BazarPapelaria10.Repositories.Contracts;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BazarPapelaria10.Repositories
{
    public class PedidoItemRepository : IPedidoItemRepository
    {
        private BazarPapelaria10Context _banco;

        public PedidoItemRepository(BazarPapelaria10Context banco)
        {
            _banco = banco;
        }

        public void Cadastrar(PedidoItem pedidoItem)
        {
            var ultimoId = _banco.PedidoItem.LastOrDefault();

            if (ultimoId != null)
            {
                if (ultimoId.Id >= pedidoItem.Id)
                {
                    pedidoItem.Id = ultimoId.Id + 1;
                }
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

        public void Excluir(int Id)
        {
            PedidoItem pedidoItem = _banco.PedidoItem.Find(Id);
            _banco.Remove(pedidoItem);
            _banco.SaveChanges();
        }

        //    public void AlterarQuantidadeProduto(Produto produto, List<PedidoItem> pedidoItem)
        //    {

        //        if (pedidoItem != null && pedidoItem.Count > 0)
        //        {
        //            foreach (var pedido in pedidoItem)
        //            {
        //                var ultimoId = _banco.PedidoItem.LastOrDefault();

        //                if (ultimoId != null)
        //                {
        //                    if (ultimoId.Id >= pedido.Id)
        //                    {
        //                        pedido.Id = ultimoId.Id + 1;
        //                    }
        //                }

        //                produto.Dtalteracao = System.DateTime.Now;
        //                produto.Id = produto.Id;

        //                _banco.Update(produto);
        //                _banco.SaveChanges();
        //            }
        //        }
        //    //}
    }
}
