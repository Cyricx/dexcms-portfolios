using DexCMS.Core.Extensions;
using DexCMS.Core.Globals;
using DexCMS.Portfolios.Contexts;
using DexCMS.Portfolios.Models;

namespace DexCMS.Portfolios.Initializers
{
    class PortfolioStatusInitializer : DexCMSInitializer<IDexCMSPortfoliosContext>
    {
        public PortfolioStatusInitializer(IDexCMSPortfoliosContext context) : base(context)
        {
        }

        public override void Run(bool addDemoContent = true)
        {
            if (addDemoContent)
            {
                Context.PortfolioStatuses.AddIfNotExists(x => x.Name,
                    new PortfolioStatus { Name = "In Progress", IsActive = true },
                    new PortfolioStatus { Name = "Completed", IsActive = true }
                );
                Context.SaveChanges();
            }
        }
    }
}
