using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using BazarPapelaria10.Bibliotecas;
using BazarPapelaria10.Bibliotecas.CarrinhoCompra;
using BazarPapelaria10.Bibliotecas.Filtro;
using BazarPapelaria10.Bibliotecas.Login;
using BazarPapelaria10.Controllers.Base;
using BazarPapelaria10.Models;
using BazarPapelaria10.Models.ProdutoAgregador;
using BazarPapelaria10.Repositories.Contracts;
using Microsoft.AspNetCore.Mvc;

namespace BazarPapelaria10.Controllers
{
    public class CarrinhoCompraController : BaseController
    {
        private LoginCliente _loginCliente;
        private IEnderecoEntregaRepository _enderecoEntregaRepository;

        public CarrinhoCompraController(LoginCliente loginCliente, IEnderecoEntregaRepository enderecoEntregaRepository , CarrinhoCompra carrinhoCompra, IProdutoRepository produtoRepository, IMapper mapper) 
            : base (carrinhoCompra,
                  produtoRepository,
                  mapper){
            _loginCliente = loginCliente;
            _enderecoEntregaRepository = enderecoEntregaRepository;
        }

        public IActionResult Index()
        {
            List<ProdutoItem> produtoItemCompleto = CarregarProdutoDB();

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

        [HttpGet]
        public IActionResult AlterarQuantidade(int id, int quantidade)
        {
            Produto produto = _produtoRepository.ObterProduto(id);

            if (quantidade < 1)
            {
                return BadRequest(new { mensagem = Mensagem.MSG_E007 });
            }else if (quantidade > produto.Quantidade)
            {
                return BadRequest(new { mensagem = Mensagem.MSG_E008 });
            }
            else
            {
                var item = new ProdutoItem() { Id = id, QuantidadeProdutoCarrinho = quantidade };
                _carrinhoCompra.Atualizar(item);

                return Ok(new { mensagem = Mensagem.MSG_S001 });
            }
        }

        public IActionResult RemoverItem(int Id)
        {
            _carrinhoCompra.Remover(new ProdutoItem() { Id = Id } );
            return RedirectToAction(nameof(Index));
        }

        [ClienteAutorizacao]
        public IActionResult EnderecoEntrega()
        {
            Pessoa cliente = _loginCliente.GetCliente();
            IList<EnderecoEntrega> enderecos = _enderecoEntregaRepository.ObterTodosEnderecosEntregaCliente(cliente.Id);

            ViewBag.Cliente = cliente;
            ViewBag.Enderecos = enderecos;

            return View();
        }

        [ClienteAutorizacao]
        public IActionResult AtualizarEnderecoEntrega(int id)
        {


            return RedirectToAction("Index", "Pagamento", new { area = "" });
        }

    }
}
