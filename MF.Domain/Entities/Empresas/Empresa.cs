using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MF.Domain.Entities
{
    public class Empresa
    {
        public Empresa()
        {
            this.EmpresaFilial = new List<EmpresaFilial>();
            this.UsuarioExternoEmpresa = new List<UsuarioExternoEmpresa>();
            this.EmpresaContato = new List<EmpresaContato>();
            this.Venda = new List<Venda>();
        }

        public int IdEmpresa { get; set; }
        public int IdStatusEmpresa { get; set; }
        //Tem pessoa fisica? (cpf)
        public string Cnpj { get; set; }
        public string RazaoSocial { get; set; }
        public string NomeFantasia { get; set; }
        public string Endereco { get; set; }
        public string EndNum { get; set; }
        public string Bairro { get; set; }
        public string IdEstado { get; set; }
        public int IdCidade { get; set; }
        public string Cep { get; set; }
        public string DddTelefone { get; set; }
        public string Telefone { get; set; }
        public string RamalTelefone { get; set; }
        public string DddFax { get; set; }
        public string Fax { get; set; }
        public string DddCelular { get; set; }
        public string Celular { get; set; }
        public string Email { get; set; }
        public string RepresentanteNome { get; set; }
        public string RepresentanteCargo { get; set; }
        public string RepresentanteEmail { get; set; }
        public string RepresentanteDddTelefone { get; set; }
        public string RepresentanteTelefone { get; set; }
        public string RepresentanteDddCelular { get; set; }
        public string RepresentanteCelular { get; set; }
        public bool FlgAtivo { get; set; }
        public System.DateTime DtCadastro { get; set; }
        public string UsuCadastro { get; set; }
        public Nullable<System.DateTime> DtAlteracao { get; set; }
        public string UsuAlteracao { get; set; }

        public virtual Estado Estado { get; set; }
        public virtual Cidade Cidade { get; set; }
        public virtual StatusEmpresa StatusEmpresa { get; set; }

        public virtual ICollection<EmpresaFilial> EmpresaFilial { get; set; }
        public virtual ICollection<UsuarioExternoEmpresa> UsuarioExternoEmpresa { get; set; }
        public virtual ICollection<EmpresaContato> EmpresaContato { get; set; }
        public virtual ICollection<Venda> Venda { get; set; }
    }
}
