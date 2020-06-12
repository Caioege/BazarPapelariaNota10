using BazarPapelaria10.Bibliotecas;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace BazarPapelaria10.Models
{
    public class EnderecoEntrega
    {
        public int Id { get; set; }
        [Required(ErrorMessageResourceType = typeof(Mensagem), ErrorMessageResourceName = "MSG_E001")]
        public string Nome { get; set; }

        [Required(ErrorMessageResourceType = typeof(Mensagem), ErrorMessageResourceName = "MSG_E001")]
        [MinLength(9, ErrorMessageResourceType = typeof(Mensagem), ErrorMessageResourceName = "MSG_GEN02")]
        [MaxLength(9, ErrorMessageResourceType = typeof(Mensagem), ErrorMessageResourceName = "MSG_GEN03")]
        public string CEP { get; set; }
        [Required(ErrorMessageResourceType = typeof(Mensagem), ErrorMessageResourceName = "MSG_E001")]
        public string Cidade { get; set; }
        [Required(ErrorMessageResourceType = typeof(Mensagem), ErrorMessageResourceName = "MSG_E001")]
        public string Logradouro { get; set; }
        [Required(ErrorMessageResourceType = typeof(Mensagem), ErrorMessageResourceName = "MSG_E001")]
        public string Bairro { get; set; }
        [Required(ErrorMessageResourceType = typeof(Mensagem), ErrorMessageResourceName = "MSG_E001")]
        public string Complemento { get; set; }
        public string Numero { get; set; }

        //CLIENTE
        [ForeignKey("Pessoa")]
        public int? PessoaId { get; set; }
        
        public virtual Pessoa Pessoa { get; set; }

        public DateTime DtCriacao { get; set; }
        public DateTime DtAlteracao { get; set; }
        public bool Ativo { get; set; }
    }
}