using GClientes.Domain.Entities;
using GClientes.Domain.Interfaces.Repositories;
using GClientes.Domain.Interfaces.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GClientes.Domain.Services
{
    public class EmpresaService : ServiceBase<Empresa>, IEmpresaService
    {

        private readonly IEmpresaRepository _empresaRepository;


        public EmpresaService(IEmpresaRepository empresaRepository) : base(empresaRepository)
        {
            _empresaRepository = empresaRepository;
        }

    }
}
