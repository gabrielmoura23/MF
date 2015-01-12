using AutoMapper;
using MF.Application.ViewModels;
using MF.Domain.Entities;

namespace MF.Application.AutoMapper
{
    public class ViewModelToDomainMappingProfile : Profile
    {
        public override string ProfileName
        {
            get { return "ViewModelToDomainMappings"; }
        }

        protected override void Configure()
        {
            Mapper.CreateMap<ProdutoViewModel, Produto>();
            Mapper.CreateMap<VendedorViewModel, Vendedor>();
            //Mapper.CreateMap<EmpresaViewModel, Empresa>();
        }
    }
}