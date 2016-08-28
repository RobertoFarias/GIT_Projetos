using System.Collections.Generic;
using GClientes.Domain.Entities;
using GClientes.Domain.Interfaces.Services;
using GClientes.Domain.Interfaces.Repositories;

namespace GClientes.Domain.Services
{
    public class ProdutoService : ServiceBase<Produto>, IProdutoService
    {

        private readonly IProdutoRepository _produtoRepository;

        public ProdutoService(IProdutoRepository produtoRepository)
            : base(produtoRepository)
        {
            _produtoRepository = produtoRepository;
        }

        public IEnumerable<Produto> BuscarPorNome(string nome)
        {
            return _produtoRepository.BuscarPorNome(nome);
        }

    }
}
