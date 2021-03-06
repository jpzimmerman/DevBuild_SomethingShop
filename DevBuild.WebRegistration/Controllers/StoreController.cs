﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using DevBuild.WebRegistration.Models;

namespace DevBuild.WebRegistration.Controllers
{
    public class StoreController : Controller
    {
        private List<StoreItem> StoreItems { get; set; }

        // GET: Store
        public ActionResult Index()
        {
            using (SomethingShopDB context = new SomethingShopDB())
            {
                StoreItems = context.Items.ToList();
                return View(StoreItems);
            }
        }
    }
}