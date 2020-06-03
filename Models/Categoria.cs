using BazarPapelaria10.Bibliotecas;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BazarPapelaria10.Models
{
    public class Categoria
    {
        public int Id { get; set; }
        [Required(ErrorMessageResourceType = typeof(Mensagem), ErrorMessageResourceName = "MSG_GEN01")]
        public string Nomecateg { get; set; }
        public string Desccateg { get; set; }
        public string Obscateg { get; set; }
        public DateTime DtCriacao { get; set; }
        public DateTime DtAlteracao { get; set; }
        public bool Ativo { get; set; }

        //SLUG
        [Required(ErrorMessageResourceType = typeof(Mensagem), ErrorMessageResourceName = "MSG_GEN01")]
        [MinLength(4,ErrorMessageResourceType = typeof(Mensagem), ErrorMessageResourceName = "MSG_GEN02")]
        public string Slug { get; set; }

    }
}
