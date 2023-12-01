using System.ComponentModel.DataAnnotations;

namespace Catalogo.Application.DTOs
{
    public  class CategoriaDTO
    {
        public int Id { get; set; }
        
        [Required(ErrorMessage = "Informe o nome da Categoria")]
        [MinLength(5)]
        [MaxLength(100)]
        public string Name { get; set; }

        [Required(ErrorMessage = "Informe o nome da imagem")]
        [MinLength(5)]
        [MaxLength(250)]
        public string ImagemUrl { get; set; }
    }
}
