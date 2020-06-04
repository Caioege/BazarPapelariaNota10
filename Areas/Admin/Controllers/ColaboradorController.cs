using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BazarPapelaria10.Bibliotecas.Filtro;
using BazarPapelaria10.Models.Constants;
using BazarPapelaria10.Repositories.Contracts;
using Microsoft.AspNetCore.Mvc;
using X.PagedList;

namespace BazarPapelaria10.Areas.Colaborador.Controllers
{
    [Area("Admin")]
    [ColaboradorAutorizacao(ColaboradorTipoConstant.Gerente)]
    public class ColaboradorController : Controller
    {
        private IColaboradorRepository _colaboradorRepository;

        public ColaboradorController(IColaboradorRepository colaborador)
        {
            _colaboradorRepository = colaborador;
        }

        [HttpGet]
        public IActionResult Index(int? pagina)
        {
            IPagedList<Models.Colaborador> colaboradores = _colaboradorRepository.ObterTodosColaboradores(pagina);

            return View(colaboradores);
        }

        [HttpGet]
        public IActionResult Cadastrar()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Cadastrar([FromForm] Models.Colaborador colaborador)
        {
            if (ModelState.IsValid)
            {
                _colaboradorRepository.Cadastrar(colaborador);

                TempData["MSG_S"] = "Colaborador salvo com sucesso!";

                return RedirectToAction(nameof(Index));
            }
            
            return View();
        }

        [HttpGet]
        public IActionResult Atualizar(int Id)
        {
            Models.Colaborador colaborador = _colaboradorRepository.ObterColaborador(Id);

            return View(colaborador);
        }

        [HttpPost]
        public IActionResult Atualizar([FromForm] Models.Colaborador colaborador, int Id)
        {
            if (ModelState.IsValid)
            {
                colaborador.Ativo = true;
                _colaboradorRepository.Atualizar(colaborador);

                TempData["MSG_S"] = "Colaborador atualizado com sucesso!";

                return RedirectToAction(nameof(Index));
            }

            return View();
        }

        [HttpGet]
        [ValidadeHttpReferer]
        public IActionResult Excluir(int Id)
        {
            _colaboradorRepository.Excluir(Id);

            TempData["MSG_S"] = "Colaborador excluído com sucesso!";

            return RedirectToAction(nameof(Index));
        }

        [HttpGet]
        [ValidadeHttpReferer]
        public IActionResult Inativar(int Id)
        {
            _colaboradorRepository.Inativar(Id);

            TempData["MSG_S"] = "Colaborador inativado com sucesso!";

            return RedirectToAction(nameof(Index));
        }
    }
}