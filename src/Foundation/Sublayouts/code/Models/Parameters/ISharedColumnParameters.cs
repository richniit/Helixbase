using Glass.Mapper.Sc.Configuration.Attributes;
using Helixbase.Foundation.ORM.Models;
using System.Collections.Generic;

namespace Helixbase.Foundation.Sublayouts.Models.Parameters
{
    [SitecoreType(AutoMap = true)]
    public interface ISharedColumnParameters : ISitecoreItem
    {   
        int Columns { get; set; }
        bool HideRow { get; set; }
        IEnumerable<ICssClass> RowCssClasses { get; set; }
    }
}
