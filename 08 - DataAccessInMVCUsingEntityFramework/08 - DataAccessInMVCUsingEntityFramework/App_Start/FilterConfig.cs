using System.Web;
using System.Web.Mvc;

namespace _08___DataAccessInMVCUsingEntityFramework
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
