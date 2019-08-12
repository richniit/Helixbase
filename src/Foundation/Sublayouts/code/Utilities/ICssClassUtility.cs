using System.Collections.Generic;
using Helixbase.Foundation.Sublayouts.Models;
using Sitecore.Mvc.Presentation;

namespace Helixbase.Foundation.Sublayouts.Utilities
{
    public interface ICssClassUtility
    {
        string GetInlineCssClasses(IEnumerable<ICssClass> cssClassesItems);
        string GetIndividualClass(IEnumerable<ICssClass> cssClassesItems, int index);
    }
}