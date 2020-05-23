using System;
using System.Web.Mvc;

namespace Catalog.Areas.CMS.Helpers
{
    public static class LabelExtensions
    {
        public static MvcHtmlString CustomLabel(this HtmlHelper helper, string text)
        {
            return MvcHtmlString.Create(
                String.Format("<p class='m-b-15 c-black'>{0}</p>", text)
            );
        }
    }
}