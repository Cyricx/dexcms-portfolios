using DexCMS.Core.Infrastructure.Repositories;
using DexCMS.Portfolios.Models;
using DexCMS.Portfolios.Interfaces;
using DexCMS.Portfolios.Contexts;
using DexCMS.Core.Infrastructure.Contexts;
namespace DexCMS.Portfolios.Repositories
{
    public class PortfolioSkillRepository : AbstractRepository<PortfolioSkill>, IPortfolioSkillRepository
    {
        public override IDexCMSContext GetContext()
        {
            return _ctx;
        }

        private IDexCMSPortfoliosContext _ctx { get; set; }

        public PortfolioSkillRepository(IDexCMSPortfoliosContext ctx)
        {
            _ctx = ctx;
        }
    }
}