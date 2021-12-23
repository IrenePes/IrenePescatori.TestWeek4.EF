using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Week4.EsercitazioneFinale.Core.Entities;

namespace Week4.EsercitazioneFinaleEF
{
    public class SpesaConfiguration : IEntityTypeConfiguration<Spesa>
    {
        public void Configure(EntityTypeBuilder<Spesa> builder)
        {
            builder.HasKey(s => s.SpesaId);
            builder.Property(s => s.Data).IsRequired();
            builder.Property(s => s.Descrizione).IsRequired();
            builder.Property(s => s.Utente).IsRequired();
            builder.Property(s => s.Importo).IsRequired();
            builder.Property(s => s.Approvato).IsRequired();

            builder.HasOne(s => s.Categoria).WithMany(c => c.Spese).HasForeignKey(s => s.CategoriaId);

        }
    }
}