using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BazarPapelaria10.Bibliotecas.Filtro;
using BazarPapelaria10.Bibliotecas.Login;
using BazarPapelaria10.Repositories.Contracts;
using Microsoft.AspNetCore.Mvc;

namespace BazarPapelaria10.Areas.Colaborador.Controllers
{
    [Area("Admin")]
    public class HomeController : Controller
    {
        private IColaboradorRepository _colaboradorRepository;
        private LoginColaborador _loginColaborador;

        public HomeController(IColaboradorRepository colaboradorRepository, LoginColaborador loginColaborador)
        {
            _colaboradorRepository = colaboradorRepository;
            _loginColaborador = loginColaborador;
        }

        [HttpGet]
        public IActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Login([FromForm] Models.Colaborador colaborador)
        {
            Models.Colaborador _colaboradorDB = _colaboradorRepository.Login(colaborador.Email, colaborador.Senha);

            if (_colaboradorDB != null)
            {
                // LOGAR
                _loginColaborador.Login(_colaboradorDB);

                return new RedirectResult(Url.Action(nameof(Painel)));
            }

            TempData["MSG_E"] = "Email ou senha inválidos, tente novamente.";

            return View();
        }

        [ColaboradorAutorizacao]
        [ValidadeHttpReferer]
        public IActionResult Logout()
        {
            _loginColaborador.Logout();
            return RedirectToAction("Login", "Home");
        }

        [ColaboradorAutorizacao]
        public IActionResult Painel()
        {
            return View();
        }

        public IActionResult RecuperarSenha()
        {
            return View();
        }

        public IActionResult CadastrarNovaSenha()
        {
            return View();
        }
    }
}