using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BazarPapelaria10.Bibliotecas.CarrinhoCompra;
using BazarPapelaria10.Models;
using BazarPapelaria10.Models.ProdutoAgregador;
using BazarPapelaria10.Repositories.Contracts;
using Microsoft.AspNetCore.Mvc;

namespace BazarPapelaria10.Controllers
{
    public class CarrinhoCompraController : Controller
    {
        private CarrinhoCompra _carrinhoCompra;
        private IProdutoRepository _produtoRepository;

        public CarrinhoCompraController(CarrinhoCompra carrinhoCompra, IProdutoRepository produtoRepository)
        {
            _carrinhoCompra = carrinhoCompra;
            _produtoRepository = produtoRepository;
        }

        public IActionResult Index()
        {
            List<ProdutoItem> produtoItemCarrinho = _carrinhoCompra.Consultar();

            List<ProdutoItem> produtoItemCompleto = new List<ProdutoItem>();

            foreach(var item in produtoItemCarrinho)
            {
                Produto produto = _produtoRepository.ObterProduto(item.Id);
                ProdutoItem produtoItem = new ProdutoItem();
                produtoItem.Id = produto.Id;
                produtoItem.Nomeprod = produto.Nomeprod;
                produtoItem.Imagens = produto.Imagens;
                produtoItem.Valorprod = produto.Valorprod;
                produtoItem.QuantidadeProdutoCarrinho = item.QuantidadeProdutoCarrinho;

                produtoItemCompleto.Add(produtoItem);
            }

            return View(produtoItemCompleto);
        }

        public IActionResult AdicionarItem(int Id)
        {
            Produto produto = _produtoRepository.ObterProduto(Id);

            if(produto == null)
            {
                return View("NaoExisteItem");
            }
            else
            {
                var item = new ProdutoItem() { Id = Id, QuantidadeProdutoCarrinho = 1 };
                _carrinhoCompra.Cadastrar(item);
            }

            return RedirectToAction(nameof(Index));
        }

        public IActionResult AlterarQuantidade(int Id, int Quantidade)
        {
            var item = new ProdutoItem() { Id = Id, QuantidadeProdutoCarrinho = Quantidade };
            _carrinhoCompra.Atualizar(item);

            return RedirectToAction(nameof(Index));
        }

        public IActionResult RemoverItem(int Id)
        {
            _carrinhoCompra.Remover(new ProdutoItem() { Id = Id } );
            return RedirectToAction(nameof(Index));
        }
    }
}
