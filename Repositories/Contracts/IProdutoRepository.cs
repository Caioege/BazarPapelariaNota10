﻿using BazarPapelaria10.Models;
using X.PagedList;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BazarPapelaria10.Repositories.Contracts
{
    public interface IProdutoRepository
    {
        //CRUD
        void Cadastrar(Produto produto);
        void Atualizar(Produto produto);
        void Excluir(int Id);

        Produto ObterProduto(int Id);
        IPagedList<Produto> ObterTodosProdutos(int? pagina, string pesquisa);
        void AtivarDesativar(int Id);
    }
}
