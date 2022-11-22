using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.ComponentModel.DataAnnotations;

namespace FormBank.Models
{
    public class Person : Controller
    {
        [Required(ErrorMessage = "Preencha seu Nome.")]
        [MinLength(3)]
        [StringLength(10)]
        [RegularExpression("^((?!^Nome$)[a-zA-Z '])+$", ErrorMessage = "O nome não pode conter carácteres especiais.")]
        public string Nome { get; set;}

        [Required(ErrorMessage ="Preencha seu Sobrenome.")]
        [MinLength(4)]
        [StringLength(10)]
        [RegularExpression("^((?!^Nome$)[a-zA-Z '])+$", ErrorMessage = "O Sobrenome não pode conter carácteres especiais.")]
        public string Sobrenome { get; set; }

        [Required(ErrorMessage = "Informe o seu email")]
        [RegularExpression(".+\\@.+\\..+", ErrorMessage = "Informe um email válido...")]
        public string Email { get; set; }

        [Required]
        [Range(18, 100, ErrorMessage = "Você tem que ter entre 18 e 100 anos")]
        public int Idade { get; set; }

        [Required(ErrorMessage = "Preencha corretamente o campo")]
        [MinLength(14)]
        [MaxLength(14)]
        public int CPF { get; set; }

        [Required(ErrorMessage = "Preencha corretamente o campo")]
        [MinLength(14)]
        [MaxLength(14)]
        public int CNPJ { get; set; }

        public string TipoUsuario { get; set; }
    }
   
   
}