using System.Web.Mvc;

namespace Catalog.Areas.Catalog
{
    public class CatalogAreaRegistration : AreaRegistration 
    {
        public override string AreaName 
        {
            get 
            {
                return "Catalog";
            }
        }

        public override void RegisterArea(AreaRegistrationContext context) 
        {
            context.MapRoute(
                "Default",
                "{controller}/{action}/{id}",
                new {controller = "Home", action = "Index", id = UrlParameter.Optional}
            );
            
            
//            context.MapRoute(
//                "Catalog_default",
//                "Catalog/{controller}/{action}/{id}",
//                new { action = "Index", id = UrlParameter.Optional }
//            );
        }
    }
}