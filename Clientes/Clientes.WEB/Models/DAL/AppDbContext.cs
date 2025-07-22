using Clientes.WEB.Models.Entities;
using Microsoft.EntityFrameworkCore;

namespace Clientes.WEB.Models.DAL
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }
        public DbSet<Cliente> Clientes { get; set; }

        public DbSet<HistorialCorporal> historialCorporal { get; set; }

    }
}
