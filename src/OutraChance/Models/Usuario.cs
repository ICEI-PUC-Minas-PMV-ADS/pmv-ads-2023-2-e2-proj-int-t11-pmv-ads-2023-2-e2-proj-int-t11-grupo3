using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace OutraChance.Models
{
    [Table("Usuarios")]

    public class Usuario
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "O preenchimento do Nome é obrigatório!")]
        public string Nome { get; set; }

        [Required(ErrorMessage = "O preenchimento do CPF é obrigatório!")]
        public int Cpf { get; set; }

        [Required(ErrorMessage = "O preenchimento da Data de Nascimento é obrigatório!")]
        public DateTime Data_Nascimento { get; set; }

        [Required(ErrorMessage = "O preenchimento do Telefone é obrigatório!")]
        public int Telefone { get; set; }

        [Required(ErrorMessage = "O preenchimento do E-mail é obrigatório!")]
        public string Email { get; set; }

        [Required(ErrorMessage = "O preenchimento da Senha é obrigatório!")]
        public string Senha { get; set; }

        public int Avatar { get; set; }
    }
}
