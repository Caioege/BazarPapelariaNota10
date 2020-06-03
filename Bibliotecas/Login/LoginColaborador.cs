using BazarPapelaria10.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BazarPapelaria10.Bibliotecas.Login
{
    public class LoginColaborador
    {
        private string Key = "Login.Colaborador";
        private Sessao.Sessao _sessao;

        public LoginColaborador(Sessao.Sessao sessao)
        {
            _sessao = sessao;
        }

        public void Login(Colaborador colaborador)
        {
            //ARMAZENAR NA SESSÃO

            //SERIALIZAR
            string colaboradorJsonString = JsonConvert.SerializeObject(colaborador);
            _sessao.Cadastrar(Key, colaboradorJsonString);
        }

        public Colaborador GetColaborador()
        {

            if (_sessao.Existe(Key))
            {
                //DESSERIALIZAR
                string colaboradorJsonString = _sessao.Consultar(Key);

                return JsonConvert.DeserializeObject<Colaborador>(colaboradorJsonString);
            }
            return null;
        }

        public void Logout()
        {
            _sessao.RemoverTodos();
        }
    }
}
