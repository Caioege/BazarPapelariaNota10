using System;
using System.Collections.Generic;
using System.Linq;
using BazarPapelaria10.Bibliotecas.Filtro;
using BazarPapelaria10.Database;
using BazarPapelaria10.Models;
using BazarPapelaria10.Models.ProdutoAgregador;
using BazarPapelaria10.Reports;
using BazarPapelaria10.Repositories.Contracts;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Core;
using Microsoft.AspNetCore.Mvc.Rendering;
using Newtonsoft.Json;

namespace BazarPapelaria10.Areas.Colaborador.Controllers
{
    [Area("Admin")]
    [ColaboradorAutorizacao]
    public class ReportController : Controller
    {
        private BazarPapelaria10Context _db;
        private readonly IWebHostEnvironment _oHostEnvironment;
        private IProdutoRepository _produtoRepository;
        private ICategoriaRepository _categoriaRepository;

        public ReportController(BazarPapelaria10Context banco, IProdutoRepository produtoRepository, ICategoriaRepository categoriaRepository)
        {
            _db = banco;
            _produtoRepository = produtoRepository;
            _categoriaRepository = categoriaRepository;
        }

        public IActionResult Index() 
        {

            return View();
        }

        public JsonResult GetProdutos()
        {
            var produtos = _db.Produtos.ToList();


            return Json(produtos);
        }

        public IActionResult ListagemProdutos()
        {
            return View();
        }

        [HttpGet]
        public IActionResult ProdutoReport()
        {
            ViewBag.Categorias = _categoriaRepository.ObterTodasCategorias().Select(a => new SelectListItem(a.Nomecateg, a.Id.ToString()));
            return View();
        }

        [HttpPost]
        public IActionResult ProdutoReport([FromForm] int? param, int? categoria)
        {
            List<Produto> oProdutos = _produtoRepository.ObterProdutoReport(param, categoria);

            ProdutoReport rpt = new ProdutoReport(_oHostEnvironment);
            return File(rpt.Report(oProdutos), "application/pdf");
        }
    }
}
