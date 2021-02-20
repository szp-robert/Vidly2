using System.Web;
using System.Web.Mvc;

namespace Vidly2
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
            filters.Add(new AuthorizeAttribute());//dodaje konieczność logowania przy wejściu na dowolny view aplikacji
            filters.Add(new RequireHttpsAttribute());//wymusza wejście na witrynę przez bezpieczny protokół https, uniemożliwia wejście przez http
        }
    }
}
