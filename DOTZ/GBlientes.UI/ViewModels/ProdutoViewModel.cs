using System.ComponentModel.DataAnnotations;

namespace GBlientes.UI.ViewModels
{
    public class ProdutoViewModel
    {

        [Key]
        public int ProdutoId { get; set; }
        
        [Required(ErrorMessage = "Preencha o campo Nome")]
        [MaxLength(50, ErrorMessage = "Máximo {0} caracteres")]
        [MinLength(2, ErrorMessage = "Mínimo {0} caracteres")]
        public string Nome { get; set; }


        [Required(ErrorMessage = "Preencha a quantidade de pontos")]
        [RegularExpression("([1-9][0-9]*)", ErrorMessage ="Digite apenas números")]
        public int Pontos { get; set; }
                       
        public int CategoriaId { get; set; }
       
        public virtual CategoriaViewModel Categoria { get; set; }

    }
}