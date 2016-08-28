using GClientes.App.Interface;
using GClientes.Domain.Entities;
using GClientes.Domain.Interfaces.Services;

namespace GClientes.App
{
    public class EmpresaAppService : AppServiceBase<Empresa>, IEmpresaAppService
    {

        private readonly IEmpresaService _empresaService;


        public EmpresaAppService(IEmpresaService empresaService)
            : base(empresaService)
        {
            _empresaService = empresaService;
        }

      

    }
}
