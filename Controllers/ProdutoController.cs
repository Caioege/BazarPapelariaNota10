using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BazarPapelaria10.Models;
using BazarPapelaria10.Models.ViewModels;
using BazarPapelaria10.Repositories.Contracts;
using Microsoft.AspNetCore.Mvc;

namespace BazarPapelaria10.Controllers
{
    public class ProdutoController : Controller
    {

        private IProdutoRepository _produtoRepository;


        [HttpGet]
        public IActionResult Produto(int? pagina, string pesquisa)
        {
            var viewModel = new IndexViewModel()
            {
                lista = _produtoRepository.ObterTodosProdutos(pagina, pesquisa)
            };

            return View(viewModel);
        }
    }
}