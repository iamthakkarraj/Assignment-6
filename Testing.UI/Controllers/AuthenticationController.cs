using Testing.BLL.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Testing.BLL.Service;
using Testing.BLL.Interface;

namespace Testing.UI.Controllers {

    public class AuthenticationController : Controller {

        private readonly IAuthenticationService _AuthenticationService;

        public AuthenticationController() {
            _AuthenticationService = new AuthenticationService();
        }
        
        public ActionResult Login() {
            return View();
        }

        [HttpPost]
        public ActionResult Login(LoginModel login) {
            if (ModelState.IsValid) {
                if (_AuthenticationService.VerifyUser(login)) {
                    if (Session != null) {
                        TempData["Success"] = "Logged In Successfully !";
                        Session["IsAuthenticated"] = true;
                    }
                    return RedirectToAction("Index", "User");
                } else {
                    TempData["Error"] = "Could Not Login Right Now Please Try Again Later.";
                    return View();
                };
            } else {
                TempData["Error"] = "Please Check Your Details Again";
                return View();
            }
        }

        public ActionResult Logout() {
            if(Session["IsAuthenticated"] != null) {
                Session["IsAuthenticated"] = false;
            }
            return RedirectToAction("Login");
        }        

        public ActionResult SignUp() {
            return View();
        }

        [HttpPost]
        public ActionResult SignUp(SignUpModel login) {
            if (ModelState.IsValid) {
                if (_AuthenticationService.AddUser(login)) {
                    TempData["Success"] = "User Created Successfully !";
                    return RedirectToAction("Login", "Authentication");
                } else {
                    TempData["Error"] = "Could Not Create User Right Now Please Try Again Later.";
                    return View();
                };
            } else {
                TempData["Error"] = "Error Creating User. Please Check Your Details";
                return View();
            }
        }

    }
}
