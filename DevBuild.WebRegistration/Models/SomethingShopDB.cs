namespace DevBuild.WebRegistration.Models
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class SomethingShopDB : DbContext
    {
        public SomethingShopDB()
            : base("name=SomethingShopDB")
        {
        }

        public virtual DbSet<SiteUser> Users { get; set; }
        public virtual DbSet<StoreItem> Items { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<SiteUser>()
                .Property(e => e.PhoneNumber)
                .IsFixedLength();

            modelBuilder.Entity<StoreItem>()
                .Property(e => e.Price)
                .HasPrecision(12, 2);
        }
    }
}
