using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Testing.UI.Controllers;
using Testing.UI.Tests.Data;
using Testing.BLL.ViewModels;
using System.Web.Mvc;

namespace Testing.UI.Tests.Controllers.Positive {

    [TestClass]
    public class UserControllerTest {

        [TestMethod]
        public void IndexTest() {
            var controller = new UserController();
            ViewResult result = controller.Index() as ViewResult;
            Assert.IsNotNull(result);
        }

        [TestMethod]
        public void DetailsTest() {
            UserController controller = new UserController();
            ViewResult result = controller.Details(1) as ViewResult;
            Assert.IsNotNull(result);
        }

        [TestMethod]
        public void CreateGetTest() {
            UserController controller = new UserController();
            var result = controller.Create() as ViewResult;
            Assert.IsNotNull(result);
        }

        [TestMethod]
        public void CreatePostTest() {
            UserController controller = new UserController();
            RedirectToRouteResult result = controller.Create(DataProvider.PositiveUserData[0]) as RedirectToRouteResult;
            Assert.AreEqual("Index", result.RouteValues["action"]);
        }

        [TestMethod]
        public void EditGetTest() {
            UserController controller = new UserController();
            ViewResult result = controller.Edit(5) as ViewResult;
            Assert.IsNotNull(result);   
        }

        [TestMethod]
        public void EditPostTest() {
            UserController controller = new UserController();
            RedirectToRouteResult result = controller.Edit(DataProvider.PositiveUserData[0]) as RedirectToRouteResult;
            Assert.AreEqual("Index", result.RouteValues["action"]);
        }        

        [TestMethod]
        public void DeleteViewTest() {
            UserController controller = new UserController();
            RedirectToRouteResult result = controller.Delete(1) as RedirectToRouteResult;
            Assert.AreEqual("Index", result.RouteValues["action"]);
        }

    }

}