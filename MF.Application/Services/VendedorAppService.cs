using System;
using System.Collections.Generic;
using System.Linq;
using AutoMapper;
using MF.Application.Interfaces;
using MF.Application.Validation;
using MF.Application.ViewModels;
using MF.Domain.Entities;
using MF.Domain.Interfaces.Services;
using MF.Infra.Data.Context;

namespace MF.Application.Services
{
    public class VendedorAppService : AppServiceBase<MFContext>, IVendedorAppService
    {
        private readonly IVendedorService _modelService;

        public VendedorAppService(IVendedorService modelService)
        {
            _modelService = modelService;
        }

        public ValidationAppResult Add(VendedorViewModel modelViewModel)
        {
            var model = Mapper.Map<VendedorViewModel, Vendedor>(modelViewModel);

            BeginTransaction();

            var result = _modelService.AdicionarVendedor(model);
            if (!result.IsValid)
                return DomainToApplicationResult(result);

            Commit();

            return DomainToApplicationResult(result);
        }

        public VendedorViewModel GetById(Guid id)
        {
            return Mapper.Map<Vendedor, VendedorViewModel>(_modelService.GetById(id));
        }

        public IEnumerable<VendedorViewModel> GetAll()
        {
            return Mapper.Map<IEnumerable<Vendedor>, IEnumerable<VendedorViewModel>>(_modelService.GetAll());
        }

        public IEnumerable<VendedorViewModel> BuscarPorNome(string nome)
        {
            return Mapper.Map<IEnumerable<Vendedor>, IEnumerable<VendedorViewModel>>(_modelService.BuscarPorNome(nome));
        }

        public void Update(VendedorViewModel modelViewModel)
        {
            var model = Mapper.Map<VendedorViewModel, Vendedor>(modelViewModel);

            BeginTransaction();
            _modelService.Update(model);
            Commit();
        }

        public void Remove(VendedorViewModel modelViewModel)
        {
            var model = Mapper.Map<VendedorViewModel, Vendedor>(modelViewModel);

            BeginTransaction();
            _modelService.Remove(model);
            Commit();
        }

        public void Dispose()
        {
            _modelService.Dispose();
        }
    }
}
