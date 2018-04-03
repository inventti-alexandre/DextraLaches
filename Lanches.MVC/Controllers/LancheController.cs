using System.Web.Mvc;
using Lanches.Application.Interfaces;

namespace Lanches.MVC.Controllers
{
    public class LancheController : Controller
    {
        private readonly ILancheAppService _lancheAppService;

        public LancheController(ILancheAppService lancheAppService)
        {
            _lancheAppService = lancheAppService;
        }

        public ActionResult Index()
        {
            return View(_lancheAppService.FindAll());
        }

        public ActionResult Details(int id)
        {
            return View();
        }

        [HttpGet]
        public JsonResult GetLanche(int id)
        {
            return Json(_lancheAppService.FindById(id), JsonRequestBehavior.AllowGet);
        }
    }
}
