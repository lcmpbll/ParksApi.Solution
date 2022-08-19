using Microsoft.EntityFrameworkCore;

namespace ParksApi.Models
{
  public class ParksApiContext : DbContext
  {
    public class ParksApiContext(DbContextOptions<ParksApiContext> options)
      :base(options)
      {
        
      }
      
      public DbSet<Park> Parks { get; set; }
  }
}