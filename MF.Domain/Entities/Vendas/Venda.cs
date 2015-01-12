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
        { }


        public int IdVenda { get; set; }
        public string IdEmpresa { get; set; }
        public DateTime DtVenda { get; set; }
        public int IdFormaDePagamento { get; set; }
        public int CodVendedor { get; set; }
        
        public DateTime DtCadastro { get; set; }
        public string UsuCadastro { get; set; }
        public DateTime DtAlteracao { get; set; }
        public string UsuAlteracao { get; set; }
    }

    /*
     * CodVenda
     * 
       CodEmpresa  
       CodCliente
        DtVenda
     
     * 
     * 
     * 
     * */
}
