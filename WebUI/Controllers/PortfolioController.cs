using Core.Service;
using Microsoft.AspNetCore.Mvc;
using Model.Entities;

namespace WebUI.Controllers
{
    public class PortfolioController : Controller
    {
        private readonly ICoreService<Portfolio> _db;
        private readonly ICoreService<Category> _cdb;

        public PortfolioController(ICoreService<Portfolio> core, ICoreService<Category> coreCategory)
        {
            _db = core;
            _cdb = coreCategory;
        }

        public IActionResult Index(int page = 1, int pageSize = 16)
        {

            ViewBag.TotalPages = (int)Math.Ceiling((double)_db.GetCount() / pageSize);
            ViewBag.CurrentPage = page;
            return View(_db.GetRecords(page, pageSize));
        }
        public IActionResult Details(int id)
        {
            var portfolioData = _db.GetById(id);
            ViewBag.CategoryList = _cdb.GetAll();
            if (portfolioData is not null)
            {
                return View(portfolioData);
            }

            ViewBag.ErrorProductDetail = "İçeriğe ulaşılamadı.";
            return RedirectToAction("Index");
        }
    }
}
