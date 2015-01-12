using System;
using MF.Domain.Entities;
using MF.Domain.Interfaces.Specification;

namespace MF.Domain.Specification.Produtos
{
    class ProdutoEstaCadastradoMaisDeCincoAnos : ISpecification<Produto>
    {
        public bool IsSatisfiedBy(Produto model)
        {
            return DateTime.Now.Year - model.DtCadastro.Year >= 5;
        }
    }
}
