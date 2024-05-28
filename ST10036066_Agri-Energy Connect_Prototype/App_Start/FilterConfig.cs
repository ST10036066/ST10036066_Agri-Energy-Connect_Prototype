using System.Web;
using System.Web.Mvc;

namespace ST10036066_Agri_Energy_Connect_Prototype
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
