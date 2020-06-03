using BazarPapelaria10.Database;
using BazarPapelaria10.Models;
using BazarPapelaria10.Repositories.Contracts;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using X.PagedList;

namespace BazarPapelaria10.Repositories
{
    public class ProdcategRepository : IProdcategRepository
    {
        IConfiguration _conf;
        BazarPapelaria10Context _banco;

        public ProdcategRepository(BazarPapelaria10Context banco, IConfiguration configuration)
        {
            _banco = banco;
            _conf = configuration;
        }

        public void Cadastrar(Prodcateg prodcateg)
        {
            _banco.Add(prodcateg);
            _banco.SaveChanges();
        }

        public void Atualizar(Prodcateg prodcateg)
        {
            _banco.Update(prodcateg);
            _banco.SaveChanges();
        }

        public void Excluir(int Id)
        {
            Prodcateg prodcateg = ObterProduto(Id);
            _banco.Remove(prodcateg);
            _banco.SaveChanges();
        }

        public Prodcateg ObterProduto(int Id)
        {
            return _banco.Prodcateg.Where(a => a.Id == Id).FirstOrDefault();
        }

        public IPagedList<Prodcateg> ObterTodosProdutos(int? pagina, string pesquisa)
        {
            int RegistrosPorPagina = _conf.GetValue<int>("RegistrosPorPagina");

            int NumeroPagina = pagina ?? 1;

            var bancoProduto = _banco.Prodcateg.AsQueryable();
            if (!string.IsNullOrEmpty(pesquisa))
            {
                bancoProduto = bancoProduto.Where(a => a.Produto.Nomeprod.Contains(pesquisa.Trim()) || a.Produto.Descprod.Contains(pesquisa.Trim()));
            }

            return bancoProduto.ToPagedList<Prodcateg>(NumeroPagina, RegistrosPorPagina);
        }
    }
}
