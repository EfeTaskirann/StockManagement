using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EntityLayer.Concrete;
using Microsoft.EntityFrameworkCore;

namespace DataAccessLayer.Concrete
{
    public class Context : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("server=EFE\\SQLEXPRESS; database=StockManagement; integrated security=true; TrustServerCertificate=true;");
        }

        public DbSet<User> Users { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Subcategory> Subcategories { get; set; }
        public DbSet<Product> Products { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Subcategory>()
                .HasOne(s => s.Category)
                .WithMany()
                .HasForeignKey(s => s.Category_id);

            modelBuilder.Entity<Product>()
                .HasOne(p => p.Subcategory)
                .WithMany()
                .HasForeignKey(p => p.Subcategory_id);
        }
    }
}
