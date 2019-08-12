using Glass.Mapper.Sc.Configuration.Attributes;
using Helixbase.Foundation.ORM.Models;

namespace Helixbase.Foundation.Sublayouts.Models
{
    [SitecoreType(TemplateId = "{C49D922D-69C3-4027-8298-C0B07E43DFE7}", AutoMap = true)]
    public interface ICssClass : ISitecoreItem
    {
        [SitecoreField("Css Class")]
        string CssClass { get; set; }
    }
}
