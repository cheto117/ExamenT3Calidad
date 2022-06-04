using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using TEJADA_T3.Models;
using TEJADA_T3.Models;
using TEJADA_T3.Repository;

namespace TEJADA_T3.Controllers
{
    [Authorize]
    public class HomeController : Controller
    {
        private readonly IHomeRepository context;

        public HomeController(IHomeRepository context)
        {
            this.context = context;
        }

        public IActionResult Index()
        {
            var historias = context.GetHistorias();
            return View("Index", historias);
        }

        public IActionResult Raza(int IdEspecie)
        {
            return Json(context.GetRazas(IdEspecie));
        }

        [HttpGet]
        public IActionResult Privacy()
        {
            ViewBag.Sexo = context.GetSexos();
            ViewBag.Especie = context.GetEspecies();
            return View("Privacy", new Historia());
        }

        [HttpPost]
        public IActionResult Privacy(Historia historia)
        {
            if (historia.FechaNacimiento > DateTime.Now || historia.FechaRegistro > DateTime.Now)
                ModelState.AddModelError("Fecha", "La fecha no puede ser mayor a la fecha actual");
            if (ModelState.IsValid)
            {
                context.SaveHistory(historia);
                return RedirectToAction("Index");
            }
            ViewBag.Sexo = context.GetSexos();
            ViewBag.Especie = context.GetEspecies();
            return View("Privacy");
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
