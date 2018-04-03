using System.Web.Mvc;
using Lanches.Application.Interfaces;

namespace Lanches.MVC.Controllers
{
    public class IngredienteController : Controller
    {
        private readonly IIngredienteAppService _ingredienteAppService;

        public IngredienteController(IIngredienteAppService ingredienteAppService)
        {
            _ingredienteAppService = ingredienteAppService;
        }

        // GET: Ingrediente
        public ActionResult Index()
        {
            return View(_ingredienteAppService.FindAll());
        }

        // GET: Ingrediente/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Ingrediente/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Ingrediente/Create
        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Ingrediente/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Ingrediente/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Ingrediente/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Ingrediente/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}

