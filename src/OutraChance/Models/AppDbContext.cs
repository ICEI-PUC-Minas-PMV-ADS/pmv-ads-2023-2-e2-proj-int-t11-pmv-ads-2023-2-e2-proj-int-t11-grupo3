using Microsoft.EntityFrameworkCore;

namespace OutraChance.Models
{
    public class AppDbContext :DbContext
    { 

        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        public DbSet<Usuario> Usuarios { get; set; }

        public DbSet<Anuncio> Anuncios { get; set; }
            
        public DbSet<CaracteristicaAnuncio> CaracteristicaAnuncios { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // Configuração da chave primária composta
            modelBuilder.Entity<CaracteristicaAnuncio>()
                .HasKey(ca => new { ca.AnuncioId, ca.CaracteristicaId });

            // Configuração dos relacionamentos
            modelBuilder.Entity<CaracteristicaAnuncio>()
                .HasOne(ca => ca.Anuncio)
                .WithMany(ca => ca.CaracteristicasAnuncios)
                .HasForeignKey(ca => ca.AnuncioId);

            modelBuilder.Entity<CaracteristicaAnuncio>()
                .HasOne(ca => ca.Caracteristica)
                .WithMany(ca => ca.CaracteristicasAnuncios)
                .HasForeignKey(ca => ca.CaracteristicaId);
        }
    }
}
