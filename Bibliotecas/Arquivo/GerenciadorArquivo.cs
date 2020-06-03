using BazarPapelaria10.Models;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace BazarPapelaria10.Bibliotecas.Arquivo
{
    public class GerenciadorArquivo
    {
        public static string CadastrarImagemProduto(IFormFile file)
        {
            //ARMAZENAR ARQUIVO EM UMA PASTA
            var NomeArquivo = Path.GetFileName(file.FileName);
            var Caminho = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/uploads/temp", NomeArquivo);

            using(var stream = new FileStream(Caminho, FileMode.Create))
            {
                file.CopyTo(stream);
            }

            return Path.Combine("/uploads/temp", NomeArquivo);
        }

        public static bool ExcluirImagemProduto(string caminho)
        {
            //DELETAR ARQUIVO EM UMA PASTA
            string Caminho = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot", caminho.TrimStart('/'));

            if(File.Exists(Caminho))
            {
                //DELETAR ARQUIVO
                File.Delete(Caminho);

                return true;
            }
            else
            {
                return false;
            }
        }

        public static List<Imagem> MoverImagemProduto(List<string> ListaCaminhoTemp, int ProdutoId)
        {
            //CRIAR A PASTA DO PRODUTO
            var CaminhoDefinitivoPastaProduto = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/uploads", ProdutoId.ToString());

            if(!Directory.Exists(CaminhoDefinitivoPastaProduto))
            {
                Directory.CreateDirectory(CaminhoDefinitivoPastaProduto);
            }

            List<Imagem> ListaImagensDef = new List<Imagem>();

            //MOVER A IMAGEM
            foreach(var caminhoTemp in ListaCaminhoTemp)
            {
                // /uploads/temp/caderno.jpg

                if (!string.IsNullOrEmpty(caminhoTemp))
                {
                    var NomeArquivo = Path.GetFileName(caminhoTemp);

                    var CaminhoDef = Path.Combine("uploads/", ProdutoId.ToString(), NomeArquivo).Replace("\\", "/");
                    
                    if (CaminhoDef != caminhoTemp)
                    {
                        var CaminhoAbsolutoTemp = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/uploads/temp", NomeArquivo);
                        var CaminhoAbsolutoDef = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/uploads", ProdutoId.ToString(), NomeArquivo);

                        if (File.Exists(CaminhoAbsolutoTemp))
                        {
                            //DELETA SE JÁ EXISTE
                            if(File.Exists(CaminhoAbsolutoDef))
                            {
                                File.Delete(CaminhoAbsolutoDef);
                            }

                            //MOVER
                            File.Copy(CaminhoAbsolutoTemp, CaminhoAbsolutoDef);

                            if (File.Exists(CaminhoAbsolutoDef))
                            {
                                File.Delete(CaminhoAbsolutoTemp);
                            }

                            ListaImagensDef.Add(new Imagem() { Caminho = Path.Combine("/uploads", ProdutoId.ToString(), NomeArquivo).Replace("\\", "/"), ProdutoCodprod = ProdutoId });
                        }
                        else
                        {
                            ListaImagensDef.Add(new Imagem() { Caminho = Path.Combine("/uploads", ProdutoId.ToString(), NomeArquivo).Replace("\\", "/"), ProdutoCodprod = ProdutoId });
                        }
                    }
                    else
                    {
                        ListaImagensDef.Add(new Imagem() { Caminho = Path.Combine("/uploads", ProdutoId.ToString(), NomeArquivo).Replace("\\", "/"), ProdutoCodprod = ProdutoId });
                    }
                }
            }
            return ListaImagensDef;
        }

        public static void ExcluirImagensProduto(List<Imagem> imagens)
        {
            int produtoId= 0;

            foreach(var imagem in imagens)
            {
                ExcluirImagemProduto(imagem.Caminho);
                produtoId = imagem.ProdutoCodprod;
            }

            var pastaProduto = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/uploads", produtoId.ToString());

            if(Directory.Exists(pastaProduto))
            {
                Directory.Delete(pastaProduto);
            }
        }
    }
}
