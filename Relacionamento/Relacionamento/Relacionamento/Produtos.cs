using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Relacionamento
{
    public class Produto
    {

        public int ProdutoId { get; set; }

        public string Nome { get; set; }

        public int Pontos { get; set; }

        public int CategoriaId { get; set; }

        public virtual Categoria Categoria { get; set; }

    }
}
