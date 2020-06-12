using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using BazarPapelaria10.Models;
using BazarPapelaria10.Repositories.Contracts;
using BazarPapelaria10.Models.ViewModels;
using BazarPapelaria10.Database;
using BazarPapelaria10.Repositories;
using Microsoft.AspNetCore.Http;
using BazarPapelaria10.Bibliotecas.Login;
using BazarPapelaria10.Bibliotecas.Filtro;
using BazarPapelaria10.Models.ProdutoAgregador;

namespace BazarPapelaria10.Controllers
{
    public class HomeController : Controller
    {
        
        private IProdutoRepository _produtoRepository;
        private BazarPapelaria10Context _banco;

        public HomeController(IProdutoRepository produtoRepository)
        {
            _produtoRepository = produtoRepository;
        }

        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public IActionResult Pesquisa()
        {
            
            return View();
        }

        

        public IActionResult Contato()
        {
            return View();
        }

        public IActionResult Carrinho()
        {
            return View();
        }

        [HttpGet]
        public IActionResult Categoria()
        {
            return View();
        }

        [HttpPost]
        public IActionResult PegaCodProduto(Produto produto, string slug)
        {
            var _produto = new Produto
            {
                Id = produto.Id,
                Nomeprod = produto.Nomeprod,
                Descprod = produto.Descprod,
                Valorprod = produto.Valorprod,
                Imagens = produto.Imagens
            };

            ViewBag["Produto"] = _produto;

            return View();
        }

        public IActionResult Produto(string slug)
        {

            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
