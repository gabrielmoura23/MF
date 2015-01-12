using System;
using System.Collections.Generic;
using System.Linq;
using MF.Domain.Entities;
using MF.Domain.Interfaces.Repository;
//using MF.Domain.Interfaces.Repository.ADO;
//using MF.Domain.Interfaces.Repository.ReadOnly;
using MF.Domain.Interfaces.Services;
using MF.Domain.ValueObjects;

namespace MF.Domain.Services
{
    public class VendedorService : ServiceBase<Vendedor>, IVendedorService
    {
        private readonly IVendedorRepository _modelRepository;
        //private readonly IEstudanteReadOnlyRepository _estudanteReadOnlyRepository;
        //private readonly IEstudanteADORepository _estudanteAdoRepository;

        //public EstudanteService(
        //    IEstudanteRepository estudanteRepository, 
        //    IClienteReadOnlyRepository clienteReadOnlyRepository, 
        //    IClienteADORepository clienteAdoRepository)
        //    : base(clienteRepository)
        //{
        //    _estudanteRepository = estudanteRepository;
        //    _estudanteReadOnlyRepository = clienteReadOnlyRepository;
        //    _estudanteAdoRepository = clienteAdoRepository;
        //}

        public VendedorService(
            IVendedorRepository modelRepository)
            : base(modelRepository)
        {
            _modelRepository = modelRepository;
        }

        public override Vendedor GetById(Guid id)
        {
            return _modelRepository.GetById(id);
        }

        public override IEnumerable<Vendedor> GetAll()
        {
            return _modelRepository.GetAll();
        }

        public IEnumerable<Vendedor> BuscarPorNome(string nome)
        {
            return _modelRepository.BuscarPorNome(nome);
        }

        public ValidationResult AdicionarVendedor(Vendedor model)
        {
            var resultadoValidacao = new ValidationResult();

            if (!model.IsValid())
            {
                resultadoValidacao.AdicionarErro(model.ResultadoValidacao);
                return resultadoValidacao;
            }

            base.Add(model);

            return resultadoValidacao;
        }
    }
}
