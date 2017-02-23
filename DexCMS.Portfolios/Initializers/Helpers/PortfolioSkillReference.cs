using DexCMS.Portfolios.Contexts;
using System.Linq;

namespace DexCMS.Portfolios.Initializers.Helpers
{
    public class PortfolioSkillReference
    {
        public int SomeSkill { get; set; }
        public int OtherSkill { get; set; }
        public int AnotherSkill { get; set; }

        public PortfolioSkillReference(IDexCMSPortfoliosContext Context)
        {
            SomeSkill = Context.PortfolioSkills.Where(x => x.Name == "Some Skill").Select(x => x.PortfolioSkillID).Single();
            OtherSkill = Context.PortfolioSkills.Where(x => x.Name == "Other Skill").Select(x => x.PortfolioSkillID).Single();
            AnotherSkill = Context.PortfolioSkills.Where(x => x.Name == "Another Skill").Select(x => x.PortfolioSkillID).Single();
        }
    }
}
