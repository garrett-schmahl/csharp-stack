using Microsoft.EntityFrameworkCore;

namespace _025_products_and_catagories.Models
{
  public class PacContext : DbContext
  {
    public PacContext(DbContextOptions options) : base(options) { }

    public DbSet<Category> Categories { get; set; }
    public DbSet<Product> Products { get; set; }
    public DbSet<Association> Associations { get; set; }
  }
}