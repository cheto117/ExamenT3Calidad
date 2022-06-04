using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Security.Claims;
using TEJADA_T3.Models;
using TEJADA_T3.Repository;

namespace TEJADA_T3.Controllers
{
    public class AuthController : Controller
    {
        private readonly IAuthRepository context;
        private readonly IClaimService claim;

        public AuthController(IAuthRepository context, IClaimService claim)
        {
            this.context = context;
            this.claim = claim;
        }

        [HttpGet]
        public IActionResult Login()
        {
            return View("Login");
        }
        [HttpPost]
        public IActionResult Login(string username, string password)
        {
            var user = context.GetUsuario(username, password);

            if (user != null)
            {
                var claims = new List<Claim> {
                    new Claim(ClaimTypes.Name, username)
                };

                var claimsIdentity = new ClaimsIdentity(claims, CookieAuthenticationDefaults.AuthenticationScheme);
                var claimsPrincipal = new ClaimsPrincipal(claimsIdentity);
                claim.SetHttpContext(HttpContext);
                claim.Login(claimsPrincipal);
                return RedirectToAction("Index", "Home");
            }
            ModelState.AddModelError("Login", "Usuario o contraseña incorrectos");
            return View("Login");
        }

        [HttpGet]
        public IActionResult LogOut()
        {
            claim.SetHttpContext(HttpContext);
            claim.Logout();
            return RedirectToAction("Login");
        }

        [HttpGet]
        public IActionResult Register()
        {
            return View("Register", new Usuario()); ;
        }

        [HttpPost]
        public IActionResult Register(Usuario usuario, string passwordConf)
        {
            if (usuario.Password != passwordConf)
                ModelState.AddModelError("PasswordConf", "Las contraseñas no coinciden");

            var usuarios = context.GetUsuarios();
            foreach (var item in usuarios)
            {
                if (item.Username == usuario.Username)
                    ModelState.AddModelError("Username", "Este usuario ya existe, intenta otro");
            }

            if (ModelState.IsValid)
            {
                context.SaveUsuario(usuario);
                return RedirectToAction("Login");
            }
            else
                return View("Register", usuario);
        }
    }
}
