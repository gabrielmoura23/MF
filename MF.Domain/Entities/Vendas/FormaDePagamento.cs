using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MF.Domain.Entities
{
    public class FormaDePagamento
    {
        public FormaDePagamento()
        {
            this.Venda = new List<Venda>();
        }

        public int IdFormaDePagamento { get; set; }
        public string Descricao { get; set; }
        public bool FlgAtivo { get; set; }
        public System.DateTime DtCadastro { get; set; }
        public string UsuCadastro { get; set; }

        public virtual ICollection<Venda> Venda { get; set; }
    }
}
