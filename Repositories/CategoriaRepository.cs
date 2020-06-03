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

    public class CategoriaRepository : ICategoriaRepository
    {

        private IConfiguration _conf;

        private BazarPapelaria10Context _banco;

        public CategoriaRepository(BazarPapelaria10Context banco, IConfiguration configuration)
        {
            _banco = banco;
            _conf = configuration;
        }

        public void Atualizar(Categoria categoria)
        {
            categoria.DtAlteracao = System.DateTime.Now;
            _banco.Update(categoria);
            _banco.SaveChanges();
        }

        public void Cadastrar(Categoria categoria)
        {
            categoria.DtCriacao = System.DateTime.Now;
            categoria.DtAlteracao = System.DateTime.Now;
            categoria.Ativo = true;

            _banco.Add(categoria);
            _banco.SaveChanges();
        }

        public void Excluir(int Id)
        {
            Categoria categoria = ObterCategoria(Id);
            _banco.Remove(categoria);
            _banco.SaveChanges();
        }

        public Categoria ObterCategoria(int Id)
        {
            return _banco.Categorias.Find(Id);
        }

        public IPagedList<Categoria> ObterTodasCategorias(int? pagina)
        {
            int numeroPagina = pagina ?? 1;

            return _banco.Categorias.ToPagedList<Categoria>(numeroPagina, _conf.GetValue<int>("RegistrosPorPagina"));
        }

        public IEnumerable<Categoria> ObterTodasCategorias()
        {
            return _banco.Categorias;
        }
    }
}
