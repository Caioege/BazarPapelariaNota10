using BazarPapelaria10.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BazarPapelaria10.Bibliotecas.Login
{
    public class LoginCliente
    {
        private string Key = "Login.Pessoa";
        private Sessao.Sessao _sessao;

        public LoginCliente(Sessao.Sessao sessao)
        {
            _sessao = sessao;
        }

        public void Login(Pessoa pessoa)
        {
            //ARMAZENAR NA SESSÃO

            //SERIALIZAR
            string clienteJsonString = JsonConvert.SerializeObject(pessoa);
            _sessao.Cadastrar(Key, clienteJsonString);
        }

        public Pessoa GetCliente()
        {

            if(_sessao.Existe(Key))
            {
                //DESSERIALIZAR
                string clienteJsonString = _sessao.Consultar(Key);

                return JsonConvert.DeserializeObject<Pessoa>(clienteJsonString);
            }
            return null;
        }

        public void Logout()
        {
            _sessao.RemoverTodos();
        }
    }
}
