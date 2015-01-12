using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MF.Domain.Entities
{
    public class DetalheVenda
    {
        public DetalheVenda() 
        { }
        
        public int IdVenda { get; set; }
        public int IdProduto { get; set; }
        public int QtdProduto { get; set; }
        public DateTime DtCadastro { get; set; }
        public string UsuCadastro { get; set; }
        public DateTime DtAlteracao { get; set; }
        public string UsuAlteracao { get; set; }
    }
}
