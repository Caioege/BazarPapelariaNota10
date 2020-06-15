using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BazarPapelaria10.Bibliotecas.Filtro;
using BazarPapelaria10.Bibliotecas.Login;
using BazarPapelaria10.Models;
using BazarPapelaria10.Models.Constants;
using BazarPapelaria10.Repositories.Contracts;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace BazarPapelaria10.Areas.Admin.Controllers
{
    [ColaboradorAutorizacao]
    [Area("Admin")]
    public class PedidoController : Controller
    {
        private LoginCliente _loginCliente;
        private IPedidoRepository _pedidoRepository;

        public PedidoController(LoginCliente loginCliente, IPedidoRepository pedidoRepository)
        {
            _loginCliente = loginCliente;
            _pedidoRepository = pedidoRepository;
        }

        public IActionResult Index(int? pagina)
        {
            var pedidos = _pedidoRepository.ObterTodosPedidos(pagina);

            return View(pedidos);
        }

        public IActionResult Visualizar(int Id)
        {
            var pedido = _pedidoRepository.VisualizarPedido(Id);

            return View(pedido);
        }

        [HttpPost]
        public IActionResult AlterarStatus([FromForm] Pedido pedido)
        {
            ViewBag.Status = new StatusPedidoConstant().GetStatus().Select(a => new SelectListItem(a.DescStatus, a.Id.ToString()));
            return View();
        }
    }
}
