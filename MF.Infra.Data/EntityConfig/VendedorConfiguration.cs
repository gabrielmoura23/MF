using System.Data.Entity.ModelConfiguration;
using MF.Domain.Entities;

namespace MF.Infra.Data.EntityConfig
{
    public class VendedorConfiguration : EntityTypeConfiguration<Vendedor>
    {
        public VendedorConfiguration()
        {
            HasKey(c => c.IdVendedor);

            Property(c => c.FlgPrivilegiado)
                .IsRequired();

            Property(c => c.FlgAtivo)
                .IsRequired();
            
            Property(c => c.MotivoDesabilitado)
                .HasMaxLength(200);

            Property(c => c.UsuCadastro)
                .IsRequired()
                .HasMaxLength(200);

            Property(t => t.UsuAlteracao)
                .HasMaxLength(200);

            Ignore(t => t.ResultadoValidacao);

            // Relationships
            this.HasRequired(t => t.Pessoa)
                .WithMany(t => t.Vendedor)
                .HasForeignKey(d => d.IdPessoa);
        
        }
    }
}
