using DexCMS.Portfolios.Contexts;
using System.Linq;

namespace DexCMS.Portfolios.Initializers.Helpers
{
    public class PortfolioCategoryReference
    {
        public int Demos { get; set; }
        public int Freelance { get; set; }

        public PortfolioCategoryReference(IDexCMSPortfoliosContext Context)
        {
            Demos = Context.PortfolioCategories.Where(x => x.Name == "Demos").Select(x => x.PortfolioCategoryID).Single();
            Freelance = Context.PortfolioCategories.Where(x => x.Name == "Freelance").Select(x => x.PortfolioCategoryID).Single();
        }
    }
}
