using Catalogo.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Catalogo.Domain.Interfaces
{
    public  interface IProdutosRepository
    {
        Task<IEnumerable<Produtos>> GetProdutosAsync();
        Task<Produtos> GetByIdAsync(int? id);
        Task<Produtos> CreateAsync(Produtos produtos);
        Task<Produtos> UpdateAsync(Produtos produtos);
        Task<Produtos> RemoveAsync(Produtos produtos);
    }
}
