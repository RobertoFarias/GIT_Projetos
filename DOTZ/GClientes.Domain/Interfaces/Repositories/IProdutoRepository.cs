using GClientes.Domain.Entities;
using System.Collections.Generic;

namespace GClientes.Domain.Interfaces.Repositories
{
    public interface IProdutoRepository : IRepositoryBase<Produto>
    {

        IEnumerable<Produto> BuscarPorNome(string nome);

    }
}
