using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MF.Domain.Entities
{
    public class TipoProduto
    {
        public TipoProduto()
        {
            this.Produto = new List<Produto>();
        }

        public int IdTipoProduto { get; set; }
        public string Descricao { get; set; }
        public bool FlgAtivo { get; set; }
        public System.DateTime DtCadastro { get; set; }
        public string UsuCadastro { get; set; }

        public virtual ICollection<Produto> Produto { get; set; }
    }
}
