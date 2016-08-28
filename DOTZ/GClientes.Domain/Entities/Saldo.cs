using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GClientes.Domain.Entities
{
    public class Saldo : EntityBase
    {

        public int SaldoId { get; set; }

        public int ClienteId { get; set; }

        public virtual Cliente Cliente { get; set; }

        public int EmpresaId { get; set; }

        public virtual Empresa Empresa { get; set; }

        public int Pontos { get; set; }

    }
}
