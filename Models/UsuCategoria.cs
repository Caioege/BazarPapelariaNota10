using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BazarPapelaria10.Models
{
    public class UsuCategoria
    {
        public UsuCategoria() { }

        public int Id { get; set; }
        public string Descricao { get; set; }
        public string Observacao { get; set; }
        public bool Ativo { get; set; }
        public DateTime DtCriacao { get; set; }
    }
}
