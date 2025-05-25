using Core.Service;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Model.Entities;

namespace WebUI.Areas.Admin.Controllers
{
    [Area("Admin"), Authorize]
    public class ContactController : Controller
    {
        private readonly ICoreService<Contact> _db;


        public ContactController(ICoreService<Contact> core)
        {
            _db = core;
        }

        public IActionResult Index()
        {
            var result = _db.GetAll().ToList();
            return View(result);
        }
        public IActionResult Details(int id)
        {
            var contactData = _db.GetById(id);

            if (contactData is not null)
            {
                if (!contactData.Read)
                {
                    contactData.Read = true;
                    _db.Update(contactData);
                }
                return View(contactData);
            }

            ViewBag.ErrorContactDetail = "Bir sorunla karşılaşıldı.";
            return RedirectToAction("Index");
        }
        public IActionResult Delete(int id) => _db.Delete(_db.GetById(id)) ? RedirectToAction("Index") : View();

    }
}
