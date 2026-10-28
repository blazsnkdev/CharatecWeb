using CharatecWeb.Backend.Data.Entities;
using Microsoft.EntityFrameworkCore;

namespace CharatecWeb.Backend.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options):base(options)
        {
            
        }
        public DbSet<Producto> Productos => Set<Producto>();
        public DbSet<Marca> Marcas => Set<Marca>();
        public DbSet<Procesador> Procesadores => Set<Procesador>();
        public DbSet<TarjetaVideo> TarjetasVideo => Set<TarjetaVideo>();
    }
}
