using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using DevBuild.WebRegistration.Models;

namespace DevBuild.WebRegistration.Controllers
{
    public class AdminController : Controller
    {
        private List<StoreItem> StoreItems { get; set; }

        // GET: Admin
        public ActionResult Index()
        {
            using (SomethingShopDB context = new SomethingShopDB())
            {
                StoreItems = context.Items.ToList();
                return View(StoreItems);
            }
        }

        public ActionResult AddItem()
        {
            return View();
        }

        [HttpPost]
        public ActionResult AddItemSubmit(StoreItem item)
        {
            using (SomethingShopDB context = new SomethingShopDB())
            {
                context.Items.Add(item);
                context.SaveChanges();
            }
            return RedirectToAction("Index");
        }

        public ActionResult EditItem(int? id)
        {
            return View();
        }

        public ActionResult DeleteItem(int? id)
        {
            return View();
        }
    }
}