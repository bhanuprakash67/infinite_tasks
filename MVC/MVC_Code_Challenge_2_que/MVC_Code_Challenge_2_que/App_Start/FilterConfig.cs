using System.Web;
using System.Web.Mvc;

namespace MVC_Code_Challenge_2_que
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
