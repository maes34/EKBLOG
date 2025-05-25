using Core.Service;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Model.Entities;

namespace WebUI.Areas.Admin.Controllers
{
    [Area("Admin"), Authorize]
    public class AboutController : Controller
    {
        private readonly ICoreService<About> _db;

        public AboutController(ICoreService<About> core)
        {
            _db = core;
        }

        public IActionResult Index()
        {
            var data = _db.GetAll().FirstOrDefault();
            return View(data);
        }
        [HttpPost]
        public IActionResult Update(About about)
        {
            var data = _db.Update(about);
            return RedirectToAction("Index", "About");
        }
    }
}
