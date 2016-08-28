using GClientes.Domain.ValueObject;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace GBlientes.UI.ViewModels
{
    public class EmpresaViewModel
    {
        [Key]
        public int EmpresaId { get; set; }

        public const int RazaoMaxLength = 50;

        [Required(ErrorMessage = "Preencha o campo Razão")]
        [MaxLength(50, ErrorMessage = "Máximo {0} caracteres")]
        [MinLength(2, ErrorMessage = "Minimo {0} caracteres")]
        public string Razao { get; set; }

    }
}