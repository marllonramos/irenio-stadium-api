using IrenioStadium.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace IrenioStadium.Infra.Persistence.DataContexts
{
    public class IrenioStadiumDataContext : DbContext
    {
        public DbSet<Jogador> Jogadores { get; set; }
        
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            // optionsBuilder.UseSqlServer(@"Server=DESKTOP-FSPEV7P\SQLEXPRESS;Database=dbis;User ID=sa;Password=123@mudar");
            optionsBuilder.UseSqlServer(@"Server=localhost,1433;Database=dbis;User ID=SA;Password=MNRMNR87@");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        { }
    }
}