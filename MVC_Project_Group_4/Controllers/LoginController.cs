using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using MVC_Project_Group_4.Models.Concrete;
using MVC_Project_Group_4.Models.ViewModels;

namespace MVC_Project_Group_4.Controllers
{
    public class LoginController : Controller
    {
        private readonly SignInManager<Uye> _signInManager;
        private readonly UserManager<Uye> _userManager;

        public LoginController(SignInManager<Uye> signInManager, UserManager<Uye> userManager)
        {
            _signInManager = signInManager;
            _userManager = userManager;
        }

        public IActionResult Login()
        {

            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Login(LoginVM login)
        {
            if (!ModelState.IsValid)
            {
                return View(login);
            }

            var uye = await _userManager.FindByEmailAsync(login.EMail);

            if (uye == null || !_userManager.CheckPasswordAsync(uye, login.Password).Result)
            {
                ModelState.AddModelError(string.Empty, "Kullanıcı adı veya şifre yanlış...");
                return View(login);
            }

            await _signInManager.SignInAsync(uye, false);

            


            if(User.IsInRole("Yonetici"))
            {
                return RedirectToAction("Index", "YoneticiPanel", new { area = "YoneticiPaneli" });
            }
            
            
            return RedirectToAction("Index", "UyePanel", new { area = "UyePaneli" });

            
          

        }
  
        public async Task<IActionResult> LogOut()
        {
            await _signInManager.SignOutAsync();

            return RedirectToAction("Index", "Home");
            
        }

        public IActionResult Register()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Register(RegisterVM register)
        {

            if (ModelState.IsValid)
            {
                Uye uye = new Uye();

                uye.Adres = register.Address;
                uye.UserName = register.Email;
                uye.Email = register.Email;

                uye.PasswordHash = _userManager.PasswordHasher.HashPassword(uye, register.Password);

                var result = await _userManager.CreateAsync(uye);

                if (result.Succeeded)
                {
                    await _userManager.AddToRoleAsync(uye, "Uye");
                    return RedirectToAction("Login", "Login");
                }
            }

            ModelState.AddModelError("", "Kullanıcı eklenirken hata oluştu.");

            return View();
        }

    }
}
