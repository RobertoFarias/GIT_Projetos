using GClientes.App.Interface;
using GClientes.Domain.Entities;
using GClientes.Domain.Interfaces.Services;

namespace GClientes.App
{
    public class CategoriaAppService: AppServiceBase<Categoria>, ICategoriaAppService
    {

        private readonly ICategoriaService _categoriaService;

        public CategoriaAppService(ICategoriaService categoriaService)
            : base(categoriaService)
        {
            _categoriaService = categoriaService;
        }

    }
}
