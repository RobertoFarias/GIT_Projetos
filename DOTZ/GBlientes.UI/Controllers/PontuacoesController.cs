using AutoMapper;
using GBlientes.UI.ViewModels;
using GClientes.App.Interface;
using GClientes.Domain.Entities;
using System.Collections.Generic;
using System.Web.Mvc;

namespace GBlientes.UI.Controllers
{
    public class PontuacoesController : Controller
    {
        // GET: Pontuacoes
        private readonly ISaldoAppService _saldoApp;
        private readonly IClienteAppService _clienteApp;
        private readonly IEmpresaAppService _empresaApp;


        public PontuacoesController(ISaldoAppService saldoApp, 
                                    IClienteAppService clienteApp, 
                                    IEmpresaAppService empresaApp)
        {

            _saldoApp = saldoApp;
            _clienteApp = clienteApp;
            _empresaApp = empresaApp;

        }



        public ActionResult Index()
        {
            var saldoViewModel = Mapper.Map<IEnumerable<Saldo>, IEnumerable<SaldoViewModel>>(_saldoApp.GetAll());
            return View(saldoViewModel);
        }

        // GET: Pontuacoes/Details/5
        public ActionResult Details(int id)
        {
            var saldo = _saldoApp.GetById(id);
            var saldoViewModel = Mapper.Map<Saldo, SaldoViewModel>(saldo);

            return View(saldoViewModel);
        }


        // GET: Pontuacoes/Create
        public ActionResult Create()
        {
            ViewBag.ClienteId = new SelectList(_clienteApp.GetAll(), "ClienteId", "Nome");
            ViewBag.EmpresaId = new SelectList(_empresaApp.GetAll(), "EmpresaId", "Razao");

            return View();
        }

        // POST: Pontuacoes/Create
        [HttpPost]
        public ActionResult Create(SaldoViewModel saldo)
        {
            if (ModelState.IsValid)
            {
                var saldoDomain = Mapper.Map<SaldoViewModel, Saldo>(saldo);
                _saldoApp.Add(saldoDomain);

                return RedirectToAction("Index");
            }

            ViewBag.ClienteId = new SelectList(_clienteApp.GetAll(), "ClienteId", "Nome", saldo.ClienteId);
            ViewBag.EmpresaId = new SelectList(_empresaApp.GetAll(), "EmpresaId", "Razao", saldo.EmpresaId);

            return View(saldo);

        }

        // GET: Pontuacoes/Edit/5
        public ActionResult Edit(int id)
        {
            var saldo = _saldoApp.GetById(id);
            var saldoViewModel = Mapper.Map<Saldo, SaldoViewModel>(saldo);

            ViewBag.ClienteId = new SelectList(_clienteApp.GetAll(), "ClienteId", "Nome", saldoViewModel.ClienteId);
            ViewBag.EmpresaId = new SelectList(_empresaApp.GetAll(), "EmpresaId", "Razao", saldoViewModel.EmpresaId);

            return View(saldoViewModel);
        }


        // POST: Pontuacoes/Edit/5
        [HttpPost]
        public ActionResult Edit(SaldoViewModel saldo)
        {
            if (ModelState.IsValid)
            {
                var saldoDomain = Mapper.Map<SaldoViewModel, Saldo>(saldo);
                _saldoApp.Update(saldoDomain);

                return RedirectToAction("Index");
            }

            ViewBag.ClienteId = new SelectList(_clienteApp.GetAll(), "ClienteId", "Nome", saldo.ClienteId);
            ViewBag.EmpresaId = new SelectList(_empresaApp.GetAll(), "EmpresaId", "Razao", saldo.EmpresaId);

            return View(saldo);

        }


        // GET: Pontuacoes/Delete/5
        public ActionResult Delete(int id)
        {
            var saldo = _saldoApp.GetById(id);
            var saldoViewModel = Mapper.Map<Saldo, SaldoViewModel>(saldo);

            return View(saldoViewModel);
        }

        // POST: Pontuacoes/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            var saldo = _saldoApp.GetById(id);
            _saldoApp.Remove(saldo);

            return RedirectToAction("Index");

        }
    }
}
