using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Entities.Concrete;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using WebUI.Models;

namespace WebUI.Controllers
{
    [EnableCors]
    public class LoginController : Controller
    {
        private UserManager<AppUser> _userManager;
        private SignInManager<AppUser> _signInManager;
        public LoginController(UserManager<AppUser> userManager, SignInManager<AppUser> signInManager)
        {
            _userManager = userManager;
            _signInManager = signInManager;
        }
        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public IActionResult GirisYap()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> GirisYap(AppUserSignInModel appUserSignInModel)
        {
            if (ModelState.IsValid)
            {
                var user = await _userManager.FindByNameAsync(appUserSignInModel.UserName);
                if (user != null)
                {
                    var ıdentityResult = await _signInManager.PasswordSignInAsync(appUserSignInModel.UserName, appUserSignInModel.Password, false, false);
                    if (ıdentityResult.Succeeded)
                    {
                        var roller=await _userManager.GetRolesAsync(user);
                        if(roller.Contains("Admin"))
                        {
                            return RedirectToAction("Index", "Admin");
                        }
                    }

                }
            }

            return View();
        }
    }
}
