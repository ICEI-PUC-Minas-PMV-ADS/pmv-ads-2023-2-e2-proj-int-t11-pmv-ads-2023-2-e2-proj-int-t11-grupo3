using Microsoft.EntityFrameworkCore;

namespace OutraChance.Models
{
    public class AppDbContext :DbContext
    { 

        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        public DbSet<Usuario> Usuarios { get; set; }

        public DbSet<Anuncio> Anuncios { get; set; }
            


    }
}
