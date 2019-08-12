using Glass.Mapper.Sc.Configuration.Attributes;
using Helixbase.Foundation.ORM.Models;

namespace Helixbase.Foundation.Sublayouts.Models
{
    [SitecoreType(TemplateId = "{0C658A14-A7F9-4FA4-BA98-7ED581F94888}", AutoMap = true)]
    public interface IHtmlTag : IGlassBase
    {
        [SitecoreField("Html Tag")]
        string HtmlTag { get; set; }
    }
}
