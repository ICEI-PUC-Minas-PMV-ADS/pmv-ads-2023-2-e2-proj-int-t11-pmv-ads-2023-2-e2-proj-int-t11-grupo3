﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Drawing;

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

        public bool Status { get; set; }

        [DataType(DataType.Upload)]
        public string Imagem { get; set; }

        public int Id_Usuario { get; set; }

        [ForeignKey("Id_Usuario")]
        public Usuario Usuario { get; set;}

        public ICollection<CaracteristicaAnuncio> CaracteristicasAnuncios {  get; set; }

        [NotMapped] // Essa propriedade está na classe de anúncio mas, não será salva no banco, ela será utilizada apenas no momento do upload
        public IFormFile ImagemUpload { get; set; }
    }
}

