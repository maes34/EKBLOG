using Core.Service;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Model.Entities;

namespace WebUI.Areas.Admin.Controllers
{
    [Area("Admin"), Authorize]
    public class UserSkillController : Controller
    {
        private readonly ICoreService<UserSkill> _db;

        public UserSkillController(ICoreService<UserSkill> core)
        {
            _db = core;
        }
        public IActionResult Index()
        {
            var result = _db.GetAll();

            return View(result);
        }
        public IActionResult Add()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Add(UserSkill u)
        {
            var result = _db.Create(u);
            if (result)
            {
                return RedirectToAction("Index");
            }
            ViewBag.CreateError = "Eklenirken hata oluştu!";
            return View();
        }
        public IActionResult Update(int id)
        {
            return View(_db.GetById(id));
        }
        [HttpPost]
        public IActionResult Update(UserSkill u)
        {
            var result = _db.Update(u);
            if (result)
            {
                return RedirectToAction("Index");
            }
            ViewBag.ErrorPanel = "Bir Hata Oluştu!";
            return View();
        }

        public IActionResult Delete(int id) => _db.Delete(_db.GetById(id)) ? RedirectToAction("Index") : View();

    }
}
