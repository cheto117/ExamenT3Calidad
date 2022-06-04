using Microsoft.AspNetCore.Mvc;
using Moq;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using TEJADA_T3.Controllers;
using TEJADA_T3.Models;
using TEJADA_T3.Repository;

namespace TEJADA_T3.TEST
{
    [TestFixture]
    public class Tests
    {
        [Test]
        public void Index()
        {
            var repo = new Mock<IHomeRepository>();
            repo.Setup(o => o.GetHistorias()).Returns(new List<Historia>());

            var controller = new HomeController(repo.Object);
            var view = controller.Index() as ViewResult;

            Assert.AreEqual("Index", view.ViewName);
        }

        [Test]
        public void Raza()
        {
            var repo = new Mock<IHomeRepository>();
            repo.Setup(o => o.GetRazas(1)).Returns(new List<Raza>());

            var controller = new HomeController(repo.Object);
            var view = controller.Raza(1) as JsonResult;

            Assert.AreEqual(null, view.ContentType);
        }

        [Test]
        public void PrivacyGet()
        {
            var repo = new Mock<IHomeRepository>();
            repo.Setup(o => o.GetSexos()).Returns(new List<Sexo>());
            repo.Setup(o => o.GetEspecies()).Returns(new List<Especie>());

            var controller = new HomeController(repo.Object);
            var view = controller.Privacy() as ViewResult;

            Assert.AreEqual("Privacy", view.ViewName);
        }

        [Test]
        public void PrivacyPostGood()
        {
            var repo = new Mock<IHomeRepository>();
            repo.Setup(o => o.SaveHistory(new Historia()));

            var controller = new HomeController(repo.Object);
            var view = controller.Privacy(new Historia()) as RedirectToActionResult;

            Assert.AreEqual("Index", view.ActionName);
        }

        [Test]
        public void PrivacyPostBad()
        {
            var repo = new Mock<IHomeRepository>();
            repo.Setup(o => o.GetSexos()).Returns(new List<Sexo>());
            repo.Setup(o => o.GetEspecies()).Returns(new List<Especie>());

            var controller = new HomeController(repo.Object);
            var view = controller.Privacy(new Historia() { FechaNacimiento = DateTime.Now.AddDays(1)}) as ViewResult;

            Assert.AreEqual("Privacy", view.ViewName);
        }
    }
}