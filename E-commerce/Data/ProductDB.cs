using E_commerce.Models;
using Microsoft.EntityFrameworkCore;

namespace E_commerce.Data
{
    public class ProductDb : DbContext
    {

        public ProductDb(DbContextOptions<ProductDb> options ) : base( options )
        {

        }
      public DbSet<Commodities> Product{ get; set; }
      public DbSet<User> Users { get; set; }
    }
}
