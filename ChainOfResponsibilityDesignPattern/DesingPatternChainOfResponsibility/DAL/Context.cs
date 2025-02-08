using Microsoft.EntityFrameworkCore;


namespace DesingPatternChainOfResponsibility.DAL
{
    public class Context:DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("server=DESKTOP-3U064FC; initial catalog=DesingPattern1; integrated security=true");
        }

        public DbSet<CustomerProcess> CustomerProcesses { get; set; }
    }
}
