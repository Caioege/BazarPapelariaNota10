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
        private LoginCliente _loginCliente;
        private IPessoaRepository _pessoaRepository;
        private IProdutoRepository _produtoRepository;
        private BazarPapelaria10Context _banco;

        public HomeController(IPessoaRepository pessoaRepository, IProdutoRepository produtoRepository, LoginCliente loginCliente)
        {
            _pessoaRepository = pessoaRepository;
            _produtoRepository = produtoRepository;
            _loginCliente = loginCliente;
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

        [HttpGet]
        public IActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Login([FromForm] Pessoa pessoa)
        {
            Pessoa cliente = _pessoaRepository.Login(pessoa.Email, pessoa.Senha);

            if (cliente != null)
            {
                // LOGAR
                _loginCliente.Login(cliente);

                return new RedirectResult(Url.Action(nameof(Painel)));
            }

            TempData["MSG_E"] = "Email ou senha inválidos, tente novamente.";

            return View();
        }

        [ClienteAutorizacaoAttribute]
        public IActionResult Painel()
        {
            return new ContentResult() { Content = "Painel" };
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
        public IActionResult CadastroCliente()
        {
            return View();
        }

        [HttpPost]
        public IActionResult CadastroCliente([FromForm] Pessoa pessoa)
        {
            if(ModelState.IsValid)
            {
                _pessoaRepository.Cadastrar(pessoa);

                TempData["MSG_S"] = "Cadastro realizado com sucesso!";

                //TODO - USUARIO, PAINEL, CARRINHO E ETC

                return RedirectToAction(nameof(CadastroCliente));
            }

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
