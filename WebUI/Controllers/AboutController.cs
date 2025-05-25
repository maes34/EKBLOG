using Core.Service;
using Microsoft.AspNetCore.Mvc;
using Model.Entities;
using WebUI.Views.ViewModel;

namespace WebUI.Controllers
{
    public class AboutController : Controller
    {
        private readonly ICoreService<About> _adb;
        private readonly ICoreService<UserSkill> _usdb;



        public AboutController(ICoreService<About> db, ICoreService<UserSkill> userSkillSetting)
        {
            _adb = db;
            _usdb = userSkillSetting;
        }
        public IActionResult Index()
        {
            var data = _adb.GetAll().FirstOrDefault();
            var skills = _usdb.GetAll();
            var vm = new AboutViewModel
            {
                About = data,
                UserSkills = skills
            };

            return View(vm);
        }
    }
}
