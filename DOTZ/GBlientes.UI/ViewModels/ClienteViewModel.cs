using GClientes.Domain.ValueObject;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace GBlientes.UI.ViewModels
{
    public class ClienteViewModel
    {

        [Key]
        public int ClienteId { get; set; }


        [Required(ErrorMessage = "Preencha o campo Nome")]
        [MaxLength(50, ErrorMessage = "Máximo {0} caracteres")]
        [MinLength(2, ErrorMessage = "Minimo {0} caracteres")]
        public string Nome { get; set; }


        [Required(ErrorMessage = "Preencha o campo Sobrenome")]
        [MaxLength(50, ErrorMessage = "Máximo {0} caracteres")]
        [MinLength(2, ErrorMessage = "Mínimo {0} caracteres")]
        public string Sobrenome { get; set; }
        
        
        [Required(ErrorMessage = "Preencha o campo E-mail")]
        [MaxLength(254, ErrorMessage = "Máximo {0} caracteres")]
        [EmailAddress(ErrorMessage = "Preencha um E-mail válido")]
        [DisplayName("E-mail")]
        public string Endereco_Email { get; set; }


        public Email Email { get; set; }


        //public Endereco Endereco { get;  set; }

        //public bool Ativo { get; set; }

        //public virtual IEnumerable<ProdutoViewModel> Produtos { get; set; }

    }
}