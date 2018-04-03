[assembly: WebActivatorEx.PreApplicationStartMethod(typeof(Lanches.MVC.App_Start.NinjectWebCommon), "Start")]
[assembly: WebActivatorEx.ApplicationShutdownMethodAttribute(typeof(Lanches.MVC.App_Start.NinjectWebCommon), "Stop")]

namespace Lanches.MVC.App_Start
{
    using Lanches.Domain.Interfaces.Services;
    using Lanches.Domain.Interfaces.Repositories;
    using Lanches.Domain.Services;

    using Lanches.Application.Interfaces;
    using Lanches.Application.Services;

    using Microsoft.Web.Infrastructure.DynamicModuleHelper;
    using Ninject;
    using Ninject.Web.Common;
    using Ninject.Web.Common.WebHost;
    using System;
    using System.Web;
    using Lanches.Infraestructure.Repositories;

    public static class NinjectWebCommon
    {
        private static readonly Bootstrapper bootstrapper = new Bootstrapper();

        public static void Start()
        {
            DynamicModuleUtility.RegisterModule(typeof(OnePerRequestHttpModule));
            DynamicModuleUtility.RegisterModule(typeof(NinjectHttpModule));
            bootstrapper.Initialize(CreateKernel);
        }

        public static void Stop()
        {
            bootstrapper.ShutDown();
        }

        private static IKernel CreateKernel()
        {
            var kernel = new StandardKernel();
            try
            {
                kernel.Bind<Func<IKernel>>().ToMethod(ctx => () => new Bootstrapper().Kernel);
                kernel.Bind<IHttpModule>().To<HttpApplicationInitializationHttpModule>();

                RegisterServices(kernel);
                return kernel;
            }
            catch
            {
                kernel.Dispose();
                throw;
            }
        }
        private static void RegisterServices(IKernel kernel)
        {
            //kernel.Bind<IRepo>().ToMethod(ctx => new Repo("Ninject Rocks!"));

            // Camada Application.
            kernel.Bind(typeof(IAppServiceBase<>)).To(typeof(AppServiceBase<>));
            kernel.Bind<IIngredienteAppService>().To<IngredienteAppService>();
            kernel.Bind<ILancheAppService>().To<LancheAppService>();
            kernel.Bind<IPromocaoAppService>().To<PromocaoAppService>();


            // Camada Domain Service.
            kernel.Bind(typeof(IServiceBase<>)).To(typeof(ServiceBase<>));
            kernel.Bind<IIngredienteService>().To<IngredienteService>();
            kernel.Bind<ILancheService>().To<LancheService>();
            kernel.Bind<IPromocaoService>().To<PromocaoService>();


            // Camada Repository.
            kernel.Bind(typeof(IRepositoryBase<>)).To(typeof(RepositoryBase<>));
            kernel.Bind<IIngredienteRepository>().To<IngredienteRepository>();
            kernel.Bind<ILancheRepository>().To<LancheRepository>();
            kernel.Bind<IPromocaoRepository>().To<PromocaoRepository>();

            

            
        }
    }
}