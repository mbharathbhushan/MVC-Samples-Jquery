using System.Web;
using System.Web.Mvc;

namespace _09_Hyderlinks_In_MVC
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
