using AutoMapper;
using GBlientes.UI.ViewModels;
using GClientes.App.Interface;
using GClientes.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace GBlientes.UI.Controllers
{
    public class CategoriasController : Controller
    {

        private readonly ICategoriaAppService _categoriaApp;


        public CategoriasController(ICategoriaAppService categoriaApp)
        {
            _categoriaApp = categoriaApp;
        }


        // GET: Categoria
        public ActionResult Index()
        {

            var categoriaViewModel = Mapper.Map<IEnumerable<Categoria>, IEnumerable<CategoriaViewModel>>(_categoriaApp.GetAll());
            return View(categoriaViewModel);

        }

        // GET: Categoria/Details/5
        public ActionResult Details(int id)
        {
            var categoria = _categoriaApp.GetById(id);
            var categoriaViewModel = Mapper.Map<Categoria, CategoriaViewModel>(categoria);

            return View(categoriaViewModel);
        }

        // GET: Categoria/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Categoria/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(CategoriaViewModel categoria)
        {

            if (ModelState.IsValid)
            {
                
                var categoriaDomain = Mapper.Map<CategoriaViewModel, Categoria>(categoria);
                _categoriaApp.Add(categoriaDomain);


                return RedirectToAction("Index");
            }

            return View(categoria);

        }

        // GET: Categoria/Edit/5
        public ActionResult Edit(int id)
        {
            var categoria = _categoriaApp.GetById(id);
            var categoriaViewModel = Mapper.Map<Categoria, CategoriaViewModel>(categoria);

            return View(categoriaViewModel);
        }

        // POST: Categoria/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(CategoriaViewModel categoria)
        {
            if (ModelState.IsValid)
            {

                var categoriaDomain = Mapper.Map<CategoriaViewModel, Categoria>(categoria);

                _categoriaApp.Update(categoriaDomain);

                return RedirectToAction("Index");
            }

            return View(categoria);


        }

        // GET: Categoria/Delete/5
        public ActionResult Delete(int id)
        {
            var categoria = _categoriaApp.GetById(id);
            var categoriaViewModel = Mapper.Map<Categoria, CategoriaViewModel>(categoria);

            return View(categoriaViewModel);
        }

        // POST: Categoria/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, FormCollection collection)
        {

            var categoria = _categoriaApp.GetById(id);
            _categoriaApp.Remove(categoria);

            return RedirectToAction("Index");

        }
    }
}
