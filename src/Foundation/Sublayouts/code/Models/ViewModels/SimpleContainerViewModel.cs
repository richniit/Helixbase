using Helixbase.Foundation.Sublayouts.Models.Parameters;
using Helixbase.Foundation.Sublayouts.Utilities;

namespace Helixbase.Foundation.Sublayouts.Models.ViewModels
{
    public class SimpleContainerViewModel
    {
        public ISimpleContainerParameters GlassModel { get; set; }
        public ICssClassUtility CssClassRepository { get; set; }
    }
}