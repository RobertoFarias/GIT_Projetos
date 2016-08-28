using GClientes.App.Interface;
using GClientes.Domain.Entities;
using GClientes.Domain.Interfaces.Services;

namespace GClientes.App
{
    public class SaldoAppService : AppServiceBase<Saldo>, ISaldoAppService
    {

        private readonly ISaldoService _saldoService;

        public SaldoAppService(ISaldoService saldoService)
            : base(saldoService)
        {
            _saldoService = saldoService;
        }

    }
}
