using System.Web.Mvc;

namespace Catalog.Areas.CMS
{
    public class CMSAreaRegistration : AreaRegistration 
    {
        public override string AreaName 
        {
            get 
            {
                return "CMS";
            }
        }

        public override void RegisterArea(AreaRegistrationContext context) 
        {
            context.MapRoute(
                "CMS_Index",
                "cms",
                new
                {
                    action = "Index", 
                    controller="HomeCms"
                }
            );
            context.MapRoute(
                "CMS_Article",
                "cms/article",
                new
                {
                    action = "Index", 
                    controller="ArticleCms"
                }
            );
            context.MapRoute(
                "CMS_Article_New",
                "cms/article/new",
                new
                {
                    action = "New", 
                    controller="ArticleCms"
                }
            );
            context.MapRoute(
                "CMS_Article_Edit",
                "cms/article/{id}",
                new
                {
                    action = "Edit", 
                    controller="ArticleCms"
                }
            );
            context.MapRoute(
                "CMS_Article_Delete",
                "cms/article/delete/{id}",
                new
                {
                    action = "Delete", 
                    controller="ArticleCms"
                }
            );
            context.MapRoute(
                "CMS_Product",
                "cms/product",
                new
                {
                    action = "Index", 
                    controller="ProductCms"
                }
            );
            context.MapRoute(
                "CMS_default",
                "cms/{controller}/{action}/{id}",
                new { action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}