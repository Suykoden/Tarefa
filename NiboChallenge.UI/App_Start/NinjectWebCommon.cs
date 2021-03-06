using NiboChallenge.Domain.Interfaces.Repositories;
using NiboChallenge.Domain.Interfaces.Services;
using NiboChallenge.Domain.Services;
using NiboChallenger.Application;
using NiboChallenger.Application.Interface;
using NiboChallenger.Infra.Repositories;

[assembly: WebActivatorEx.PreApplicationStartMethod(typeof(NiboChallenge.UI.App_Start.NinjectWebCommon), "Start")]
[assembly: WebActivatorEx.ApplicationShutdownMethodAttribute(typeof(NiboChallenge.UI.App_Start.NinjectWebCommon), "Stop")]

namespace NiboChallenge.UI.App_Start
{
    using System;
    using System.Web;

    using Microsoft.Web.Infrastructure.DynamicModuleHelper;

    using Ninject;
    using Ninject.Web.Common;
     using System.Web.Http.Dependencies;
    using Ninject.Syntax;
    public static class NinjectWebCommon
    {
        private static readonly Bootstrapper bootstrapper = new Bootstrapper();

        /// <summary>
        /// Starts the application
        /// </summary>
        public static void Start()
        {
            DynamicModuleUtility.RegisterModule(typeof(OnePerRequestHttpModule));
            DynamicModuleUtility.RegisterModule(typeof(NinjectHttpModule));
            bootstrapper.Initialize(CreateKernel);
        }

        /// <summary>
        /// Stops the application.
        /// </summary>
        public static void Stop()
        {
            bootstrapper.ShutDown();
        }

        /// <summary>
        /// Creates the kernel that will manage your application.
        /// </summary>
        /// <returns>The created kernel.</returns>
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

        public static IKernel CreateKernelForWebApi()
        {
            var kernel = new StandardKernel();
            try
            {

                RegisterServices(kernel);
                return kernel;
            }
            catch
            {
                kernel.Dispose();
                throw;
            }
        }

        /// <summary>
        /// Load your modules or register your services here!
        /// </summary>
        /// <param name="kernel">The kernel.</param>
        private static void RegisterServices(IKernel kernel)
        {

            //application
            kernel.Bind(typeof(IAppServiceBase<>)).To(typeof(AppServiceBase<>));
            kernel.Bind<IContenderAppService>().To<ContenderAppService>();
            kernel.Bind<ITeamAppService>().To<TeamAppService>();
            kernel.Bind<IContenderCategoryAppService>().To<ContenderCategoryAppService>();
            kernel.Bind<ISkillAppService>().To<SkillAppService>();
            kernel.Bind<IContenderTeamAppService>().To<ContenderTeamAppService>();
            kernel.Bind<ITournamentAppService>().To<TournamentAppService>();
            kernel.Bind<IPlayoffAppService>().To<PlayoffAppService>();
            kernel.Bind<ITournamentFinalAppService>().To<TournamentFinalAppService>();
            kernel.Bind<IWinnerAppService>().To<WinnerAppService>();

            //Domain
            kernel.Bind(typeof(IServicoBase<>)).To(typeof(ServiceBase<>));
            kernel.Bind<IContenderService>().To<ContenderService>();
            kernel.Bind<ITeamService>().To<TeamService>();
            kernel.Bind<IContenderCategoryService>().To<ContenderCategoryService>();
            kernel.Bind<ISkillService>().To<SkillService>();
            kernel.Bind<IContenderTeamService>().To<ContenderTeamService>();
            kernel.Bind<ITournamentService>().To<TournamenService>();
            kernel.Bind<IPlayOffService>().To<PlayOffService>();
            kernel.Bind<ITournamentFinalService>().To<TournamentFinalService>();
            kernel.Bind<IWinnnerService>().To<WinnerService>();

            //Repositories
            kernel.Bind(typeof(IRepositoryBase<>)).To(typeof(RepositoryBase<>));
            kernel.Bind<IContenderRepository>().To<ContenderRepository>();
            kernel.Bind<ITeamRepository>().To<TeamRepository>();
            kernel.Bind<IContenderCategoryRepository>().To<ContenderCategoryRepository>();
            kernel.Bind<ISkillRepository>().To<SkillRepository>();
            kernel.Bind<IContenderTeamRepository>().To<ContenderTeamRepository>();
            kernel.Bind<ITournamentRepository>().To<TournamentRepository>();
            kernel.Bind<IPlayOffRepository>().To<PlayoffRepository>();
            kernel.Bind<ITournamentFinalRepository>().To<TournamentFinalRepository>();
            kernel.Bind<IWinnerReposigory>().To<WinnerRepository>();
        }
    }

    public class NinjectDependencyScope : IDependencyScope
    {
        IResolutionRoot resolver;

        public NinjectDependencyScope(IResolutionRoot resolver)
        {
            this.resolver = resolver;
        }

        public object GetService(Type serviceType)
        {
            if (resolver == null)
                throw new ObjectDisposedException("this", "This scope has been disposed");

            return resolver.TryGet(serviceType);
        }

        public System.Collections.Generic.IEnumerable<object> GetServices(Type serviceType)
        {
            if (resolver == null)
                throw new ObjectDisposedException("this", "This scope has been disposed");

            return resolver.GetAll(serviceType);
        }

        public void Dispose()
        {
            IDisposable disposable = resolver as IDisposable;
            if (disposable != null)
                disposable.Dispose();

            resolver = null;
        }
    }

    // This class is the resolver, but it is also the global scope
    // so we derive from NinjectScope.
    public class NinjectDependencyResolver : NinjectDependencyScope, IDependencyResolver
    {
        IKernel kernel;

        public NinjectDependencyResolver(IKernel kernel) : base(kernel)
        {
            this.kernel = kernel;
        }

        public IDependencyScope BeginScope()
        {
            return new NinjectDependencyScope(kernel.BeginBlock());
        }
    }
}
