using GClientes.Domain.Entities;
using System.Data.Entity.ModelConfiguration;

namespace GClientes.Infra.Data.EntityConfig
{
    public class SaldoConfiguration : EntityTypeConfiguration<Saldo>
    {

        public SaldoConfiguration()
        {

            HasKey(s => s.SaldoId);
            
            Property(s => s.Pontos)
                .IsRequired();

            HasRequired(x => x.Cliente)
              .WithMany() 
              .Map(m => m.MapKey("ClienteId"));
                   
            HasRequired(x => x.Empresa)
               .WithMany()
               .Map(m => m.MapKey("EmpresaId"));
            
        }

    }
}
