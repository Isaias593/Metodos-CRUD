using Microsoft.EntityFrameworkCore;

namespace DAWA_MetodosCRUD.Models
{
    public class AppDbContext : DbContext
    {
       

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=localhost\\SQLEXPRESS;Database=INCORONELV2;Trusted_Connection=true;Encrypt=false;");
        }
        public DbSet<Cliente> Cliente { get; set; }
    }
}
