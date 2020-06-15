using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using BazarPapelaria10.Bibliotecas.CarrinhoCompra;
using BazarPapelaria10.Bibliotecas.Cookie;
using BazarPapelaria10.Bibliotecas.Filtro;
using BazarPapelaria10.Bibliotecas.Login;
using BazarPapelaria10.Controllers.Base;
using BazarPapelaria10.Models;
using BazarPapelaria10.Models.PedidoAgregador;
using BazarPapelaria10.Models.ProdutoAgregador;
using BazarPapelaria10.Repositories.Contracts;
using Microsoft.AspNetCore.Mvc;

namespace BazarPapelaria10.Controllers
{
    [ClienteAutorizacao]
    public class PagamentoController : BaseController
    {
        private Cookie _cookie;
        private LoginCliente _loginCliente;
        private IPedidoRepository _pedidoRepository;
        private IPedidoItemRepository _pedidoItemRepository;

        public PagamentoController(Cookie cookie,
            LoginCliente loginCliente,
            IPedidoRepository pedidoRepository,
            IPedidoItemRepository pedidoItemRepository,
            CarrinhoCompra carrinhoCompra,
            IProdutoRepository produtoRepository,
            IMapper mapper)
            : base (carrinhoCompra,
                  produtoRepository,
                  mapper)
        {
            _cookie = cookie;
            _loginCliente = loginCliente;
            _loginCliente = loginCliente;
            _pedidoRepository = pedidoRepository;
            _pedidoItemRepository = pedidoItemRepository;
        }

        [ClienteAutorizacao]
        [HttpGet]
        public IActionResult Index(int id)
        {
            List<ProdutoItem> produtoItemCompleto = CarregarProdutoDB();

            PedidoAgregador prepedido = new PedidoAgregador();
            prepedido.produtos = produtoItemCompleto;

            return View(prepedido);
        }

        [ClienteAutorizacao]
        [HttpPost]
        public IActionResult Index([FromForm] PedidoAgregador pedido)
        {
            if(ModelState.IsValid)
            {
                var clienteId = _loginCliente.GetCliente().Id;

                List<ProdutoItem> produtoItemCompleto = CarregarProdutoDB();
                pedido.produtos = produtoItemCompleto;

                pedido.ClienteId = clienteId;

                return AdicionarPedido(pedido);
            }

            return RedirectToAction("Painel", "Home", new { area = "Cliente" } );
        }

        private decimal ObterValorTotalCompra(List<ProdutoItem> produtos)
        {
            decimal total = 0;

            foreach (var produto in produtos)
            {
                total += produto.Valorprod;
            }

            return total;
        }

        private List<PedidoItem> AdicionarProdutos(int idPedido)
        {
            var produtoItemCompleto = CarregarProdutoDB();

            List<PedidoItem> pedidoItem = new List<PedidoItem>();
            foreach (var item in produtoItemCompleto)
            {
                PedidoItem pedidoTemp = new PedidoItem();
                pedidoTemp.Id = idPedido;
                pedidoTemp.ProdutoId = item.Id;
                pedidoTemp.Quantidade = item.QuantidadeProdutoCarrinho;
                pedidoTemp.ValorItemCompra = item.Valorprod;

                pedidoItem.Add(pedidoTemp);
            }

            return pedidoItem;
        }

        //private void AlteraQuantidade(List<PedidoItem> pedidoItem)
        //{
        //    var produtoItemCompleto = CarregarProdutoDB();

        //    //ALTERAR QUANTIDADE PRODUTO
        //    foreach (var item in produtoItemCompleto)
        //    {
        //        item.Quantidade -= item.QuantidadeProdutoCarrinho;

        //        Produto produto = new Produto();
        //        produto = item;

        //        _pedidoItemRepository.AlterarQuantidadeProduto(produto, pedidoItem);
        //    }
        //}

        public IActionResult AdicionarPedido(PedidoAgregador pedido)
        {

            var clienteId = _loginCliente.GetCliente().Id;

            List<ProdutoItem> produtoItemCompleto = CarregarProdutoDB();
            pedido.produtos = produtoItemCompleto;

            pedido.ClienteId = clienteId;
            _pedidoRepository.Cadastrar(pedido);


            return AdicionarItens(pedido.Id);
        }

        public IActionResult AdicionarItens(int Id)
        {
            var itens = AdicionarProdutos(Id);
            _pedidoItemRepository.Cadastrar(itens, Id);

            _carrinhoCompra.RemoverTodos();

            TempData["MSG_S"] = "Pedido cadastrado com sucesso!";

            return RedirectToAction("Index", "CarrinhoCompra", new { area = "" });
        }

        //public IActionResult AlterarQuantidade(List<PedidoItem> itens)
        //{
        //    this.AlteraQuantidade(itens);

        //    return RedirectToActionPermanent("Index", "Home", new { area = "" });
        //}
    }
}
