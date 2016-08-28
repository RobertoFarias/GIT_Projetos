using GClientes.Domain.Entities;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace GBlientes.UI.ViewModels
{
    public class CategoriaViewModel
    {
        [Key]
        public int CategoriaId { get; set; }

        public const int CategoriaMaxLength = 50;

        [Required(ErrorMessage = "Preencha o campo Categoria")]
        [MaxLength(50, ErrorMessage = "Máximo {0} caracteres")]
        [MinLength(2, ErrorMessage = "Minimo {0} caracteres")]
        public string Nome { get; set; }
        
        public virtual IEnumerable<CategoriaViewModel> Categorias { get; set; }

    }
}