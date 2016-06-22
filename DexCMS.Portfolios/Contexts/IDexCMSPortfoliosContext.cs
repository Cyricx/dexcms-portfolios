using System.Data.Entity;
using DexCMS.Core.Infrastructure.Contexts;
using DexCMS.Portfolios.Models;

namespace DexCMS.Portfolios.Contexts
{
    public interface IDexCMSPortfoliosContext: IDexCMSContext
    {
        DbSet<PortfolioCategory> PortfolioCategories { get; set; }
        DbSet<Portfolio> Portfolios { get; set; }
        DbSet<PortfolioSkill> PortfolioSkills { get; set; }
        DbSet<PortfolioStatus> PortfolioStatuses { get; set; }
    }
}
