﻿using Microsoft.AspNetCore.StaticFiles.Infrastructure;
using Newtonsoft.Json.Serialization;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Configuration;

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
        [DataType(DataType.EmailAddress)]
        [EmailAddress(ErrorMessage ="Digite um E-mail válido!")]
        public string Email { get; set; }

        [Display(Name = "Senha")]
        [Required(ErrorMessage = "O preenchimento da Senha é obrigatório!")]
        [DataType(DataType.Password)]
        public string Senha { get; set; }

        [NotMapped]
        [Display(Name = "Confirme a Senha")]
        [DataType(DataType.Password)]
        [Compare("Senha", ErrorMessage = "A senha e a confirmação de senha não são iguais.")]
        public string ConfirmacaoSenha { get; set; }

        [Display(Name = "Imagem do Perfil")]
        [DataType(DataType.ImageUrl)]
        public string Avatar { get; set; }

        [NotMapped] // Essa propriedade está na classe de anúncio mas, não será salva no banco, ela será utilizada apenas no momento do upload
        public IFormFile ImagemUpload { get; set; }

        public ICollection<Anuncio> Anuncios { get; set; }

        }
}
