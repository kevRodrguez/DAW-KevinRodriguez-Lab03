
using Microsoft.EntityFrameworkCore;
using SourcingManager.Models;

namespace SourcingManager.Data
{
    public class SourcingDbContext : DbContext
    {
        public SourcingDbContext(DbContextOptions<SourcingDbContext> options)
            : base(options)
        {
        }

        public DbSet<Proveedor> Proveedores { get; set; }
        public DbSet<CategoriaProveedor> CategoriasProveedor { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Datos semilla
            modelBuilder.Entity<CategoriaProveedor>().HasData(
                new CategoriaProveedor { Id = 1, Nombre = "Tecnología" },
                new CategoriaProveedor { Id = 2, Nombre = "Materia Prima" },
                new CategoriaProveedor { Id = 3, Nombre = "Logística" }
            );
        }
    }
}
