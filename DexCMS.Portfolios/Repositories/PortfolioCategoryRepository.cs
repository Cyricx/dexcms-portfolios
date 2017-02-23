using DexCMS.Core.Repositories;
using DexCMS.Portfolios.Models;
using DexCMS.Portfolios.Interfaces;
using DexCMS.Portfolios.Contexts;
using DexCMS.Core.Contexts;

namespace DexCMS.Portfolios.Repositories
{
    public class PortfolioCategoryRepository : AbstractRepository<PortfolioCategory>, IPortfolioCategoryRepository
    {
        public override IDexCMSContext GetContext()
        {
            return _ctx;
        }

        private IDexCMSPortfoliosContext _ctx { get; set; }

        public PortfolioCategoryRepository(IDexCMSPortfoliosContext ctx)
        {
            _ctx = ctx;
        }
    }
}