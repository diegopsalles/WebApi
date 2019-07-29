using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace Projeto.Services.Models
{
    public class DependenteEdicaoViewModel
    {
        [Required(ErrorMessage = "Campo obrigatório")]
        public int IdDependente { get; set; }

        [Required(ErrorMessage = "Campo obrigatório")]
        public string Nome { get; set; }

        [Required(ErrorMessage = "Campo obrigatório")]
        public DateTime DataNascimento { get; set; }

        [Required(ErrorMessage = "Campo obrigatório")]
        public int IdFuncionario { get; set; }
    }
}