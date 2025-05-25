using Core.Service;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Cors.Infrastructure;
using Microsoft.AspNetCore.Mvc;
using Model.Entities;

namespace WebUI.Areas.Admin.Controllers
{
    [Area("Admin"), Authorize]


    public class PortfolioController : Controller
    {
        private readonly ICoreService<Portfolio> _db;
        private readonly ICoreService<Category> _cdb;

        public PortfolioController(ICoreService<Portfolio> coreService, ICoreService<Category> core)
        {
            _db = coreService;
            _cdb = core;
        }

        public IActionResult Index()
        {
            var data = _db.GetAll();
            foreach (var item in data)
            {
                item.Category = _cdb.GetById(item.CategoryId);
            }
            return View(data);
        }
        public IActionResult Add()
        {
            ViewBag.CategoryList = _cdb.GetAll();
            return View();
        }
        [HttpPost]
        public IActionResult Add(Portfolio p)
        {
            ViewBag.CategoryList = _cdb.GetAll();
            p.Category = _cdb.GetById(p.CategoryId);
            var result = _db.Create(p);
            if (result)
            {
                return RedirectToAction("Index");
            }
            ViewBag.CreateError = "Portfolyo eklenirken hata oluştu!";
            return View();
        }
        public IActionResult Update(int id)
        {
            ViewBag.CategoryList = _cdb.GetAll();
            return View(_db.GetById(id));
        }

        [HttpPost]
        public IActionResult Update(Portfolio p)
        {
            ViewBag.CategoryList = _cdb.GetAll();
            p.Category = _cdb.GetById(p.CategoryId);
            var result = _db.Update(p);
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
