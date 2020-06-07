using BazarPapelaria10.Models.ViewModels;
using BazarPapelaria10.Repositories.Contracts;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BazarPapelaria10.Bibliotecas.Component
{
    public class ProdutoListagemEscritorioViewComponent : ViewComponent
    {
        private IProdutoRepository _produtoRepository;

        public ProdutoListagemEscritorioViewComponent(IProdutoRepository produtoRepository)
        {
            _produtoRepository = produtoRepository;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            int? pagina = 1;
            string pesquisa = "";
            string ordenacao = "A";
            int? categoria = null;

            var viewModel = new ProdutoListagemViewModel() { lista = _produtoRepository.ObterTodosProdutos(pagina, pesquisa, ordenacao, categoria) };
            return View(viewModel);
        }
    }
}
