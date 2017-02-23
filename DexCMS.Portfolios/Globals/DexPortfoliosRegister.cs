using DexCMS.Portfolios.Contexts;
using DexCMS.Portfolios.Interfaces;
using DexCMS.Portfolios.Repositories;
using Ninject;

namespace DexCMS.Portfolios.Globals
{
    public static class PortfoliosRegister<T> where T : IDexCMSPortfoliosContext
    {
        public static void RegisterServices(IKernel kernel)
        {
            kernel.Bind<IPortfolioCategoryRepository>().To<PortfolioCategoryRepository>();
            kernel.Bind<IPortfolioRepository>().To<PortfolioRepository>();
            kernel.Bind<IPortfolioSkillRepository>().To<PortfolioSkillRepository>();
            kernel.Bind<IPortfolioStatusRepository>().To<PortfolioStatusRepository>();
            kernel.Bind<IDexCMSPortfoliosContext>().To<T>();
        }
    }
}
