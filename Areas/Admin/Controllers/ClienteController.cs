using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BazarPapelaria10.Bibliotecas.Filtro;
using BazarPapelaria10.Models;
using BazarPapelaria10.Repositories;
using Microsoft.AspNetCore.Mvc;
using X.PagedList;

namespace BazarPapelaria10.Areas.Colaborador.Controllers
{
    [Area("Admin")]
    [ColaboradorAutorizacao]
    public class ClienteController : Controller
    {
        private IPessoaRepository _pessoaRepository;
        public ClienteController(IPessoaRepository pessoaRepository)
        {
            _pessoaRepository = pessoaRepository;
        }

        [HttpGet]
        public IActionResult Index(int? pagina, string pesquisa)
        {
            IPagedList<Pessoa> clientes = _pessoaRepository.ObterTodasPessoas(pagina, pesquisa);
            return View(clientes);
        }

        [ValidadeHttpReferer]
        public IActionResult AtivarDesativar(int Id)
        {
            Pessoa cliente = _pessoaRepository.ObterPessoa(Id);
            cliente.Ativo = (cliente.Ativo == true) ? cliente.Ativo = false : cliente.Ativo = true;

            _pessoaRepository.Atualizar(cliente);

            TempData["MSG_S"] = "Cliente atualizado com sucesso!";

            return RedirectToAction(nameof(Index));
        }
    }
}