using System;
using System.Collections.Generic;
using MF.Application.Validation;
using MF.Application.ViewModels;

namespace MF.Application.Interfaces
{
    public interface IVendedorAppService : IDisposable
    {
        ValidationAppResult Add(VendedorViewModel modelViewModel);
        VendedorViewModel GetById(Guid id);
        IEnumerable<VendedorViewModel> GetAll();
        void Update(VendedorViewModel modelViewModel);
        void Remove(VendedorViewModel modelViewModel);
        IEnumerable<VendedorViewModel> BuscarPorNome(string nome);
    }
}
