using DexCMS.Core.Repositories;
using DexCMS.Portfolios.Models;
using DexCMS.Portfolios.Interfaces;
using DexCMS.Portfolios.Contexts;
using DexCMS.Core.Contexts;
namespace DexCMS.Portfolios.Repositories
{
    public class PortfolioRepository : AbstractRepository<Portfolio>, IPortfolioRepository
    {
        public override IDexCMSContext GetContext()
        {
            return _ctx;
        }

        private IDexCMSPortfoliosContext _ctx { get; set; }

        public PortfolioRepository(IDexCMSPortfoliosContext ctx)
        {
            _ctx = ctx;
        }
    }
}