using EFCoreBulk.Entidades;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;

namespace EFCoreBulk.Context
{
    public class TimeContext : DbContext
    {
        public DbSet<Time> Times { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            string conexao = "CONNECTION STRING";
            optionsBuilder
                .UseSqlServer(conexao)
                .EnableSensitiveDataLogging() // Exibe os dados sensíveis das queries no console
                .LogTo(Console.WriteLine, LogLevel.Information); // Log das queries no console da aplicação
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Time>()
                .HasData(
                    new Time
                    {
                        Id = 1,
                        Nome = "Corinthians",
                        ClassificacaoCampeonatoBrasileiro = 2
                    },
                    new Time
                    {
                        Id = 2,
                        Nome = "Flamengo",
                        ClassificacaoCampeonatoBrasileiro = 20
                    }
                );
        }
    }
}