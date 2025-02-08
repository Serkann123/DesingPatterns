using Microsoft.EntityFrameworkCore;

namespace DesignPattern.CQRS.DAL
{
    public class Context:DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("server=DESKTOP-3U064FC; initial catalog=DesingPattern2; integrated security=true; TrustServerCertificate=True;");

        }
        public DbSet<Product> Products { get; set; }
    }
}
