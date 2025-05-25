using Core.Service;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Model.Entities;

namespace WebUI.Areas.Admin.Controllers
{
    [Area("Admin"), Authorize]
    public class CategoryController : Controller
    {
        private readonly ICoreService<Category> _db;

        public CategoryController(ICoreService<Category> core)
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
        public IActionResult Add(Category c)
        {
            var result = _db.Create(c);
            if (result)
            {
                return RedirectToAction("Index");
            }
            ViewBag.CreateError = "Kategori eklenirken hata oluştu!";
            return View();
        }
        public IActionResult Update(int id)
        {
            return View(_db.GetById(id));
        }

        [HttpPost]
        public IActionResult Update(Category c)
        {
            var result = _db.Update(c);
            if (result)
            {
                return RedirectToAction("Index");
            }
            ViewBag.ErrorPanel = "Bir Hata Oluştu!";
            return View();
        }
        public IActionResult Delete(int id)
        {
            var result = _db.Delete(_db.GetById(id));
            if (result)
            {
                return RedirectToAction("Index");
            }
            ViewBag.DeleteError = "Kayıt Silinemedi";
            return View();
        }
    }
}
