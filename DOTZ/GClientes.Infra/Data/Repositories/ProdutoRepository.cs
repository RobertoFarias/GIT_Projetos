using GClientes.Domain.Entities;
using GClientes.Domain.Interfaces.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;

namespace GClientes.Infra.Data.Repositories
{
    public class ProdutoRepository : RepositoryBase<Produto>, IProdutoRepository
    {
        IEnumerable<Produto> IProdutoRepository.BuscarPorNome(string nome)
        {
            return Db.Produtos.Where(p => p.Nome == nome);
        }
    }
  
}
