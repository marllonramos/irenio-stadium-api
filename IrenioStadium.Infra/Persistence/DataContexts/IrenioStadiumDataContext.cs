using Microsoft.EntityFrameworkCore;

namespace IrenioStadium.Infra.Persistence.DataContexts
{
    public class IrenioStadiumDataContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=DESKTOP-FSPEV7P\SQLEXPRESS;Database=dbis;User ID=sa;Password=123@mudar");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        { }
    }
}