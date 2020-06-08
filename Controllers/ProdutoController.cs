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
        private ICategoriaRepository _categoriaRepository;

        public ProdutoController(ICategoriaRepository categoriaRepository, IProdutoRepository produtoRepository)
        {
            _produtoRepository = produtoRepository;
            _categoriaRepository = categoriaRepository;
        }

        [HttpGet]
        public IActionResult ListagemCategoria(int Id)
        {

            return RedirectToAction();
        }

        [HttpGet]
        public IActionResult Visualizar(int Id)
        {
            return View(_produtoRepository.ObterProduto(Id));
        }
    }
}