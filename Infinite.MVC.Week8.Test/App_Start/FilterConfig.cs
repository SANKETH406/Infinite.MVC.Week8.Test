using System.Web;
using System.Web.Mvc;

namespace Infinite.MVC.Week8.Test
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
