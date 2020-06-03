using BazarPapelaria10.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using X.PagedList;

namespace BazarPapelaria10.Repositories.Contracts
{
    public interface IProdcategRepository
    {
        //CRUD
        void Cadastrar(Prodcateg prodcateg);
        void Atualizar(Prodcateg prodcateg);
        void Excluir(int Id);

        Prodcateg ObterProduto(int Id);
        IPagedList<Prodcateg> ObterTodosProdutos(int? pagina, string pesquisa);
    }
}
