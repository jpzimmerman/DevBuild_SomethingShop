using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using DevBuild.WebRegistration.Data;
using DevBuild.WebRegistration.Models;

namespace DevBuild.WebRegistration.Controllers
{
    public class RegistrationController : Controller {

        // GET: RegistrationForm
        public ActionResult Index() {
            return View();
        }

        [HttpPost]
        public ActionResult Submit(SiteUser regData) {
            using (SomethingShopDB context = new SomethingShopDB())
            {

                if (context.Users.Find(regData.Email) != null)
                {
                    ModelState.AddModelError("EmailAddress", "Account with that email address is already registered");
                }
                if (ModelState.IsValid)
                {
                    TempData.Add("FirstName", regData.FirstName);
                    ViewBag.FirstName = regData.FirstName;
                    context.Users.Add(regData);
                    context.SaveChanges();
                    return RedirectToAction("Confirm");
                }
                else
                {
                    return View("Index");
                }
            }
        }

        public ActionResult Confirm() {
            ViewBag.Title = "Registration Confirmed";
            using (SomethingShopDB context = new SomethingShopDB())
            {
                List<SiteUser> users = context.Users.ToList();
                return View(users);
            }
        }
    }
}