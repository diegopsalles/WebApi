using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations; //importando

namespace Projeto.Services.Models
{
    public class DependenteCadastroViewModel
    {
        [Required(ErrorMessage = "Campo obrigatório")]
        public string Nome { get; set; }

        [Required(ErrorMessage = "Campo obrigatório")]
        public DateTime DataNascimento { get; set; }

        [Required(ErrorMessage = "Campo obrigatório")]
        public int IdFuncionario { get; set; }
    }
}