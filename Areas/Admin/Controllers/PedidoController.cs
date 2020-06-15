using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BazarPapelaria10.Bibliotecas.Filtro;
using Microsoft.AspNetCore.Mvc;

namespace BazarPapelaria10.Areas.Admin.Controllers
{
    [ColaboradorAutorizacao]
    public class PedidoController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
