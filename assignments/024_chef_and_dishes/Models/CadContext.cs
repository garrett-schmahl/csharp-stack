using Microsoft.EntityFrameworkCore;

namespace _024_chef_and_dishes.Models
{
  public class CadContext : DbContext
  {
    public CadContext(DbContextOptions options) : base(options) { }

    public DbSet<Chef> Chefs { get; set; }
    public DbSet<Dish> Dishes { get; set; }
  }
}
