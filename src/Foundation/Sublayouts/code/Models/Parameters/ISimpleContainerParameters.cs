using Glass.Mapper.Sc.Configuration.Attributes;
using Helixbase.Foundation.ORM.Models;
using System.Collections.Generic;

namespace Helixbase.Foundation.Sublayouts.Models.Parameters
{
    [SitecoreType(TemplateId = "{FEBAC1D8-721F-4F5B-9F63-9BD2789EF913}", AutoMap = true)]
    public interface ISimpleContainerParameters : ISitecoreItem
    {        
        bool HideContainer { get; set; }
        IEnumerable<ICssClass> CssClasses { get; set; }
        IHtmlTag ContainerTag { get; set; }
        string ContainerId { get; set; }
    }
}
