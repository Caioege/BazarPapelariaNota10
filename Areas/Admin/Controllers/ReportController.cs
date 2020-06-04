using System;
using System.Linq;
using BazarPapelaria10.Bibliotecas.Filtro;
using BazarPapelaria10.Database;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Core;
using Newtonsoft.Json;

namespace BazarPapelaria10.Areas.Colaborador.Controllers
{
    [Area("Admin")]
    [ColaboradorAutorizacao]
    public class ReportController : Controller
    {
        private BazarPapelaria10Context _db;

        public ReportController(BazarPapelaria10Context banco)
        {
            _db = banco;
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

    }
}
