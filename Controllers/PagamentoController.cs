using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using BazarPapelaria10.Bibliotecas.CarrinhoCompra;
using BazarPapelaria10.Bibliotecas.Cookie;
using BazarPapelaria10.Bibliotecas.Filtro;
using BazarPapelaria10.Controllers.Base;
using BazarPapelaria10.Models.ProdutoAgregador;
using BazarPapelaria10.Repositories.Contracts;
using Microsoft.AspNetCore.Mvc;

namespace BazarPapelaria10.Controllers
{
    public class PagamentoController : BaseController
    {
        private Cookie _cookie;

        public PagamentoController(CarrinhoCompra carrinhoCompra, IProdutoRepository produtoRepository, IMapper mapper, Cookie cookie)
            : base(carrinhoCompra, produtoRepository, mapper)
        {
            _cookie = cookie;
        }

        [ClienteAutorizacao]
        public IActionResult AtualizarEnderecoEntrega(int id)
        {
            _cookie.AddEnderecoEntrega(id);

            return RedirectToAction("Index", "Pagamento", new { area = "" });
        }

        [ClienteAutorizacao]
        public IActionResult Index(int id)
        {
            List<ProdutoItem> produtoItemCompleto = CarregarProdutoDB();

            return View(produtoItemCompleto);
        }
    }
}
