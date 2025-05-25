using Core.Service;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;
using Model.Entities;
using System.IO;

namespace WebUI.Controllers
{
    public class HomeController : Controller
    {
        private readonly ICoreService<SiteSetting> _db;
        public HomeController(ICoreService<SiteSetting> core)
        {
                _db = core;
        }


        public IActionResult Index()
        {

           var settings = _db.GetAll().FirstOrDefault();

            if (settings == null)
            {
                return View();
            }

            var path = HttpContext.Request.Path;

            if (settings.MaintenanceMode == 1 && !path.StartsWithSegments("/Admin"))
            {
                return RedirectToAction("Maintenance", "Home");
            }

            ViewBag.InstagramUrl = settings.InstagramUrl;
            ViewBag.LinkedinUrl = settings.LinkedinUrl;
            ViewBag.FacebookUrl = settings.FacebookUrl;
            ViewBag.YoutubeYrl = settings.YoutubeUrl;
            ViewBag.Xurl = settings.XUrl;
            ViewBag.GithubUrl = settings.GithubUrl;
            ViewBag.SiteTitle = settings.SiteTitle;
            ViewBag.FooterCopy = settings.FooterCopy;
            ViewBag.CvUrl = settings.CvUrl;
            ViewBag.SlaytBackground = settings.SiteBg;

            return View();

            
        }

        public IActionResult Maintenance()
        {
            return View();
        }
    }
}
