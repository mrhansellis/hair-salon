using Microsofgt.EntityFrameworkCore;

namespace HairSalon.Models
{
  public class HairSalonContext : dbContext
  {
    public DbSet<Stylist> Stylists { get; set; }
    public DbSet<Client> Clients { get; set; }

    public ToDoListContext(DbContextOptions options) : base(options) { }
  }

}
