using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace OutraChance.Models
{
    public class Anuncio
    {

        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "O preenchimento do Titulo é obrigatório!")]
        public string Titulo { get; set; }

        [Required(ErrorMessage = "O preenchimento da Descrição é obrigatório!")]
        public string Descricao { get; set; }

        [Required(ErrorMessage = "O preenchimento do Preço é obrigatório!")]
        public decimal Preco { get; set; }

        [Required(ErrorMessage = "O preenchimento da Cidade é obrigatório!")]
        public string Cidade { get; set; }

        [Required(ErrorMessage = "O preenchimento do Estado é obrigatório!")]
        public string Estado { get; set; }

        [Required(ErrorMessage = "O preenchimento da Status é obrigatório!")]
        public string Status { get; set; }

        public int Id_Usuario { get; set; }

        [ForeignKey("Id_Usuario")]

        public Usuario Usuario { get; set;}
    }
}

