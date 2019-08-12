using Helixbase.Foundation.Sublayouts.Models.Parameters;
using Helixbase.Foundation.Sublayouts.Utilities;

namespace Helixbase.Foundation.Sublayouts.Models.ViewModels
{
    public class MulticolumnViewModel
    {
        public IMulticolumnEqualSizesParameters GlassModel { get; set; }
        public ICssClassUtility CssClassRepository { get; set; }
    }
}