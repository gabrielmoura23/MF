﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MF.Domain.Entities
{
    public class Cidade
    {
        public Cidade()
        {
            this.Empresa = new List<Empresa>();
            this.EmpresaFilial = new List<EmpresaFilial>();
            this.Pessoa = new List<Pessoa>();
            this.UsuarioExterno = new List<UsuarioExterno>();
        }

        public int IdCidade { get; set; }
        public string IdEstado { get; set; }
        public string Descricao { get; set; }
        public bool FlgAtivo { get; set; }
        public Nullable<int> Ordem { get; set; }
        public System.DateTime DtCadastro { get; set; }
        public string UsuCadastro { get; set; }

        public virtual Estado Estado { get; set; }
        public virtual ICollection<Empresa> Empresa { get; set; }
        public virtual ICollection<EmpresaFilial> EmpresaFilial { get; set; }
        public virtual ICollection<Pessoa> Pessoa { get; set; }
        public virtual ICollection<UsuarioExterno> UsuarioExterno { get; set; }
    }
}
