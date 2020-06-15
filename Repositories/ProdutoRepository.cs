using BazarPapelaria10.Database;
using BazarPapelaria10.Models;
using BazarPapelaria10.Repositories.Contracts;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using X.PagedList;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BazarPapelaria10.Models.ProdutoAgregador;

namespace BazarPapelaria10.Repositories
{
    public class ProdutoRepository : IProdutoRepository
    {
        private IConfiguration _conf;
        private BazarPapelaria10Context _banco;

    public ProdutoRepository(BazarPapelaria10Context banco, IConfiguration configuration)
        {
            _banco = banco;
            _conf = configuration;
        }

        public void Cadastrar(Produto produto)
        {
            produto.Dtcriacao = System.DateTime.Now;
            produto.Dtalteracao = System.DateTime.Now;
            produto.Ativo = true;
            _banco.Add(produto);
            _banco.SaveChanges();
        }

        public void Atualizar(Produto produto)
        {
            produto.Dtalteracao = System.DateTime.Now;
            _banco.Update(produto);
            _banco.SaveChanges();

        }

        public void Excluir(int Id)
        {
            Produto produto =  ObterProduto(Id);
            _banco.Remove(produto);
            _banco.SaveChanges();
        }

        public Produto ObterProduto(int Id)
        {
            return _banco.Produtos.Include(a => a.Imagens).Where(a => a.Id == Id).FirstOrDefault();
        }

        public IPagedList<Produto> ObterTodosProdutos(int? pagina, string pesquisa)
        {
            return ObterTodosProdutos(pagina, pesquisa, "A", null);
        }

        public IPagedList<Produto> ObterTodosProdutos(int? pagina, string pesquisa, string ordenacao, int? categoria)
        {
            int RegistrosPorPagina = _conf.GetValue<int>("RegistrosPorPagina");

            int NumeroPagina = pagina ?? 1;

            var bancoProduto = _banco.Produtos.AsQueryable();
            if (!string.IsNullOrEmpty(pesquisa))
            {
                bancoProduto = bancoProduto.Where(a => a.Nomeprod.Contains(pesquisa.Trim()) || a.Descprod.Contains(pesquisa.Trim()));
            }

            if(ordenacao == "A")
            {
                bancoProduto = bancoProduto.OrderBy(a => a.Nomeprod);
            }
            if (ordenacao == "ME")
            {
                bancoProduto = bancoProduto.OrderBy(a => a.Valorprod);
            }
            if (ordenacao == "MA")
            {
                bancoProduto = bancoProduto.OrderByDescending(a => a.Valorprod);
            }

            if(categoria != null)
            {
                return bancoProduto.Include(a => a.Imagens).Where(a => a.CategoriaId == categoria).ToPagedList<Produto>(NumeroPagina, RegistrosPorPagina);
            }

            return bancoProduto.Include(a => a.Imagens).ToPagedList<Produto>(NumeroPagina, RegistrosPorPagina);
        }

        public List<Produto> ObterProdutoReport(int? param, int? categoria)
        {
            if(param != null && categoria != null)
            {
                return _banco.Produtos.Where(a => a.Quantidade <= param && a.CategoriaId == categoria).ToList();
            }
            else if (param != null)
            {
                return _banco.Produtos.Where(a => a.Quantidade <= param).ToList();
            }
            else if(categoria != null)
            {
                return _banco.Produtos.Where(a => a.CategoriaId == categoria).ToList();
            }

            return _banco.Produtos.ToList();
        }

        public void AtivarDesativar(int Id)
        {
            Produto produto = ObterProduto(Id);
            if(produto.Ativo)
            {
                produto.Ativo = false;
            }
            else
            {
                produto.Ativo = true;
            }
            
            _banco.Update(produto);
            _banco.SaveChanges();
        }
    }
}
