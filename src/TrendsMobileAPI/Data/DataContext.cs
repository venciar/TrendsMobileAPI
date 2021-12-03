using Microsoft.EntityFrameworkCore;
using TrendsMobileAPI.Models;

namespace TrendsMobileAPI.Data
{
  public class DataContext : DbContext
  {
    public DataContext(DbContextOptions<DataContext> options) : base(options)
    {

    }

    public DbSet<Ad> AdItems {get; set;}
  }
}