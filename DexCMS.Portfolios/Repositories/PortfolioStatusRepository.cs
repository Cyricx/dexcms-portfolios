using DexCMS.Core.Repositories;
using DexCMS.Portfolios.Models;
using DexCMS.Portfolios.Interfaces;
using DexCMS.Portfolios.Contexts;
using DexCMS.Core.Contexts;
namespace DexCMS.Portfolios.Repositories
{
    public class PortfolioStatusRepository : AbstractRepository<PortfolioStatus>, IPortfolioStatusRepository
    {
        public override IDexCMSContext GetContext()
        {
            return _ctx;
        }

        private IDexCMSPortfoliosContext _ctx { get; set; }

        public PortfolioStatusRepository(IDexCMSPortfoliosContext ctx)
        {
            _ctx = ctx;
        }
    }
}