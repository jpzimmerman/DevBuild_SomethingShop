using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using DevBuild.WebRegistration.Models;

namespace DevBuild.WebRegistration.Controllers
{
    public class RegistrationController : Controller {
        public static List<RegistrationData> SiteUserData = new List<RegistrationData>();

        // GET: RegistrationForm
        public ActionResult Index() {
            Console.WriteLine("Started");
            return View();
        }

        [HttpPost]
        public ActionResult Submit(RegistrationData regData) {
            if (SiteUserData.Find(x => x.EmailAddress == regData.EmailAddress) != null) {
                ModelState.AddModelError("EmailAddress", "Account with that email address is already registered");
            }

            if (ModelState.IsValid) {
                SiteUserData.Add(regData);
                TempData.Add("FirstName", regData.FirstName);
                ViewBag.FirstName = regData.FirstName;
                return RedirectToAction("Confirm");
            }
            else {
                //ViewBag.ModelState = ModelState;
                //return RedirectToAction("Registration", "Home");
                return View("Index");
            }

        }

        public ActionResult Confirm() {
            ViewBag.Title = "Registration Confirmed";
            return View(SiteUserData);
        }
    }
}