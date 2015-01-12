using System;
using System.Collections.Generic;
using MF.Application.Validation;
using MF.Application.ViewModels;

namespace MF.Application.Interfaces
{
    public interface IProdutoAppService : IDisposable
    {
        ValidationAppResult Add(ProdutoViewModel modelViewModel);
        ProdutoViewModel GetById(Guid id);
        IEnumerable<ProdutoViewModel> GetAll();
        void Update(ProdutoViewModel modelViewModel);
        void Remove(ProdutoViewModel modelViewModel);
        IEnumerable<ProdutoViewModel> BuscarPorNome(string nome);
    }
}
