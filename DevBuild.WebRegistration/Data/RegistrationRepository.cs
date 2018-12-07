using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using DevBuild.WebRegistration.Models;

namespace DevBuild.WebRegistration.Data
{
    public class RegistrationRepository
    {
        public class SomethingShopContext : DbContext
        {
            public DbSet<RegistrationData> Users { get; set; }
            public DbSet<StoreItem> StoreItems { get; set; }

            public SomethingShopContext() : base("(LocalDB)\\MSSQLLocalDb\\SomethingShopDB") { }
        }

        


    }
}