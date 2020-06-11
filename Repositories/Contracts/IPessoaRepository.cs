using BazarPapelaria10.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using X.PagedList;

namespace BazarPapelaria10.Repositories
{
    public interface IPessoaRepository
    {
        Pessoa Login(string Email, string Senha);

        void Cadastrar(Pessoa pessoa);
        void Atualizar(Pessoa pessoa);
        void Excluir(int Id);
        Pessoa ObterPessoa(int Id);
        IPagedList<Pessoa> ObterTodasPessoas(int? pagina, string pesquisa);
        List<Pessoa> ObterPessoaReport();
    }
}
