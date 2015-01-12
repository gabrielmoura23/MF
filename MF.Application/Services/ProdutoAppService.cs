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
    public class ProdutoAppService : AppServiceBase<MFContext>, IProdutoAppService
    {
        private readonly IProdutoService _modelService;

        public ProdutoAppService(IProdutoService modelService)
        {
            _modelService = modelService;
        }

        public ValidationAppResult Add(ProdutoViewModel modelViewModel)
        {
            var model = Mapper.Map<ProdutoViewModel, Produto>(modelViewModel);

            BeginTransaction();

            var result = _modelService.AdicionarProduto(model);
            if (!result.IsValid)
                return DomainToApplicationResult(result);

            Commit();

            return DomainToApplicationResult(result);
        }

        public ProdutoViewModel GetById(Guid id)
        {
            return Mapper.Map<Produto, ProdutoViewModel>(_modelService.GetById(id));
        }

        public IEnumerable<ProdutoViewModel> GetAll()
        {
            return Mapper.Map<IEnumerable<Produto>, IEnumerable<ProdutoViewModel>>(_modelService.GetAll());
        }

        public IEnumerable<ProdutoViewModel> BuscarPorNome(string nome)
        {
            return Mapper.Map<IEnumerable<Produto>, IEnumerable<ProdutoViewModel>>(_modelService.BuscarPorNome(nome));
        }

        public void Update(ProdutoViewModel modelViewModel)
        {
            var model = Mapper.Map<ProdutoViewModel, Produto>(modelViewModel);

            BeginTransaction();
            _modelService.Update(model);
            Commit();
        }

        public void Remove(ProdutoViewModel modelViewModel)
        {
            var model = Mapper.Map<ProdutoViewModel, Produto>(modelViewModel);

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
