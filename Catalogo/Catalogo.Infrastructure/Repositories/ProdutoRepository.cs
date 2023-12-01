using Catalogo.Domain.Entities;
using Catalogo.Domain.Interfaces;
using Catalogo.Infrastructure.Context;
using Microsoft.EntityFrameworkCore;

namespace Catalogo.Infrastructure.Repositories
{
    public class ProdutoRepository : IProdutosRepository
    {
        protected ApplicationDbContext _produtoContext;

        public ProdutoRepository(ApplicationDbContext produtoContext)
        {
            _produtoContext = produtoContext;
        }

        public async Task<Produtos> CreateAsync(Produtos produtos)
        {
            _produtoContext.produtos.AddAsync(produtos);
            await _produtoContext.SaveChangesAsync();
            return produtos;
        }

        public async Task<Produtos> GetByIdAsync(int? id)
        {
            return await _produtoContext.produtos.FindAsync(id);
        }

        public async Task<IEnumerable<Produtos>> GetProdutosAsync()
        {
            var produto = await _produtoContext.produtos.ToListAsync();
            return produto;
        }

        public async Task<Produtos> RemoveAsync(Produtos produtos)
        {
            _produtoContext.Remove(produtos);
            await _produtoContext.SaveChangesAsync();
            return produtos;
        }

        public async Task<Produtos> UpdateAsync(Produtos produtos)
        {
            _produtoContext.Update(produtos);
            await _produtoContext.SaveChangesAsync();
            return produtos;
        }
    }
}
