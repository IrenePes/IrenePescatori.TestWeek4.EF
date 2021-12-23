using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Week4.EsercitazioneFinale.Core.Entities;

namespace Week4.EsercitazioneFinaleEF
{
    public class CategoriaConfiguration : IEntityTypeConfiguration<Categoria>
    {
        public void Configure(EntityTypeBuilder<Categoria> builder)
        {
            builder.HasKey(c => c.CategoriaId);
            builder.Property(c => c.Nome).IsRequired();

            builder.HasMany(c => c.Spese).WithOne(s => s.Categoria).HasForeignKey(s => s.CategoriaId);
        }

    }
}