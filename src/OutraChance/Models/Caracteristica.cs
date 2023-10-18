using System.ComponentModel.DataAnnotations;

namespace OutraChance.Models
{
    public class Caracteristica
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string Nome{ get; set; }

        public ICollection<CaracteristicaAnuncio> CaracteristicasAnuncios { get; set; }
    }
}
