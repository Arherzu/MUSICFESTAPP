using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace musicfest.Controllers
{
    public class CuentaController : Controller
    {
        
        private UserManager<IdentityUser> _um;
        private SignInManager<IdentityUser> _sim;
        public CuentaController(UserManager<IdentityUser> um, SignInManager<IdentityUser> sim)
        {
            _um = um;
            _sim = sim;
        }

        public IActionResult Registro()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Registro(string correo, string password)
        {
            var identityUser = new IdentityUser(correo);
            identityUser.Email = correo;
            identityUser.EmailConfirmed = true;

            var result = _um.CreateAsync(identityUser, password).Result;

            if (result.Succeeded)
            {
                return RedirectToAction("index", "home");
            }

            foreach (var error in result.Errors)
            {
                ModelState.AddModelError("usuario", error.Description);
            }

            return View();
        }

        public IActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Login(string correo, string password)
        {
            var result = _sim.PasswordSignInAsync(correo, password, false, false).Result;

            if (result.Succeeded)
            {
                return RedirectToAction("index", "home");
            }

            ModelState.AddModelError("usuario", "Datos incorrectos");

            return View();
        }

        public async Task<IActionResult> Logout()
        {
            await _sim.SignOutAsync();
            return RedirectToAction("index", "home");
        }
        
    }
}