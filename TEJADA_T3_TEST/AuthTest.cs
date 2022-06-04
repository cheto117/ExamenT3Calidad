using NUnit.Framework;
using System.Collections.Generic;
using Moq;
using TEJADA_T3.Repository;
using TEJADA_T3.Controllers;
using Microsoft.AspNetCore.Mvc;
using TEJADA_T3.Models;

namespace TEJADA_T3.TEST
{
    [TestFixture]
    class AuthTest
    {
        [Test]
        public void LoginGet()
        {
            var controller = new AuthController(null, null);
            var view = controller.Login() as ViewResult;

            Assert.AreEqual("Login", view.ViewName);
        }

        [Test]
        public void LoginPostGood()
        {
            var repo = new Mock<IAuthRepository>();
            repo.Setup(o => o.GetUsuario("User","user")).Returns(new Usuario());

            var claim = new Mock<IClaimService>();

            var controller = new AuthController(repo.Object,claim.Object);
            var view = controller.Login("User", "user") as RedirectToActionResult;

            Assert.AreEqual("Index", view.ActionName);
        }

        [Test]
        public void LoginPostBad()
        {
            var repo = new Mock<IAuthRepository>();
            repo.Setup(o => o.GetUsuario("User", "user")).Returns(new Usuario());

            var claim = new Mock<IClaimService>();

            var controller = new AuthController(repo.Object, claim.Object);
            var view = controller.Login(null, null) as ViewResult;

            Assert.AreEqual("Login", view.ViewName);
        }

        [Test]
        public void Logout()
        {
            var claim = new Mock<IClaimService>();

            var controller = new AuthController(null, claim.Object);
            var view = controller.LogOut() as RedirectToActionResult;

            Assert.AreEqual("Login", view.ActionName);
        }

        [Test]
        public void RegisterGet()
        {
            var controller = new AuthController(null, null);
            var view = controller.Register() as ViewResult;

            Assert.AreEqual("Register", view.ViewName);
        }

        [Test]
        public void RegisterPostGood()
        {
            var repo = new Mock<IAuthRepository>();
            repo.Setup(o => o.GetUsuarios()).Returns(new List<Usuario>());
            repo.Setup(o => o.SaveUsuario(new Usuario()));
            var claim = new Mock<IClaimService>();

            var controller = new AuthController(repo.Object, claim.Object);
            var view = controller.Register(new Usuario() { Password= "user"}, "user") as RedirectToActionResult;

            Assert.AreEqual("Login", view.ActionName);
        }

        [Test]
        public void RegisterPostBad()
        {
            var repo = new Mock<IAuthRepository>();
            repo.Setup(o => o.GetUsuarios()).Returns(new List<Usuario>());

            var claim = new Mock<IClaimService>();

            var controller = new AuthController(repo.Object, claim.Object);
            var view = controller.Register(new Usuario() { Password = "1223"}, "1234") as ViewResult;

            Assert.AreEqual("Register", view.ViewName);
        }
    }
}
