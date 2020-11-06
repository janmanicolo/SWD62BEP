using Microsoft.EntityFrameworkCore;
using Shoppingcart.domain.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace ShoppincCart.data.Context
{
    public class ShoppingCartDbContext : DbContext
    {
        public ShoppingCartDbContext(DbContextOptions options) : base(options) { }

        public DbSet<Product> products { get; set; }
        public DbSet<Category> Categories { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Product>().Property(x => x.id).HasDefaultValueSql("NEWID()");
        }
    }
}
