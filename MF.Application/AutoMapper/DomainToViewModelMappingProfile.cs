using AutoMapper;
using MF.Application.ViewModels;
using MF.Domain.Entities;

namespace MF.Application.AutoMapper
{
    public class DomainToViewModelMappingProfile : Profile
    {
        public override string ProfileName
        {
            get { return "DomainToViewModelMappings"; }
        }

        protected override void Configure()
        {
            Mapper.CreateMap<Produto, ProdutoViewModel>();
            Mapper.CreateMap<Vendedor, VendedorViewModel>();
            //Mapper.CreateMap<Empresa, EmpresaViewModel>();
        }
    }
}