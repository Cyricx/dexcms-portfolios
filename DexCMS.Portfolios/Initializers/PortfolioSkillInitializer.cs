using DexCMS.Core.Extensions;
using DexCMS.Core.Globals;
using DexCMS.Portfolios.Contexts;
using DexCMS.Portfolios.Models;

namespace DexCMS.Portfolios.Initializers
{
    class PortfolioSkillInitializer : DexCMSInitializer<IDexCMSPortfoliosContext>
    {
        public PortfolioSkillInitializer(IDexCMSPortfoliosContext context) : base(context)
        {
        }

        public override void Run(bool addDemoContent = true)
        {
            if (addDemoContent)
            {
                Context.PortfolioSkills.AddIfNotExists(x => x.Name,
                    new PortfolioSkill { Name = "Some skill", IsActive = true },
                    new PortfolioSkill { Name = "Other skill", IsActive = true },
                    new PortfolioSkill { Name = "Another Skill", IsActive = true }
                );
                Context.SaveChanges();
            }
        }
    }
}
