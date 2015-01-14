using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MF.Domain.Entities
{
    public class Venda
    {
        public Venda()
        {
            this.DetalheVenda = new List<DetalheVenda>();
        }

        public int IdVenda { get; set; }
        public int IdEmpresa { get; set; }
        public int IdVendedor { get; set; }
        public int IdFormaDePagamento { get; set; }
        public System.DateTime DtVenda { get; set; }
        public System.DateTime DtCadastro { get; set; }
        public string UsuCadastro { get; set; }
        public Nullable<System.DateTime> DtAlteracao { get; set; }
        public string UsuAlteracao { get; set; }

        public virtual Empresa Empresa { get; set; }
        public virtual Vendedor Vendedor { get; set; }
        public virtual FormaDePagamento FormaDePagamento { get; set; }
        public virtual ICollection<DetalheVenda> DetalheVenda { get; set; }
    }
}
