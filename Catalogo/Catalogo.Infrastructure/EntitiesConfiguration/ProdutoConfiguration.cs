using Catalogo.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Catalogo.Infrastructure.EntitiesConfiguration
{
    public class ProdutoConfiguration : IEntityTypeConfiguration<Produtos>
    {
        public void Configure(EntityTypeBuilder<Produtos> builder)
        {
            builder.HasKey(p => p.Id);
            builder.Property(p => p.Nome).HasMaxLength(100).IsRequired();
            builder.Property(p => p.Description).HasMaxLength(200).IsRequired();

            builder.Property(p => p.Preco).HasPrecision(10, 2);
            builder.Property(p => p.Imagem).HasMaxLength(250);
            builder.Property(p => p.Estoque).HasDefaultValue(1).IsRequired();
            builder.Property(p => p.DataCadastro).IsRequired();

            builder.HasOne(e => e.Categoria).WithMany(e => e.Produtos).HasForeignKey(e => e.CategoriaId);
        }
    }
}
