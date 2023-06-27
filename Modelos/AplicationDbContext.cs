using Microsoft.EntityFrameworkCore;

namespace app1_Migrations.Modelos
{
  public class AplicationDbContext : DbContext
  {
    public AplicationDbContext(DbContextOptions<AplicationDbContext> options) : base(options)
    {
    }
    public DbSet<Usuario> Usuarios { get; set; }

    }
}
