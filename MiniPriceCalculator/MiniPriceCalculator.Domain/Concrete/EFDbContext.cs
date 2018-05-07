using System.Data.Entity;
using MiniPriceCalculator.Domain.Entities;

namespace MiniPriceCalculator.Domain.Concrete
{
    public class EFDbContext : DbContext
    {
        public DbSet<Product> Products { get; set; }
    }
}
