using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Testing.UI.Controllers;
using Testing.UI.Tests.Data;
using System.Web.Mvc;
using Testing.BLL.ViewModels;

namespace Testing.UI.Tests.Controllers.Negative {

    [TestClass]
    public class AuthenticationControllerTest {

        [TestMethod]
        public void LoginGetTest() {
            AuthenticationController controller = new AuthenticationController();
            ViewResult result = controller.Login() as ViewResult;
            Assert.IsNotNull(result);
        }

        [TestMethod]
        public void LoginPostTest() {
            AuthenticationController controller = new AuthenticationController();
            RedirectToRouteResult result = controller.Login(DataProvider.NegativeLoginData[0]) as RedirectToRouteResult;
            Assert.AreEqual("Index", result.RouteValues["action"]);            
        }

        [TestMethod]
        public void SignUpGetTest() {
            AuthenticationController controller = new AuthenticationController();
            ViewResult result = controller.SignUp() as ViewResult;
            Assert.IsNotNull(result);
        }

        [TestMethod]
        public void SignUpPostTest() {
            AuthenticationController controller = new AuthenticationController();
            ViewResult result = controller.SignUp(DataProvider.NegativeSignUpData[0]) as ViewResult;
            SignUpModel model = (SignUpModel) result.ViewData.Model;
            Assert.AreEqual(DataProvider.NegativeSignUpData[0].Username, model.Username);            
        }

    }

}