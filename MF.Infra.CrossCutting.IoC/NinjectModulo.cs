using Ninject.Modules;
using MF.Application.Interfaces;
using MF.Domain.Interfaces.Repository;
//using MF.Domain.Interfaces.Repository.ADO;
//using MF.Domain.Interfaces.Repository.ReadOnly;
using MF.Domain.Interfaces.Services;
using MF.Domain.Services;
using MF.Infra.Data.Context;
using MF.Infra.Data.Interfaces;
using MF.Infra.Data.Repositories;
//using MF.Infra.Data.Repositories.ADO;
//using MF.Infra.Data.Repositories.ReadOnly;
using MF.Infra.Data.UoW;
using MF.Application.Services;

namespace MF.Infra.CrossCutting.IoC
{
    public class NinjectModulo : NinjectModule
    {
        public override void Load()
        {
            // app
            Bind<IProdutoAppService>().To<ProdutoAppService>();
            Bind<IVendedorAppService>().To<VendedorAppService>();
            //Bind<IEmpresaAppService>().To<EmpresaAppService>();

            // service
            Bind(typeof(IServiceBase<>)).To(typeof(ServiceBase<>));
            Bind<IProdutoService>().To<ProdutoService>();
            Bind<IVendedorService>().To<VendedorService>();
            //Bind<IEmpresaService>().To<EmpresaService>();

            // data repos
            Bind(typeof(IRepositoryBase<>)).To(typeof(RepositoryBase<,>));
            Bind<IProdutoRepository>().To<ProdutoRepository>();
            Bind<IVendedorRepository>().To<VendedorRepository>();
            //Bind<IEmpresaRepository>().To<EmpresaRepository>();

            // data repos read only
            //Bind<IClienteReadOnlyRepository>().To<ClienteReadOnlyRepository>();
            //Bind<IFornecedorReadOnlyRepository>().To<FornecedorReadOnlyRepository>();
            //Bind<IVendaReadOnlyRepository>().To<VendaReadOnlyRepository>();
            //Bind<IProdutoReadOnlyRepository>().To<ProdutoReadOnlyRepository>();

            // ado repos only
            //Bind<IClienteADORepository>().To<ClienteADORepository>();

            // data configs
            Bind(typeof(IContextManager<>)).To(typeof(ContextManager<>));
            Bind<IDbContext>().To<MFContext>();
            Bind(typeof(IUnitOfWork<>)).To(typeof(UnitOfWork<>));

        }
    }
}
