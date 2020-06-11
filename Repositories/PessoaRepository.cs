using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BazarPapelaria10.Database;
using BazarPapelaria10.Models;
using Microsoft.Extensions.Configuration;
using X.PagedList;

namespace BazarPapelaria10.Repositories
{
    public class PessoaRepository : IPessoaRepository
    {
        private IConfiguration _conf;
        private BazarPapelaria10Context _banco;

        public PessoaRepository(BazarPapelaria10Context banco, IConfiguration conf)
        {
            _conf = conf;
            _banco = banco;
        }

        public void Atualizar(Pessoa pessoa)
        {
            pessoa.DtAlteracao = System.DateTime.Now;
            _banco.Update(pessoa);
            _banco.SaveChanges();
        }

        public void Cadastrar(Pessoa pessoa)
        {
            pessoa.DtCriacao = System.DateTime.Now;
            pessoa.DtAlteracao = System.DateTime.Now;
            pessoa.Ativo = true;

            _banco.Add(pessoa);
            _banco.SaveChanges();
        }

        public void Excluir(int Id)
        {
            Pessoa pessoa = ObterPessoa(Id);
            _banco.Remove(pessoa);
            _banco.SaveChanges();
        }

        public Pessoa Login(string Email, string Senha)
        {
            Pessoa pessoa = _banco.Pessoa.Where(c => c.Email == Email && c.Senha == Senha).FirstOrDefault();
            return pessoa;
        }

        public Pessoa ObterPessoa(int Id)
        {
            return _banco.Pessoa.Find(Id);
        }

        public IPagedList<Pessoa> ObterTodasPessoas(int? pagina, string pesquisa)
        {
            int numeroPagina = pagina ?? 1;
            var bancoCliente = _banco.Pessoa.AsQueryable();

            if(!string.IsNullOrEmpty(pesquisa))
            {
                bancoCliente = bancoCliente.Where(a => a.Nome.Contains(pesquisa.Trim()) || a.Email.Contains(pesquisa.Trim()));
            }

            return bancoCliente.ToPagedList<Pessoa>(numeroPagina, _conf.GetValue<int>("RegistrosPorPagina"));
        }

        public List<Pessoa> ObterPessoaReport()
        {
            return _banco.Pessoa.ToList();
        }
    }
}
