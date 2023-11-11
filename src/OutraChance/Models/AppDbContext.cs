using Microsoft.EntityFrameworkCore;
using OutraChance.Models.Seeders;

namespace OutraChance.Models
{
    public class AppDbContext :DbContext
    { 

        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        public DbSet<Usuario> Usuarios { get; set; }

        public DbSet<Anuncio> Anuncios { get; set; }

        public DbSet<Caracteristica> Caracteristicas { get; set; }

        public DbSet<CaracteristicaValores> CaracteristicaValores { get; set; }
            
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

            modelBuilder.Entity<Caracteristica>().HasData(CaracteristicaSeed.GetPreconfiguredCaracteristicas());

            modelBuilder.Entity<CaracteristicaValores>().HasData(
                new CaracteristicaValores { Id = 1, CaracteristicaId = 1, Valor = "Azul" },
                new CaracteristicaValores { Id = 2, CaracteristicaId = 1, Valor = "Amarelo" },
                new CaracteristicaValores { Id = 3, CaracteristicaId = 1, Valor = "Vermelho" },
                new CaracteristicaValores { Id = 4, CaracteristicaId = 1, Valor = "Verde" },
                new CaracteristicaValores { Id = 5, CaracteristicaId = 1, Valor = "Laranja" },
                new CaracteristicaValores { Id = 6, CaracteristicaId = 1, Valor = "Lilás" },
                new CaracteristicaValores { Id = 8, CaracteristicaId = 1, Valor = "Branco" },
                new CaracteristicaValores { Id = 9, CaracteristicaId = 1, Valor = "Preto" },

                new CaracteristicaValores { Id = 10, CaracteristicaId = 2, Valor = "PP" },
                new CaracteristicaValores { Id = 11, CaracteristicaId = 2, Valor = "P" },
                new CaracteristicaValores { Id = 12, CaracteristicaId = 2, Valor = "M" },
                new CaracteristicaValores { Id = 13, CaracteristicaId = 2, Valor = "G" },
                new CaracteristicaValores { Id = 14, CaracteristicaId = 2, Valor = "GG" },

                new CaracteristicaValores { Id = 15, CaracteristicaId = 3, Valor = "Calças" },
                new CaracteristicaValores { Id = 16, CaracteristicaId = 3, Valor = "Blusas" },
                new CaracteristicaValores { Id = 17, CaracteristicaId = 3, Valor = "Calçados" },
                new CaracteristicaValores { Id = 18, CaracteristicaId = 3, Valor = "Shorts" },

                new CaracteristicaValores { Id = 19, CaracteristicaId = 4, Valor = "Masculino" },
                new CaracteristicaValores { Id = 20, CaracteristicaId = 4, Valor = "Feminino" }
            );
        }
    }
}
