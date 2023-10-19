using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace OutraChance.Models
{
    [Table("Usuarios")]

    public class Usuario
    {
        [Key]
        public int Id { get; set; }

        [Display(Name = "Nome")]
        [Required(ErrorMessage = "O preenchimento do Nome é obrigatório!")]
        public string Nome { get; set; }

        [Display(Name = "CPF")]
        [Required(ErrorMessage = "O preenchimento do CPF é obrigatório!")]
        public string Cpf { get; set; }

        [Display(Name = "Data de Nascimento")]
        [Required(ErrorMessage = "O preenchimento da Data de Nascimento é obrigatório!")]
        [DataType(DataType.Date)]
        public DateTime Data_Nascimento { get; set; }

        [Display(Name = "Telefone")]
        [Required(ErrorMessage = "O preenchimento do Telefone é obrigatório!")]
        public string Telefone { get; set; }

        [Display(Name = "E-mail")]
        [Required(ErrorMessage = "O preenchimento do E-mail é obrigatório!")]
        public string Email { get; set; }

        [Display(Name = "Senha")]
        [Required(ErrorMessage = "O preenchimento da Senha é obrigatório!")]
        [DataType(DataType.Password)]
        public string Senha { get; set; }

        [Display(Name = "Imagem do Perfil")]
        [DataType(DataType.ImageUrl)]
        public string Avatar { get; set; }

        public ICollection<Anuncio> Anuncios { get; set; }

        }
}
