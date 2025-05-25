using Core.Service;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Model.Entities;

namespace WebUI.Areas.Admin.Controllers
{
    [Area("Admin"), Authorize]
    public class UserController : Controller
    {
        private readonly ICoreService<User> _db;

        public UserController(ICoreService<User> core)
        {
            _db = core;
        }
        public IActionResult Index()
        {
            return View(_db.GetAll().ToList());
        }
    }
}
