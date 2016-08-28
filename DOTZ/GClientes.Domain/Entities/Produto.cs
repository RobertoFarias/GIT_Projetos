using System.Collections.Generic;

namespace GClientes.Domain.Entities
{
    public class Produto: EntityBase
    {

        public int ProdutoId { get; set; }

        public string Nome { get; set; }

        public int Pontos { get; set; }
        
        public int CategoriaId { get; set; }

        public virtual Categoria Categoria { get; set; }
        
    }
}
