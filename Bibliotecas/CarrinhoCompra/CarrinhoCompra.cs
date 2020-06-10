using BazarPapelaria10.Models.ProdutoAgregador;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BazarPapelaria10.Bibliotecas.CarrinhoCompra
{
    public class CarrinhoCompra
    {
        private string Key = "Carrinho.Compras";
        private Cookie.Cookie _cookie;
        public CarrinhoCompra(Cookie.Cookie cookie)
        {
            _cookie = cookie;
        }

        public void Cadastrar(ProdutoItem item)
        {
            List<ProdutoItem> lista;

            if (_cookie.Existe(Key))
            {
                lista = Consultar();
                var itemLocalizado = lista.SingleOrDefault(a => a.Id == item.Id);

                if (itemLocalizado == null)
                {
                    lista.Add(item);
                }
                else
                {
                    itemLocalizado.QuantidadeProdutoCarrinho = itemLocalizado.QuantidadeProdutoCarrinho + 1;
                }
            }
            else
            {
                lista = new List<ProdutoItem>();
                lista.Add(item);
            }

            Salvar(lista);
        }

        public void Atualizar(ProdutoItem item)
        {
            var lista = Consultar();
            var itemLocalizado = lista.SingleOrDefault(a => a.Id == item.Id);

            if (itemLocalizado != null)
            {
                itemLocalizado.QuantidadeProdutoCarrinho = item.QuantidadeProdutoCarrinho;

                Salvar(lista);
            }
        }

        public void Remover(ProdutoItem item)
        {
            var lista = Consultar();
            var itemLocalizado = lista.SingleOrDefault(a => a.Id == item.Id);

            if (itemLocalizado != null)
            {
                lista.Remove(itemLocalizado);

                Salvar(lista);
            }
        }

        public List<ProdutoItem> Consultar()
        {
            if (_cookie.Existe(Key))
            {
                var valor = _cookie.Consultar(Key);
                return JsonConvert.DeserializeObject<List<ProdutoItem>>(valor);
            }
            else
            {
                return new List<ProdutoItem>();
            }

        }

        public void Salvar(List<ProdutoItem> lista)
        {
            var valor = JsonConvert.SerializeObject(lista);

            _cookie.Cadastrar(Key, valor);
        }

        public bool Existe(string Key)
        {
            if (_cookie.Existe(Key))
            {
                return false;
            }

            return true;
        }

        public void RemoverTodos()
        {
            _cookie.Remover(Key);
        }

    }
}