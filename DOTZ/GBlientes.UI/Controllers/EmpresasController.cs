using AutoMapper;
using GBlientes.UI.ViewModels;
using GClientes.App.Interface;
using GClientes.Domain.Entities;
using System.Collections.Generic;
using System.Web.Mvc;

namespace GBlientes.UI.Controllers
{
    public class EmpresasController : Controller
    {

        private readonly IEmpresaAppService _empresaApp;


        public EmpresasController(IEmpresaAppService empresaApp)
        {
            _empresaApp = empresaApp;
        }


        // GET: Empresas
        public ActionResult Index()
        {
            var empresaViewModel = Mapper.Map<IEnumerable<Empresa>, IEnumerable<EmpresaViewModel>>(_empresaApp.GetAll());
            return View(empresaViewModel);

        }

        // GET: Empresas/Details/5
        public ActionResult Details(int id)
        {
            var empresa = _empresaApp.GetById(id);
            var empresaViewModel = Mapper.Map<Empresa, EmpresaViewModel>(empresa);

            return View(empresaViewModel);
        }

        // GET: Empresas/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Empresas/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(EmpresaViewModel empresa)
        {
            if (ModelState.IsValid)
            {
                
                var empresaDomain = Mapper.Map<EmpresaViewModel, Empresa>(empresa);
                _empresaApp.Add(empresaDomain);


                return RedirectToAction("Index");
            }

            return View(empresa);
        }

        // GET: Empresas/Edit/5
        public ActionResult Edit(int id)
        {
            var empresa = _empresaApp.GetById(id);
            var empresaViewModel = Mapper.Map<Empresa, EmpresaViewModel>(empresa);

            return View(empresaViewModel);
        }

        // POST: Empresas/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(EmpresaViewModel empresa)
        {

            if (ModelState.IsValid)
            {

                var empresaDomain = Mapper.Map<EmpresaViewModel, Empresa>(empresa);

                _empresaApp.Update(empresaDomain);

                return RedirectToAction("Index");
            }

            return View(empresa);

        }

        // GET: Empresas/Delete/5
        public ActionResult Delete(int id)
        {
            var empresa = _empresaApp.GetById(id);
            var empresaViewModel = Mapper.Map<Empresa, EmpresaViewModel>(empresa);

            return View(empresaViewModel);
        }

        // POST: Empresas/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, FormCollection collection)
        {
            var empresa = _empresaApp.GetById(id);
            _empresaApp.Remove(empresa);

            return RedirectToAction("Index");
        }
    }
}
