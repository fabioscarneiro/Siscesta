using Microsoft.EntityFrameworkCore;
using Siscesta.Model;
using System.Configuration;


namespace Siscesta
{
    public class SiscestaDbContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            var connectionString = ConfigurationManager.
                ConnectionStrings["DbSiscesta"].
                ConnectionString;
            optionsBuilder.UseMySql(connectionString);
        }
        public DbSet<Marca> Marcas { get; set; }
        public DbSet<Modelo> Modelos { get; set; }
        public DbSet<Pessoa> Pessoas { get; set; }
        public DbSet<Veiculo> Veiculos { get; set; }
    }
}
