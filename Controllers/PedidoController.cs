using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BazarPapelaria10.Models.ProdutoAgregador;
using Microsoft.AspNetCore.Mvc;

namespace BazarPapelaria10.Controllers
{
    public class PedidoController : Controller
    {
        public IActionResult AdicionarPedido()
        {


            ProdutoItem produtoItem = new ProdutoItem();

            return AdicionarItens(produtoItem);
        }

        public IActionResult AdicionarItens(ProdutoItem produtoItem)
        {
            return View();
        }

        public IActionResult AlterarQuantidade()
        {
            return RedirectToActionPermanent("Index", "Home", new { area = "" } );
        }
    }
}
