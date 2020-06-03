using BazarPapelaria10.Database;
using BazarPapelaria10.Models;
using BazarPapelaria10.Models.Constants;
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
    public class ColaboradorRepository : IColaboradorRepository
    {
        private IConfiguration _conf;

        private BazarPapelaria10Context _banco;

        public ColaboradorRepository(BazarPapelaria10Context banco, IConfiguration configuration)
        {
            _conf = configuration;
            _banco = banco;
        }

        public void Atualizar(Colaborador colaborador)
        {
            colaborador.DtAlteracao = System.DateTime.Now;
            _banco.Update(colaborador);
            _banco.SaveChanges();
        }

        public void Cadastrar(Colaborador colaborador)
        {
            colaborador.Tipo = ColaboradorTipoConstant.Comum;
            colaborador.DtCriacao = System.DateTime.Now;
            colaborador.DtAlteracao = System.DateTime.Now;
            colaborador.Ativo = true;

            _banco.Add(colaborador);
            _banco.SaveChanges();
        }

        public void Excluir(int Id)
        {
            Colaborador colaborador = ObterColaborador(Id);
            _banco.Remove(colaborador);
            _banco.SaveChanges();
        }

        public void Inativar(int Id)
        {
            Colaborador colaborador = ObterColaborador(Id);
            colaborador.Ativo = false;
            _banco.Update(colaborador);
            _banco.SaveChanges();
        }

        public Colaborador Login(string Email, string Senha)
        {
            Colaborador colaborador = _banco.Colaborador.Where(c => c.Email == Email && c.Senha == Senha).FirstOrDefault();
            return colaborador;
        }

        public Colaborador ObterColaborador(int Id)
        {
            return _banco.Colaborador.Find(Id); 
        }

        public List<Colaborador> ObterColaboradorPorEmail(string Email)
        {
            return _banco.Colaborador.Where(a => a.Email == Email).AsNoTracking().ToList();
        }

        public IEnumerable<Colaborador> ObterTodosColaboradores()
        {
            return _banco.Colaborador.Where(a => a.Tipo != ColaboradorTipoConstant.Gerente && a.Ativo == true).ToList();
        }
        public IPagedList<Colaborador> ObterTodosColaboradores(int? pagina)
        {
            int numeroPagina = pagina ?? 1;

            return _banco.Colaborador.Where(a => a.Tipo != ColaboradorTipoConstant.Gerente && a.Ativo == true).ToPagedList<Colaborador>(numeroPagina, _conf.GetValue<int>("RegistrosPorPagina"));
        }
    }
}
