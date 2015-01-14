using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MF.Domain.Entities
{
    public class UsuarioExternoEmpresa
    {
        public UsuarioExternoEmpresa()
        { }

        public int IdUsuarioExternoEmpresa { get; set; }
        public int IdUsuarioExterno { get; set; }
        public int IdEmpresa { get; set; }
        public Nullable<int> IdEmpresaFilial { get; set; }
        public bool FlgPrivilegiado { get; set; }
        public bool FlgAtivo { get; set; }
        public string MotivoDesabilitado { get; set; }
        public System.DateTime DtCadastro { get; set; }
        public string UsuCadastro { get; set; }
        public Nullable<System.DateTime> DtAlteracao { get; set; }
        public string UsuAlteracao { get; set; }

        public virtual UsuarioExterno UsuarioExterno { get; set; }
        public virtual Empresa Empresa { get; set; }
        public virtual EmpresaFilial EmpresaFilial { get; set; }
    }
}
