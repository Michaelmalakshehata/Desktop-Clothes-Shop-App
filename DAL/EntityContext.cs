using DAL.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class EntityContext:DbContext
    {
        public DbSet<LogedIn>? logedIns { get; set; }
        public DbSet<Registers>? registers { get; set; }
        public DbSet<Category>? categories { get; set; }
        public DbSet<Products>? products { get; set; }


        public EntityContext(DbContextOptions options):base(options)
        { 

        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<LogedIn>().HasKey(e => e.Id);
            modelBuilder.Entity<Products>().HasOne(p => p.Category).WithMany(p => p.Products).HasForeignKey(p => p.CategoryId).HasConstraintName("CategoriesMenus");
        }
    }
}
