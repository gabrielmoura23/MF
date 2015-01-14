using System.Data.Entity.ModelConfiguration;
using MF.Domain.Entities;

namespace MF.Infra.Data.EntityConfig
{
    public class ProdutoConfiguration : EntityTypeConfiguration<Produto>
    {
        public ProdutoConfiguration()
        {
            HasKey(c => c.IdProduto);

            // Properties
            //this.Property(t => t.idunidade)
            //    .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            Property(c => c.Descricao)
                .IsRequired()
                .HasMaxLength(150);

            Property(c => c.Sigla)
                .IsRequired()
                .HasMaxLength(150);

            Property(c => c.FlgAtivo)
                .IsRequired();

            Ignore(t => t.ResultadoValidacao);

            Property(c => c.UsuCadastro)
                .IsRequired()
                .HasMaxLength(200);

            Property(t => t.UsuAlteracao)
                .HasMaxLength(200);

            // Table & Column Mappings
            //this.ToTable("Produto");
            //this.Property(t => t.IdProduto).HasColumnName("IdProduto");
            //this.Property(t => t.Descricao).HasColumnName("Descricao");
            //this.Property(t => t.Sigla).HasColumnName("Sigla");
            //this.Property(t => t.IdTipoProduto).HasColumnName("IdTipoProduto");
            //this.Property(t => t.IdTipoUnidade).HasColumnName("IdTipoUnidade");
            //this.Property(t => t.ValorUnitario).HasColumnName("ValorUnitario");
            //this.Property(t => t.QtdEstoqueMinimo).HasColumnName("QtdEstoqueMinimo");
            //this.Property(t => t.QtdEstoque).HasColumnName("QtdEstoque");
            //this.Property(t => t.FlgAtivo).HasColumnName("FlgAtivo");
            //this.Property(t => t.DtCadastro).HasColumnName("DtCadastro");
            //this.Property(t => t.UsuCadastro).HasColumnName("UsuCadastro");
            //this.Property(t => t.DtAlteracao).HasColumnName("DtAlteracao");
            //this.Property(t => t.UsuAlteracao).HasColumnName("UsuAlteracao");
            
            // Relationships
            this.HasRequired(t => t.TipoProduto)
                .WithMany(t => t.Produto)
                .HasForeignKey(d => d.IdTipoProduto);

            this.HasRequired(t => t.TipoUnidade)
                .WithMany(t => t.Produto)
                .HasForeignKey(d => d.IdTipoUnidade);
        }
    }
}
