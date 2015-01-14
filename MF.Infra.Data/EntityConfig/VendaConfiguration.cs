using System.Data.Entity.ModelConfiguration;
using MF.Domain.Entities;

namespace MF.Infra.Data.EntityConfig
{
    public class VendaConfiguration : EntityTypeConfiguration<Venda>
    {
        public VendaConfiguration()
        {
            HasKey(c => c.IdVenda);
            
            Property(c => c.UsuCadastro)
                .IsRequired()
                .HasMaxLength(200);

            Property(t => t.UsuAlteracao)
                .HasMaxLength(200);
        }
    }
}
