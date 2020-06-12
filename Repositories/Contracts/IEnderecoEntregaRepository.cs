﻿using BazarPapelaria10.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BazarPapelaria10.Repositories.Contracts
{
    public interface IEnderecoEntregaRepository
    {
        void Cadastrar(EnderecoEntrega endereco);
        void Atualizar(EnderecoEntrega endereco);
        void Excluir(int Id);
        EnderecoEntrega ObterEnderecoEntrega(int Id);
        IList<EnderecoEntrega> ObterTodosEnderecosEntregaCliente(int pessoaId);
    }
}
