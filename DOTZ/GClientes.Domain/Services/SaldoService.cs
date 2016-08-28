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
    public class SaldoService : ServiceBase<Saldo>, ISaldoService
    {

        private readonly ISaldoRepository _saldoRepository;

        public SaldoService(ISaldoRepository saldoRepository)
            : base(saldoRepository)
        {
            _saldoRepository = saldoRepository;
        }


    }
}
