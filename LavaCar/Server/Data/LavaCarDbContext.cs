using LavaCar.Shared;
using Microsoft.EntityFrameworkCore;


namespace LavaCar.Server.Data
{
    public class LavaCarDbContext : DbContext
    {
        public LavaCarDbContext(DbContextOptions<LavaCarDbContext> options) : base(options)
        {

        }

        public DbSet<Empresa> Empresas { get; set; }
        public DbSet<Sede> Sedes { get; set; }
        public DbSet<TipoVehiculo> TiposVehiculos { get; set; }
        //public DbSet<Servicio> Servicios { get; set; }

        //public DbSet<Usuario> Usuarios { get; set; }
    }
}
