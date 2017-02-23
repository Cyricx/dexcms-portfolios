using System.Data.Entity;
using DexCMS.Portfolios.Models;
using DexCMS.Base.Contexts;

namespace DexCMS.Portfolios.Contexts
{
    public interface IDexCMSPortfoliosContext: IDexCMSBaseContext
    {
        DbSet<PortfolioCategory> PortfolioCategories { get; set; }
        DbSet<Portfolio> Portfolios { get; set; }
        DbSet<PortfolioSkill> PortfolioSkills { get; set; }
        DbSet<PortfolioStatus> PortfolioStatuses { get; set; }
    }
}
