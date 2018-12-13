using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;
using DevBuild.WebRegistration.Models;
using Microsoft.AspNet.Identity.EntityFramework;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.Owin;
using Microsoft.Owin.Security;
using DevBuild.WebRegistration.Data;

namespace DevBuild.WebRegistration.Controllers
{

    public class AccountController : Controller
    {

        private UserManager<AppUser> _userManager => HttpContext.GetOwinContext().Get<UserManager<AppUser>>();
        

        // GET: Account
        public ActionResult Index()
        {
            return View();
        }

        [AllowAnonymous]
        [HttpGet]
        public ActionResult Register()
        {
            return View();
        }

        public async Task<ActionResult> Register(SiteUser userData)
        {
            userData.UserName = userData.Email;
            AppUser appUser = new AppUser();
            appUser.Email = userData.Email;
            appUser.EmailConfirmed = true;
            appUser.UserName = userData.UserName;
            appUser.PhoneNumber = userData.PhoneNumber;
            appUser.SubscribeToEmails = userData.SubscribeToEmails;
            //appUser.UserId = userData.Id;
            var result = await _userManager.CreateAsync(appUser, userData.Password);

            if (result.Succeeded)
            {
                return RedirectToAction("Contact", "Home");
            }
            foreach (var error in result.Errors)
            {
                ModelState.AddModelError("", error);
            }
            
            return View();
        }


        [HttpGet]
        [AllowAnonymous]
        public ActionResult SignIn() {

            return View();
        }

        [HttpPost]
        [AllowAnonymous]
        public async Task<ActionResult> SignIn(LoginModel loginModel)
        {
            if (ModelState.IsValid)
            {
                var authManager = HttpContext.GetOwinContext().Authentication;

                AppUser appUser = new AppUser{ UserName = loginModel.Email };
                var user = await _userManager.FindByEmailAsync(loginModel.Email);
                if (user != null)
                {
                    try
                    {
                        var ident = await _userManager.CreateIdentityAsync(user,
                            DefaultAuthenticationTypes.ApplicationCookie);
                        //use the instance that has been created. 
                        var x = new AuthenticationProperties();
                        
                        authManager.SignIn(
                            new AuthenticationProperties { IsPersistent = false }, ident);
                        return RedirectToAction("Index", "Home");
                        
                    }
                    catch (Exception e)
                    {
                        ModelState.AddModelError("", e.Message);
                    }
                }
            }
            return View();
        }

        public async Task<ActionResult> SignOut()
        {
            var authManager = HttpContext.GetOwinContext().Authentication;
            authManager.SignOut();
            return RedirectToAction("Index", "Home");
        }



    }
}