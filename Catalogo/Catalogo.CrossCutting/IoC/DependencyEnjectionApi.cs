using Catalogo.Application.Interfaces;
using Catalogo.Application.Mappings;
using Catalogo.Application.Services;
using Catalogo.Domain.Interfaces;
using Catalogo.Infrastructure.Context;
using Catalogo.Infrastructure.Repositories;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace Catalogo.CrossCutting.IoC
{
    public static class DependencyEnjectionApi 
    {
        public static IServiceCollection AddInfrastructureApi(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddDbContext<ApplicationDbContext>(options =>
            {
                options.UseMySql(configuration.GetConnectionString("DefaultConnection"),
                    new MySqlServerVersion(new Version(8, 0, 0)));
            });


            services.AddScoped<ICategoriaRepository, CategoriaRepository>();
            services.AddScoped<IProdutosRepository, ProdutoRepository>();
            services.AddScoped<IProdutosService, ProdutoService>();
            services.AddScoped<ICategoriaService, CategoriaService>();

            services.AddAutoMapper(typeof(DomainToDTOMappingProfile));

            return services;

        }
    }
}
