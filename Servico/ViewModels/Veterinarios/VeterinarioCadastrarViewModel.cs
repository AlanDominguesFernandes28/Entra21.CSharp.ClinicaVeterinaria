﻿using System.ComponentModel.DataAnnotations;

namespace Entra21.CSharp.ClinicaVeterinaria.Servico.ViewModels.Veterinarios
{
    public class VeterinarioCadastrarViewModel
    {
        [Display(Name = "Nome")]
        [Required(ErrorMessage = "{0} deve ser preeenchido")]
        [MinLength(3,ErrorMessage = "{0} deve conter no minimo {1}")]
        [MaxLength(30, ErrorMessage = "{0} deve conter no maximo {1}")]

        public string Nome { get; set; }

        [Display(Name = "CRMV")]
        [Required(ErrorMessage = "{0} deve ser preeenchido")]
        [StringLength(7, ErrorMessage = "{0} deve conter {1} caracteres" )]

        public string Crmv { get; set; }
    }

}