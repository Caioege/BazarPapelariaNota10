using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BazarPapelaria10.Bibliotecas.Filtro;
using BazarPapelaria10.Bibliotecas.Login;
using BazarPapelaria10.Models;
using BazarPapelaria10.Models.ProdutoAgregador;
using BazarPapelaria10.Repositories.Contracts;
using Microsoft.AspNetCore.Mvc;

namespace BazarPapelaria10.Areas.Cliente.Controllers
{
    [ClienteAutorizacao]
    [Area("Cliente")]
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
            Models.Pessoa cliente = _loginCliente.GetCliente();

            var pedidos = _pedidoRepository.ObterTodosPedidos(pagina, cliente.Id);

            return View(pedidos);
        }

        public IActionResult Visualizar(int Id)
        {
            Models.Pessoa cliente = _loginCliente.GetCliente();

            var pedido = _pedidoRepository.ObterPedidoPA(Id);
            
            if (pedido.ClienteId != cliente.Id)
            {
                return new ContentResult() { Content = "Acesso Negado!" };
            }

            return View(pedido);
        }
    }
}
