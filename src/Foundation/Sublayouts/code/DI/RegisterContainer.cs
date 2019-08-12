using Microsoft.Extensions.DependencyInjection;
using Helixbase.Foundation.Sublayouts.Utilities;
using Sitecore.DependencyInjection;

namespace Helixbase.Foundation.Sublayouts.DI
{
    public class RegisterContainer : IServicesConfigurator
    {
        public void Configure(IServiceCollection serviceCollection)
        {
            serviceCollection.AddTransient<ICssClassUtility>(provider => new CssClassUtility());
        }
    }
}