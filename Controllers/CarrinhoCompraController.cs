﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using BazarPapelaria10.Bibliotecas;
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
        private IMapper _mapper;

        public CarrinhoCompraController(CarrinhoCompra carrinhoCompra, IProdutoRepository produtoRepository, IMapper mapper)
        {
            _carrinhoCompra = carrinhoCompra;
            _produtoRepository = produtoRepository;
            _mapper = mapper;
        }

        public IActionResult Index()
        {
            List<ProdutoItem> produtoItemCarrinho = _carrinhoCompra.Consultar();

            List<ProdutoItem> produtoItemCompleto = new List<ProdutoItem>();

            foreach (var item in produtoItemCarrinho)
            {
                Produto produto = _produtoRepository.ObterProduto(item.Id);

                ProdutoItem produtoItem = _mapper.Map<ProdutoItem>(produto);
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
    }
}
