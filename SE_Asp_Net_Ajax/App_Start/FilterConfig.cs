using System.Web;
using System.Web.Mvc;

namespace SE_Asp_Net_Ajax
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
