using System;
using System.Configuration;
using IrenioStadium.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

namespace IrenioStadium.Infra.Persistence.DataContexts
{
    public class IrenioStadiumDataContext : DbContext
    {
        public DbSet<Jogador> Jogadores { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            // optionsBuilder.UseSqlServer(@"Server=DESKTOP-FSPEV7P\SQLEXPRESS;Database=dbis;User ID=sa;Password=123@mudar");
            // optionsBuilder.UseSqlServer(@"Server=localhost,1433;Database=dbis;User ID=SA;Password=MNRMNR87@");

            // banco de produção
            optionsBuilder.UseSqlServer(@"Server=tcp:eu-az-sql-serv1.database.windows.net,1433;Initial Catalog=dbisbanco;Persist Security Info=False;User ID=ireniostadium;Password=!Q2w3e4r;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;");

            // string conn = ConfigurationManager.ConnectionStrings["connectionString"].ConnectionString;

            // string conString = ConfigurationExtensions
            //     .GetConnectionString("connectionString");

            // optionsBuilder.UseSqlServer(@"Server=localhost,1433;Database=dbis;User ID=SA;Password=MNRMNR87@");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        { }
    }
}