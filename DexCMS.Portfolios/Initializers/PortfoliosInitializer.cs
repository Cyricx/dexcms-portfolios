using DexCMS.Core.Globals;
using DexCMS.Portfolios.Contexts;

namespace DexCMS.Portfolios.Initializers
{
    public class PortfoliosInitializer: DexCMSInitializer<IDexCMSPortfoliosContext>
    {
        public PortfoliosInitializer(IDexCMSPortfoliosContext context) : base(context) { }

        public override void Run(bool addDemoContent = true)
        {
            
        }

    }
}
