using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace PrimeiroMVC5.Models
{
    public class Student
    {
        public int Id { get; set; }
        [DisplayName("Nome")]
        [Required(ErrorMessage = "O campo {0} é requirido.")]
        public string Name { get; set; }

        [DisplayName("E-mail")]
        [Required(ErrorMessage = "O campo {0} é requirido.")]
        [EmailAddress(ErrorMessage = "O campo {0} está em formato invalido.")]
        public string Email { get; set; }

        [Required(ErrorMessage = "O campo {0} é requirido.")]
        public string CPF { get; set; }
        public DateTime SignupDate { get; set; }
        [DisplayName("Ativo")]
        public bool Active { get; set; }

        /*[Required(ErrorMessage = "O campo {0} é requirido.")]
        public string Password { get; set; }
        [Required(ErrorMessage = "O campo {0} é requirido.")]
        [Compare("Password", ErrorMessage = "As senhas não coincidem.")]
        public string PasswordCheck { get; set; }*/
    }
}