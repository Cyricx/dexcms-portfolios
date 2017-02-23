using DexCMS.Core.Extensions;
using DexCMS.Core.Globals;
using DexCMS.Portfolios.Contexts;
using DexCMS.Portfolios.Models;

namespace DexCMS.Portfolios.Initializers
{
    class PortfolioCategoryInitializer : DexCMSInitializer<IDexCMSPortfoliosContext>
    {
        public PortfolioCategoryInitializer(IDexCMSPortfoliosContext context) : base(context)
        {
        }

        public override void Run(bool addDemoContent = true)
        {
            if (addDemoContent)
            {
                Context.PortfolioCategories.AddIfNotExists(x => x.Name,
                    new PortfolioCategory { Name = "Demos", IsActive = true },
                    new PortfolioCategory { Name = "Freelance", IsActive = true }
                );
                Context.SaveChanges();
            }
        }
    }
}
