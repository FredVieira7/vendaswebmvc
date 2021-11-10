using Microsoft.EntityFrameworkCore;

namespace VendasWebMVC.Data
{
    public class VendasWebMVCContext : DbContext
    {
        public VendasWebMVCContext (DbContextOptions<VendasWebMVCContext> options)
            : base(options)
        {
        }

        public DbSet<VendasWebMVC.Models.Department> Department { get; set; }
        public DbSet<VendasWebMVC.Models.Seller> Seller { get; set; }
        public DbSet<VendasWebMVC.Models.SalesRecord> SalesRecord { get; set; }
    }
}
