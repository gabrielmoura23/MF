using System.Data.Entity.ModelConfiguration;
using MF.Domain.Entities;

namespace MF.Infra.Data.EntityConfig
{
    public class VendedorConfiguration : EntityTypeConfiguration<Vendedor>
    {
        public VendedorConfiguration()
        {
            HasKey(c => c.IdVendedor);

            Property(c => c.NomeCompleto)
                .IsRequired()
                .HasMaxLength(150);

            Property(c => c.Cpf)
                .IsRequired()
                .HasMaxLength(20);

            //Property(c => c.Email)
            //    .IsRequired();

            //Ignore(t => t.ResultadoValidacao);

            //Property(c => c.CPF)
            //    .IsRequired()
            //    .HasMaxLength(11);
        }
    }
}
