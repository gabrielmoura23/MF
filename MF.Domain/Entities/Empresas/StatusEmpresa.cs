using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MF.Domain.Entities
{
    public class StatusEmpresa
    {
        public StatusEmpresa()
        {
            this.Empresa = new List<Empresa>();
        }

        // Ativa, Pendente, Com Atraso, Encerrada, Etc...

        public int IdStatusEmpresa { get; set; }
        public string Descricao { get; set; }
        public bool FlgAtivo { get; set; }
        public System.DateTime DtCadastro { get; set; }
        public string UsuCadastro { get; set; }

        public virtual ICollection<Empresa> Empresa { get; set; }
    }
}
