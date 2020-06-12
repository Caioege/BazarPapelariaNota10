using BazarPapelaria10.Database;
using BazarPapelaria10.Models;
using BazarPapelaria10.Repositories.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BazarPapelaria10.Repositories
{
    public class EnderecoEntregaRepository : IEnderecoEntregaRepository
    {
        private BazarPapelaria10Context _banco;

        public EnderecoEntregaRepository(BazarPapelaria10Context banco)
        {
            _banco = banco;
        }

        public void Cadastrar(EnderecoEntrega endereco)
        {
            endereco.DtCriacao = System.DateTime.Now;
            endereco.DtAlteracao = System.DateTime.Now;
            endereco.Ativo = true;

            _banco.Add(endereco);
            _banco.SaveChanges();
        }

        public void Atualizar(EnderecoEntrega endereco)
        {
            endereco.DtAlteracao = System.DateTime.Now;
            _banco.Update(endereco);
            _banco.SaveChanges();
        }

        public void Excluir(int Id)
        {
            EnderecoEntrega endereco = ObterEnderecoEntrega(Id);
            _banco.Remove(endereco);
            _banco.SaveChanges();
        }

        public EnderecoEntrega ObterEnderecoEntrega(int Id)
        {
            return _banco.EnderecoEntrega.Find(Id);
        }

        public IList<EnderecoEntrega> ObterTodosEnderecosEntregaCliente(int pessoaId)
        {
            return _banco.EnderecoEntrega.Where(a => a.PessoaId == pessoaId && a.Ativo == true).ToList();
        }
    }
}
