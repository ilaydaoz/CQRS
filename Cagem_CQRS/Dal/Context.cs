using Microsoft.EntityFrameworkCore;

namespace Cagem_CQRS.Dal
{
    public class Context:DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=DESKTOP-AKOHCIC;initial catalog=CqrsDesignPattern;integrated security=true");
        }
        public DbSet<Product> Products { get; set; }
    }
}
