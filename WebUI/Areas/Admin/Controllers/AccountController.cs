using Core.Service;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Model.Entities;
using System.Security.Claims;
using WebUI.Helpers;

namespace WebUI.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class AccountController : Controller
    {
        private readonly ICoreService<User> _db;

        public AccountController(ICoreService<User> service)
        {
            _db = service;
        }
        public IActionResult Login()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Login(string user, string pass)
        {
            pass = PasswordHelper.Sha256Hash(pass);

            var data = _db.GetAll()
                          .Where(x => x.UserName == user && x.Password == pass)
                          .FirstOrDefault();

            if (data is not null)
            {
                var claims = new List<Claim>()
                {
                    new Claim(ClaimTypes.Name, user)
                };

                var identity = new ClaimsIdentity(claims, "Login");
                var principal = new ClaimsPrincipal(identity);
                await HttpContext.SignInAsync(principal);
                return RedirectToAction("Index", "Home");

            }
            else
            {
                ViewBag.LoginError = "Kullanıcı Adı veya Şifre veya Kullanıcı Türü Hatalı..!";
                return View();
            }
        }
        public async Task<IActionResult> Logout()
        {
            await HttpContext.SignOutAsync();

            return RedirectToAction("Login");
        }
    }
}
