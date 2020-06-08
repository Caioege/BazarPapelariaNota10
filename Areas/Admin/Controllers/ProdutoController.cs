using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BazarPapelaria10.Bibliotecas.Arquivo;
using BazarPapelaria10.Bibliotecas.Filtro;
using BazarPapelaria10.Models;
using BazarPapelaria10.Models.ProdutoAgregador;
using BazarPapelaria10.Repositories.Contracts;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace BazarPapelaria10.Areas.Colaborador.Controllers
{
    [Area("Admin")]
    [ColaboradorAutorizacao]
    public class ProdutoController : Controller
    {
        private IProdutoRepository _produtoRepository;
        private ICategoriaRepository _categoriaRepository;
        private IImagemRepository _imagemRepository;

        public ProdutoController(IProdutoRepository produtoRepository, ICategoriaRepository categoriaRepository, IImagemRepository imagemRepository)
        {
            _produtoRepository = produtoRepository;
            _categoriaRepository = categoriaRepository;
            _imagemRepository = imagemRepository;
        }

        public IActionResult Index(int? pagina, string pesquisa)
        {
            var produtos = _produtoRepository.ObterTodosProdutos(pagina, pesquisa);

            return View(produtos);
        }

        [HttpGet]
        [ValidadeHttpReferer]
        public IActionResult Cadastrar()
        {
            ViewBag.Categorias = _categoriaRepository.ObterTodasCategorias().Select(a => new SelectListItem(a.Nomecateg, a.Id.ToString()));
            return View();
        }

        [HttpPost]
        public IActionResult Cadastrar(Produto produto)
        {
            if (ModelState.IsValid)
            {
                _produtoRepository.Cadastrar(produto);

                //CAMINHO TEMP -> MOVER IMAGEM PARA CAMINHO DEFINITIVO
                List<Imagem> ListaImagensDef = GerenciadorArquivo.MoverImagemProduto(new List<string>(Request.Form["imagem"]), produto.Id);

                //SALVAR CAMINHO DEFINITIVO NO BD
                _imagemRepository.CadastrarImagem(ListaImagensDef, produto.Id);

                TempData["MSG_S"] = "Produto cadastrado com sucesso!";

                return RedirectToAction(nameof(Index));
            }
            else
            {
                ViewBag.Categorias = _categoriaRepository.ObterTodasCategorias().Select(a => new SelectListItem(a.Nomecateg, a.Id.ToString()));
                produto.Imagens = new List<string>(Request.Form["imagem"]).Where(a => a.Trim().Length > 0).Select(a => new Imagem() { Caminho = a }).ToList();

                return View(produto);
            }
        }

        [HttpGet]
        [ValidadeHttpReferer]
        public IActionResult Atualizar(int Id)
        {
            Produto produto = _produtoRepository.ObterProduto(Id);

            ViewBag.Categorias = _categoriaRepository.ObterTodasCategorias().Select(a => new SelectListItem(a.Nomecateg, a.Id.ToString()));
            return View(produto);
        }

        [HttpPost]
        public IActionResult Atualizar(Produto produto, int Id)
        {
            if (ModelState.IsValid)
            {
                _produtoRepository.Atualizar(produto);

                List<Imagem> ListaImagensDef = GerenciadorArquivo.MoverImagemProduto(new List<string>(Request.Form["imagem"]), produto.Id);

                //DELETAR IMAGENS E SALVAR COM OS CAMINHOS CORRETOS
                _imagemRepository.ExcluirImagensDoProduto(produto.Id);
                _imagemRepository.CadastrarImagem(ListaImagensDef, produto.Id);

                TempData["MSG_S"] = "Produto atualizado com sucesso!";

                return RedirectToAction(nameof(Index));
            }
            else
            {
                ViewBag.Categorias = _categoriaRepository.ObterTodasCategorias().Select(a => new SelectListItem(a.Nomecateg, a.Id.ToString()));
                produto.Imagens = new List<string>(Request.Form["imagem"]).Where(a => a.Trim().Length > 0).Select(a => new Imagem() { Caminho = a }).ToList();

                return View(produto);
            }
        }

        [HttpGet]
        [ValidadeHttpReferer]
        public IActionResult Excluir(int Id)
        {
            Produto produto = _produtoRepository.ObterProduto(Id);
            GerenciadorArquivo.ExcluirImagensProduto(produto.Imagens.ToList());
            _imagemRepository.ExcluirImagensDoProduto(Id);
            _produtoRepository.Excluir(Id);

            TempData["MSG_S"] = "Produto excluído com sucesso!";

            return RedirectToAction(nameof(Index));
        }

        [HttpGet]
        [ValidadeHttpReferer]
        public IActionResult AtivarDesativar(int Id)
        {
            _produtoRepository.AtivarDesativar(Id);

            TempData["MSG_S"] = "Produto alterado com sucesso!";

            return RedirectToAction(nameof(Index));
        }
    }
}