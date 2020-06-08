using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BazarPapelaria10.Bibliotecas.Cookie
{
    public class Cookie
    {

        IHttpContextAccessor _context;

        public Cookie(IHttpContextAccessor contexto)
        {
            _context = contexto;
        }

        //CRUD SESSÃO - CADASTRAR, ATUALIZAR, CONSULTAR, REMOVER 

        public void Cadastrar(string Key, string Valor)
        {
            CookieOptions Options = new CookieOptions();
            Options.Expires = DateTime.Now.AddDays(7);

            _context.HttpContext.Response.Cookies.Append(Key, Valor, Options);
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
            return _context.HttpContext.Request.Cookies[Key];
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
