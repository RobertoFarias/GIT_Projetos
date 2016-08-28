using GClientes.Domain.Entities;
using System.Data.Entity.ModelConfiguration;

namespace GClientes.Infra.Data.EntityConfig
{
    public class CategoriaConfiguration : EntityTypeConfiguration<Categoria>
    {

        public CategoriaConfiguration()
        {
            HasKey(c => c.CategoriaId);

            Property(c => c.Nome)
                .IsRequired()
                .HasMaxLength(50);

        }

    }
}
