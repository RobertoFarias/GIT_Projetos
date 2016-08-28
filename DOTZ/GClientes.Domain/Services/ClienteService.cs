using GClientes.Domain.Entities;
using GClientes.Domain.Interfaces.Services;
using System.Collections.Generic;
using GClientes.Domain.Interfaces.Repositories;
using System.Linq;

namespace GClientes.Domain.Services
{
    public class ClienteService : ServiceBase<Cliente>, IClienteService  
    {

        private readonly IClienteRepository _clienteRepository;


        public ClienteService(IClienteRepository clienteRepository) : base(clienteRepository)
        {
            _clienteRepository = clienteRepository;
        }

    
    }
}
