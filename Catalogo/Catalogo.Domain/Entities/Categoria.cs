namespace Catalogo.Domain.Entities
{
    public sealed class Categoria : EntityBase
    {
        public string Nome { get; private set; }
        public string ImagemUrl { get; private set; }
        public ICollection<Produtos> Produtos {get; set;} 

    }
}
