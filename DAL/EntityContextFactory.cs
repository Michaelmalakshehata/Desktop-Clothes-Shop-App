using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class EntityContextFactory : IDesignTimeDbContextFactory<EntityContext>
    {
        public EntityContext CreateDbContext(string[]? args=null)
        {
            var options = new DbContextOptionsBuilder<EntityContext>();
            options.UseSqlServer("Server=.;Database=ClothesShop;Trusted_Connection=True");
            return new EntityContext(options.Options);
        }
    }
}
