using GClientes.Domain.Entities;
using System.Collections.Generic;

namespace GClientes.Domain.Interfaces.Services
{
    public interface IProdutoService: IServiceBase<Produto>
    {

        IEnumerable<Produto> BuscarPorNome(string nome);

    }
}
