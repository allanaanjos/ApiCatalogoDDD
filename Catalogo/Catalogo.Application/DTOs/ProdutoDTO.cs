using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Catalogo.Application.DTOs
{
    public  class ProdutoDTO
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "O nome é obrigatório")]
        [MinLength(3)]
        [MaxLength(80)]
        public string? Nome { get; set; }

        [Required(ErrorMessage = "A descriçao é obrigatoria")]
        [MinLength(5)]
        [MaxLength(200)]
        public string? Description { get; set; }

        [Required(ErrorMessage = "Informe o preço")]
        [DataType(DataType.Currency)]
        [Column(TypeName = "decimal(18, 2)")]
        [DisplayFormat(DataFormatString = "{0:C2}")]
        public int Preco { get; set; }

        [MaxLength(250)]
        public string? Imagem { get; set; }

        [Required(ErrorMessage = "O estoque é obrigatoria")]
        [Range(1,9999)]
        public int Estoque { get; set; }

        public DateTime DataInicial { get; set; }

    }
}
