using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Relacionamento
{
    public class Categoria 
    {

        public int CategoriaId { get; set; }

        public const int CategoriaMaxLength = 50;
        public string Nome { get; set; }

        public virtual IEnumerable<Categoria> Categorias { get; set; }
    }
}
