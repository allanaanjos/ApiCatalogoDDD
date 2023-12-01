namespace Catalogo.Domain.Entities
{
    public sealed class Produtos : EntityBase
    {
        public Produtos(string? nome, string? description, int preco, string? imagem, int estoque, DateTime dataCadastro)
        {
            Nome = nome;
            Description = description;
            Preco = preco;
            Imagem = imagem;
            Estoque = estoque;
            DataCadastro = dataCadastro;
        }

        public string? Nome { get; set; }
        public string? Description { get; set; }
        public int Preco { get; set; }
        public string? Imagem { get; set; }
        public int Estoque { get; set; }
        public DateTime DataCadastro { get; set; } 
        public int CategoriaId { get; set; }

        public Categoria Categoria { get; set; }


    }
}
