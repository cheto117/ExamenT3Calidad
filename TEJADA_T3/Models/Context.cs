using Microsoft.EntityFrameworkCore;
using TEJADA_T3.Models.Map;

namespace TEJADA_T3.Models
{
    public class Context : DbContext
    {
        public DbSet<Usuario> Usuarios { get; set; }
        public DbSet<Sexo> Sexos { get; set; }
        public DbSet<Raza> Razas { get; set; }
        public DbSet<Especie> Especies { get; set; }
        public DbSet<Historia> Historias { get; set; }
        public Context(DbContextOptions<Context> o) : base(o) { }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.ApplyConfiguration(new UsuarioMap());
            modelBuilder.ApplyConfiguration(new SexoMap());
            modelBuilder.ApplyConfiguration(new RazaMap());
            modelBuilder.ApplyConfiguration(new EspecieMap());
            modelBuilder.ApplyConfiguration(new HistoriaMap());
        }
    }
}
