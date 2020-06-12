using BazarPapelaria10.Bibliotecas.Seguranca;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BazarPapelaria10.Bibliotecas.Cookie
{
    public class Cookie
    {

        private IHttpContextAccessor _context;
        private IConfiguration _conf;

        public Cookie(IHttpContextAccessor contexto, IConfiguration conf)
        {
            _context = contexto;
            _conf = conf;
        }

        //CRUD SESSÃO - CADASTRAR, ATUALIZAR, CONSULTAR, REMOVER 

        public void Cadastrar(string Key, string Valor)
        {
            CookieOptions Options = new CookieOptions();
            Options.IsEssential = true;
            Options.Expires = DateTime.Now.AddDays(5);

            var ValorCrypt = StringCipher.Encrypt(Valor, _conf.GetValue<string>("KeyCrypt"));

            _context.HttpContext.Response.Cookies.Append(Key, ValorCrypt, Options);
        }

        public void AddEnderecoEntrega(int Id)
        {

        }

        public void Atualizar(string Key, string Valor)
        {
            if (Existe(Key))
            {
                Remover(Key);
            }

            Cadastrar(Key, Valor);
        }

        public void Remover(string Key)
        {
            _context.HttpContext.Response.Cookies.Delete(Key);
        }

        public string Consultar(string Key)
        {
            var ValorCrypt = _context.HttpContext.Request.Cookies[Key];

            var Valor =  StringCipher.Decrypt(ValorCrypt, _conf.GetValue<string>("KeyCrypt"));

            return Valor;
        }

        public bool Existe(string Key)
        {
            if (_context.HttpContext.Request.Cookies[Key] == null)
            {
                return false;
            }

            return true;
        }

        public void RemoverTodos()
        {
            var listaCookie = _context.HttpContext.Request.Cookies.ToList();
            foreach(var cookie in listaCookie)
            {
                Remover(cookie.Key);
            }
        }
    }
}
