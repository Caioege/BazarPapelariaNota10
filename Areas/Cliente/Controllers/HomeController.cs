using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BazarPapelaria10.Bibliotecas.Filtro;
using BazarPapelaria10.Bibliotecas.Login;
using BazarPapelaria10.Models;
using BazarPapelaria10.Repositories;
using BazarPapelaria10.Repositories.Contracts;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.Metadata.Internal;

namespace BazarPapelaria10.Areas.Cliente.Controllers
{
    [Area("Cliente")]
    public class HomeController : Controller
    {
        private LoginCliente _loginCliente;
        private IPessoaRepository _pessoaRepository;
        private IEnderecoEntregaRepository _enderecoEntregaRepository;

        public HomeController(IPessoaRepository pessoaRepository, LoginCliente loginCliente, IEnderecoEntregaRepository enderecoEntregaRepository)
        {
            _pessoaRepository = pessoaRepository;
            _loginCliente = loginCliente;
            _enderecoEntregaRepository = enderecoEntregaRepository;
        }

        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public IActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Login([FromForm] Models.Pessoa pessoa, string returnUrl = null)
        {
            Pessoa cliente = _pessoaRepository.Login(pessoa.Email, pessoa.Senha);

            if (cliente != null)
            {
                // LOGAR
                _loginCliente.Login(cliente);

                if (returnUrl == null)
                {
                    return RedirectToAction("Index", "Home", new { area = "" });
                }
                else
                {
                    return LocalRedirectPermanent(returnUrl);
                }
            }

            TempData["MSG_E"] = "Email ou senha inválidos, tente novamente.";

            return View();
        }

        [ClienteAutorizacaoAttribute]
        public IActionResult Painel()
        {
            return new ContentResult() { Content = "Painel" };
        }

        [HttpGet]
        public IActionResult CadastroCliente()
        {
            return View();
        }

        [HttpPost]
        public IActionResult CadastroCliente([FromForm] Models.Pessoa pessoa, string returnUrl = null)
        {
            if (ModelState.IsValid)
            {
                _pessoaRepository.Cadastrar(pessoa);
                _loginCliente.Login(pessoa);

                TempData["MSG_S"] = "Cadastro realizado com sucesso!";

                if (returnUrl == null)
                {
                    return RedirectToAction("Index", "Home", new { area = "" });
                }
                else
                {
                    return LocalRedirectPermanent(returnUrl);
                }
            }

            return View();
        }

        [HttpGet]
        [ClienteAutorizacao]
        public IActionResult CadastroEnderecoEntrega()
        {
            return View();
        }

        [HttpPost]
        [ClienteAutorizacao]
        public IActionResult CadastroEnderecoEntrega([FromForm] EnderecoEntrega enderecoEntrega, string returnUrl = null)
        {
            if (ModelState.IsValid)
            {
                enderecoEntrega.PessoaId = _loginCliente.GetCliente().Id;

                _enderecoEntregaRepository.Cadastrar(enderecoEntrega);

                if (returnUrl == null)
                {

                }
                else
                {
                    return LocalRedirectPermanent(returnUrl);
                }
            }

            return View();
        }

        public IActionResult Sair()
        {
            _loginCliente.Logout();

            return RedirectToAction("Index", "Home", new { area = "" });
        }
    }
}
