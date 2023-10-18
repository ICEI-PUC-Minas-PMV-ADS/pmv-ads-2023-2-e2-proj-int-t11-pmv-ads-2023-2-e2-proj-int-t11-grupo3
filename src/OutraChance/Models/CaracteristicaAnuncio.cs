using System.ComponentModel.DataAnnotations;

namespace OutraChance.Models
{
    public class CaracteristicaAnuncio
    {
        public int AnuncioId { get; set; }
        public Anuncio Anuncio { get; set; }

        public int CaracteristicaId { get; set; }
        public Caracteristica Caracteristica { get; set; }

        [Required]
        public string Valor { get; set; }
    }
}
