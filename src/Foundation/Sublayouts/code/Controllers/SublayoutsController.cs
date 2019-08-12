using Helixbase.Foundation.Content.Repositories;
using Helixbase.Foundation.Sublayouts.Models.Parameters;
using Helixbase.Foundation.Sublayouts.Models.ViewModels;
using Helixbase.Foundation.Sublayouts.Utilities;
using Sitecore.Mvc.Controllers;
using System.Web.Mvc;

namespace Helixbase.Foundation.Sublayouts.Controllers
{
    public class SublayoutsController : SitecoreController
    {
        private readonly IRenderingRepository _renderingRepository;
        private readonly ICssClassUtility _cssClassUtility;


        public SublayoutsController(IRenderingRepository renderingRepository, ICssClassUtility cssClassUtility)
        {
            _renderingRepository = renderingRepository;
            _cssClassUtility = cssClassUtility;
        }

        // GET: Sublayouts
        public ActionResult SimpleContainer()
        {
            var param = _renderingRepository.GetRenderingParameters<ISimpleContainerParameters>();
            return View("/Views/Foundation/Sublayouts/SimpleContainer.cshtml",
                new SimpleContainerViewModel() {
                    GlassModel = param,
                    CssClassRepository = _cssClassUtility
                });
        }

        // GET: Sublayouts
        public ActionResult MultiColumn()
        {
            var param = _renderingRepository.GetRenderingParameters<IMulticolumnEqualSizesParameters>();
            return View("/Views/Foundation/Sublayouts/Multicolumn.cshtml", 
                new MulticolumnViewModel() {
                    GlassModel = param,
                    CssClassRepository = _cssClassUtility
                });
        }     
    }
}