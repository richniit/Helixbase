using System.Collections.Generic;
using System.Linq;
using Helixbase.Foundation.Sublayouts.Models;

namespace Helixbase.Foundation.Sublayouts.Utilities
{
    public class CssClassUtility : ICssClassUtility
    {
        public string GetIndividualClass(IEnumerable<ICssClass> cssClassesItems, int index)
        {
            if(cssClassesItems != null)
            {
                var cssClass = cssClassesItems.ToList();
                return cssClass.Count > index ? cssClass[index].CssClass + " " : string.Empty;
            }

            return string.Empty;
        }

        public string GetInlineCssClasses(IEnumerable<ICssClass> cssClassesItems)
        {
            if (cssClassesItems != null)
            {
                return string.Join(" ", cssClassesItems.Select(p => p.CssClass));
            }

            return string.Empty;
        }
    }
}