using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace MF.Application.ViewModels
{
    public class ProdutoViewModel
    {
        public ProdutoViewModel()
        {
            //EstudanteId = Guid.NewGuid();
        }

        [Key]
        public int IdProduto { get; set; }

        [Required(ErrorMessage = "Preencha o campo Nome")]
        [MaxLength(150, ErrorMessage = "Máximo {0} caracteres")]
        [MinLength(2, ErrorMessage = "Mínimo {0} caracteres")]
        public string Descricao { get; set; }

        [Required(ErrorMessage = "Preencha o campo Sobrenome")]
        [MaxLength(150, ErrorMessage = "Máximo {0} caracteres")]
        [MinLength(2, ErrorMessage = "Mínimo {0} caracteres")]
        public string Sigla { get; set; }

        //[Required(ErrorMessage = "Preencha o campo E-mail")]
        //[MaxLength(100, ErrorMessage = "Máximo {0} caracteres")]
        //[EmailAddress(ErrorMessage = "Preencha um E-mail válido")]
        //[DisplayName("E-mail")]
        //public string Email { get; set; }

        //[Required(ErrorMessage = "Preencha o campo CPF")]
        //[MaxLength(11, ErrorMessage = "Máximo {0} caracteres")]
        //[DisplayName("CPF")]
        //public string CPF { get; set; }

        [ScaffoldColumn(false)]
        public DateTime DtCadastro { get; set; }

        [Required(ErrorMessage = "Preencha o campo Sobrenome")]
        [MaxLength(150, ErrorMessage = "Máximo {0} caracteres")]
        [MinLength(2, ErrorMessage = "Mínimo {0} caracteres")]
        public string UsuCadastro { get; set; }

        //[DisplayName("Ativo?")]
        //public bool Ativo { get; set; }
    }
}