using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MF.Domain.Entities
{
    class FormaDePagamento
    {
        public FormaDePagamento()
        { }


        public int IdFormaDePagamento { get; set; }
        public string Descricao { get; set; }
        public bool FlgAtivo { get; set; }
        public DateTime DtCadastro { get; set; }
        public string UsuCadastro { get; set; }
    }
}
