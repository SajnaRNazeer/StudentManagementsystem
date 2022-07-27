using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Mvc;
using StudentManagementsystem.Models;
using System.Linq;
using System.Security.Claims;

namespace StudentManagementsystem.Controllers
{
    public class AccountController : Controller
    {
        private readonly SMSContext _context;
        public AccountController(SMSContext context)
        {
            _context = context;
        }
        public IActionResult Login()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Login(string EmailId, string Userpassword, [Bind("EmailId, Userpassword")] Login log)
        {
            if (!string.IsNullOrEmpty(EmailId) && string.IsNullOrEmpty(Userpassword))
            {
                return RedirectToAction("Login");
            }
            bool isAuthenticated = false;
            ClaimsIdentity identity = null;
            bool isValid = _context.Login.Any(m => m.EmailId == log.EmailId && m.Userpassword == log.Userpassword);
            if (isValid)
            {
                identity = new ClaimsIdentity(new[]
                {
                    new Claim(ClaimTypes.Email,EmailId),

                }, CookieAuthenticationDefaults.AuthenticationScheme);
                isAuthenticated = true;
            }

            if (isAuthenticated)
            {
                var principal = new ClaimsPrincipal(identity);
                var login = HttpContext.SignInAsync(CookieAuthenticationDefaults.AuthenticationScheme, principal);
                return RedirectToAction("Index", "Students");
            }
            else
            {
                ModelState.AddModelError("", "Invalid EmailId or Password");
            }
            return View();
        }
        public IActionResult LogOut()
        {
            var login = HttpContext.SignOutAsync(CookieAuthenticationDefaults.AuthenticationScheme);
            return RedirectToAction("Login", "Account");
        }
    }
}
