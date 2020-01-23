using System.Web;
using System.Web.Mvc;

namespace SRS_IN_JSON_AND_AJAX_USING_WEAPI
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
