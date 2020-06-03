using BazarPapelaria10.Database;
using BazarPapelaria10.Models;
using BazarPapelaria10.Repositories.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BazarPapelaria10.Repositories
{
    public class ImagemReporitory : IImagemRepository
    {
        private BazarPapelaria10Context _banco;

        public ImagemReporitory(BazarPapelaria10Context banco)
        {
            _banco = banco;
        }
        public void Cadastrar(Imagem imagem)
        {
            _banco.Add(imagem);
            _banco.SaveChanges();
        }

        public void CadastrarImagem(List<Imagem> ListaImagens, int ProdutoId)
        {
            if (ListaImagens != null && ListaImagens.Count > 0)
            {
                foreach (var imagem in ListaImagens)
                {
                    this.Cadastrar(imagem);
                }
            }
        }

        public void Excluir(int Id)
        {
            Imagem imagem = _banco.Imagens.Find(Id);
            _banco.Remove(imagem);
            _banco.SaveChanges();
        }

        public void ExcluirImagensDoProduto(int ProdutoId)
        {
            List<Imagem> imagens = _banco.Imagens.Where(a => a.ProdutoCodprod == ProdutoId).ToList();

            foreach (Imagem imagem in imagens)
            {
                _banco.Remove(imagem);
            }
            _banco.SaveChanges();
        }
    }
}
