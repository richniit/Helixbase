using Glass.Mapper.Sc.Configuration.Attributes;
using Helixbase.Foundation.ORM.Models;
using System.Collections.Generic;

namespace Helixbase.Foundation.Sublayouts.Models.Parameters
{
    [SitecoreType(TemplateId = "{AD3EE504-C109-46AA-9689-4C7881FC09E4}", AutoMap = true)]
    public interface IMulticolumnEqualSizesParameters : ISharedColumnParameters, IGlassBase
    {
        IEnumerable<ICssClass> ColumnCssClasses { get; set; }
        IEnumerable<ICssClass> IndividualColumnCssClasses { get; set; }
    }
}
