using System.ComponentModel.DataAnnotations;

namespace OutraChance.Models
{
    public class CaracteristicaValores
    {
        [Key]
        public int Id { get; set; }

        public int CaracteristicaId { get; set; }
        public Caracteristica Caracteristica { get; set; }

        [Required]
        public string Valor { get; set; }
    }
}
