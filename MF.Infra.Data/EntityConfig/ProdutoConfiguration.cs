using System.Data.Entity.ModelConfiguration;
using MF.Domain.Entities;

namespace MF.Infra.Data.EntityConfig
{
    public class ProdutoConfiguration : EntityTypeConfiguration<Produto>
    {
        public ProdutoConfiguration()
        {
            HasKey(c => c.IdProduto);

            Property(c => c.Descricao)
                .IsRequired()
                .HasMaxLength(150);

            Property(c => c.Sigla)
                .IsRequired()
                .HasMaxLength(150);

            //Property(c => c.Email)
            //    .IsRequired();

            //Ignore(t => t.ResultadoValidacao);

            //Property(c => c.CPF)
            //    .IsRequired()
            //    .HasMaxLength(11);
        }
    }
}
