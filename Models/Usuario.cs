using BazarPapelaria10.Bibliotecas;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace BazarPapelaria10.Models
{
    public class Usuario
    {
        public Usuario() { }

        public int Id { get; set; }
        public string Login { get; set; }
        public string Senha { get; set; }
        public DateTime DtCriacao { get; set; }
        public DateTime DtAlteracao { get; set; }
        public bool Ativo { get; set; }
        public int UsuCategoriaId { get; set; }
        [ForeignKey("UsuCategoriaId")]
        public virtual UsuCategoria UsuCategoria { get; set; }
        public int PessoaId { get; set; }
        [ForeignKey("PessoaId")]
        public virtual Pessoa Pessoa { get; set; }
    }
}
