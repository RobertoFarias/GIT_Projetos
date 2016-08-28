using GClientes.App.Interface;
using GClientes.Domain.Entities;
using GClientes.Domain.Interfaces.Services;

namespace GClientes.App
{
    public class ClienteAppService : AppServiceBase<Cliente>, IClienteAppService
    {

        private readonly IClienteService _clienteService;

        public ClienteAppService(IClienteService clienteService)
            : base(clienteService)
        {
            _clienteService = clienteService;
        }

       
    }
}
