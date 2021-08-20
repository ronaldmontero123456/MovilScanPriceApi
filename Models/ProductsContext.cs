using Microsoft.EntityFrameworkCore;

namespace MovilScanPriceApi.Models
{
    public class ProductsContext: DbContext
    {
        public ProductsContext(DbContextOptions<ProductsContext> options) : base(options)
        {
        }
        public DbSet<VW_PRODUCTOSLECTOR> VW_PRODUCTOSLECTOR { get; set; }
        public DbSet<VW_BIENESTARLECTOR> VW_BIENESTARLECTOR { get; set; }
    }
}
