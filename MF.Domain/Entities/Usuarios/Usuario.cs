using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MF.Domain.Entities
{
    public class Usuario
    {
        public Usuario()
        { }

        public int IdUsuario { get; set; }
        public int IdPessoa { get; set; }
        public bool FlgPrivilegiado { get; set; }
        public bool FlgAtivo { get; set; }
        public string MotivoDesabilitado { get; set; }
        public System.DateTime DtCadastro { get; set; }
        public string UsuCadastro { get; set; }
        public Nullable<System.DateTime> DtAlteracao { get; set; }
        public string UsuAlteracao { get; set; }

        public virtual Pessoa Pessoa { get; set; }
    }
}
