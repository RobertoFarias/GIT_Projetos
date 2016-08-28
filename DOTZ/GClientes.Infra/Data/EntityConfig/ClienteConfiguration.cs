using GClientes.Domain.Entities;
using GClientes.Domain.ValueObject;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.Infrastructure.Annotations;
using System.Data.Entity.ModelConfiguration;

namespace GClientes.Infra.Data.EntityConfig
{
    public class ClienteConfiguration : EntityTypeConfiguration<Cliente>
    {

        public ClienteConfiguration()
        {

            HasKey(c => c.ClienteId);

            Property(c => c.Nome)
             .IsRequired()
             .HasMaxLength(Cliente.NomeMaxLength);
         
                
            Property(c => c.Sobrenome)
                .IsRequired()
                .HasMaxLength(Cliente.SobrenbomeMaxLength);

            Property(c => c.Email.Endereco)
                .IsRequired();


            //HasKey(c => c.ClienteId);

            //Property(c => c.Nome)
            //    .IsRequired()
            //    .HasMaxLength(150);

            //Property(c => c.Sobrenome)
            //    .IsRequired()
            //    .HasMaxLength(150);

            //Property(c => c.Email.Endereco)
            //    .IsRequired();

        }

    }
}
