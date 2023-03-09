using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace TesteMVC5.Models
{
    public class Aluno
    {
        public int id { get; set; }

        [DisplayName("Nome Completo")]
        [Required(ErrorMessage = "O campo {0} é requerido")]
        public string nome { get; set; }

        [DisplayName("E-mail")]
        [Required(ErrorMessage = "O campo {0} é requerido")]
        [EmailAddress(ErrorMessage ="Email em formato inválido")]
        public string email { get; set; }

        [Required(ErrorMessage = "O campo {0} é requerido")]
        public string cpf { get; set; }

        public DateTime dataMatricula { get; set; }
        public bool ativo { get; set; }

        [Required(ErrorMessage = "O campo {0} é requerido")]
        public string Senha { get; set; }

        [Compare("Senha", ErrorMessage ="As senha informadas não conferem")]
        [Required(ErrorMessage = "O campo {0} é requerido")]
        public string SenhaConfirmacao { get; set; }
    }
}