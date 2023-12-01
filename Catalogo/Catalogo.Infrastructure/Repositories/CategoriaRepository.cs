using Catalogo.Domain.Entities;
using Catalogo.Domain.Interfaces;
using Catalogo.Infrastructure.Context;
using Microsoft.EntityFrameworkCore;

namespace Catalogo.Infrastructure.Repositories
{
    public class CategoriaRepository : ICategoriaRepository
    {
        protected ApplicationDbContext _categoriaContext;

        public CategoriaRepository(ApplicationDbContext context)
        {
            _categoriaContext = context;
        }



        public async Task<Categoria> CreateAsync(Categoria categoria)
        {
            _categoriaContext.AddAsync(categoria);
            await _categoriaContext.SaveChangesAsync();
            return categoria;
        }

        public async Task<Categoria> GetByIdAsync(int id)
        {
            return await _categoriaContext.categorias.FindAsync(id);
        }

        public async Task<IEnumerable<Categoria>> GetCategoriaAsync()
        {
            var categoria = await _categoriaContext.categorias.ToListAsync();
            return categoria;
        }

        public async Task<Categoria> RemoveAsync(Categoria categoria)
        {
            _categoriaContext.Remove(categoria);
            await _categoriaContext.SaveChangesAsync();
            return categoria;
        }

        public async Task<Categoria> UpdateAsync(Categoria categoria)
        {
            _categoriaContext.Update(categoria);
            await _categoriaContext.SaveChangesAsync();
            return categoria;
        }
    }
}