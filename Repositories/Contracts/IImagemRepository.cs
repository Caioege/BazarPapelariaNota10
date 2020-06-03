using BazarPapelaria10.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BazarPapelaria10.Repositories.Contracts
{
    public interface IImagemRepository
    {
        void Cadastrar(Imagem imagem);
        void CadastrarImagem(List<Imagem> ListaImagens, int ProdutoId);
        void Excluir(int Id);
        void ExcluirImagensDoProduto(int ProdutoId);
    }
}
