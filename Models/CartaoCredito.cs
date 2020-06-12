using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BazarPapelaria10.Models
{
    public class CartaoCredito
    {
        public string NumeroCartao { get; set; }
        public string NomeNoCartao { get; set; }
        public string Vencimento { get; set; }
        public string Cvv { get; set; }
    }
}
