using GClientes.Domain.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace GBlientes.UI.ViewModels
{
    public class SaldoViewModel
    {
        [Key]
        public int SaldoId { get; set; }

        public int ClienteId { get; set; }

        public virtual Cliente Cliente { get; set; }

        public int EmpresaId { get; set; }

        public virtual Empresa Empresa { get; set; }
        
        [Required(ErrorMessage = "Preencha a quantidade de pontos")]
        [RegularExpression("([1-9][0-9]*)", ErrorMessage = "Digite apenas números")]
        public int Pontos { get; set; }

    }
}