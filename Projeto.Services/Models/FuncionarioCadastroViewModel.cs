using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace Projeto.Services.Models
{
    public class FuncionarioCadastroViewModel
    {
        [Required(ErrorMessage = "Campo obrigatório")]
        public string Nome { get; set; }

        [Required(ErrorMessage = "Campo obrigatório")]
        public decimal Salario { get; set; }

        [Required(ErrorMessage = "Campo obrigatório")]
        public DateTime DataAdmissao { get; set; }
    }
}