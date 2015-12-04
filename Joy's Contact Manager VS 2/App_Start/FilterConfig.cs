using System.Web;
using System.Web.Mvc;

namespace Joy_Contact_Manager
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
            //prevents anonymouse users from accessing any methods in the application.
            filters.Add(new System.Web.Mvc.AuthorizeAttribute());
            //requires all access to the web app be through HTTPS
            filters.Add(new RequireHttpsAttribute());
        }
    }
}
