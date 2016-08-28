using GClientes.App.Interface;
using GClientes.Domain.Entities;
using GClientes.Domain.Interfaces.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GClientes.App
{
    public class ProdutoAppService : AppServiceBase<Produto>, IProdutoAppService
    {

        private readonly IProdutoService _produtoService;

        public ProdutoAppService(IProdutoService produtoService)
            : base(produtoService)
        {
            _produtoService = produtoService;
        }

        public IEnumerable<Produto> BuscarPorNome(string nome)
        {
            return _produtoService.BuscarPorNome(nome);
        }

    }
}
