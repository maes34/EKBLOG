using Azure;
using Core.Service;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Model.Entities;

namespace WebUI.Areas.Admin.Controllers
{
    [Area("Admin"), Authorize]
    public class SiteSettingController : Controller
    {
        private readonly ICoreService<SiteSetting> _db;

        public SiteSettingController(ICoreService<SiteSetting> core)
        {
            _db = core;
        }

        public IActionResult Index()
        {
            var data = _db.GetAll().FirstOrDefault();
            return View(data);
        }
        [HttpPost]
        public IActionResult Update(SiteSetting setting)
        {
            var data = _db.Update(setting);
            return RedirectToAction("Index");
        }
    }
}
