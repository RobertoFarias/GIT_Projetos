using GClientes.Domain.Entities;
using System.Data.Entity.ModelConfiguration;

namespace GClientes.Infra.Data.EntityConfig
{
    public class EmpresaConfiguration : EntityTypeConfiguration<Empresa>
    {


        public EmpresaConfiguration()
        {
            HasKey(e => e.EmpresaId);

            Property(e => e.Razao)
                .IsRequired()
                .HasMaxLength(50);
                        
        }

    }
}
