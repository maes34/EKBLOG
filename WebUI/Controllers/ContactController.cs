using Microsoft.AspNetCore.Mvc;
using Core.Service;
using Model.Entities;

namespace WebUI.Controllers
{
    public class ContactController : Controller
    {
        private readonly ICoreService<SiteSetting> _sdb;
        private readonly ICoreService<Contact> _adb;


        public ContactController(ICoreService<SiteSetting> siteSettings, ICoreService<Contact> aboutsettings)
        {
            _sdb = siteSettings;
            _adb = aboutsettings;
        }

        public IActionResult Index()
        {
            var settings = _sdb.GetAll().FirstOrDefault();
            var result = _adb.GetAll().FirstOrDefault();

            var path = HttpContext.Request.Path;

            if (settings.MaintenanceMode == 1 && !path.StartsWithSegments("/Admin"))
            {
                return RedirectToAction("Maintenance", "Home");
            }

            ViewBag.contactphone = settings.PhoneNumber;
            ViewBag.mail = settings.ContactMail;
            ViewBag.adress = settings.Adress;

            return View();
        }
        [HttpPost]
        public IActionResult Add(Contact c)
        {
            var result = _adb.Create(c);
            if (result)
            {
                TempData["SuccessMessage"] = "Başarılı bir şekilde gönderildi";
                return RedirectToAction("Index");

                
            }
            ViewBag.MessageError = "Mesaj gönderilirken bir hata oluştu!";
            return View();
        }
    }
}
