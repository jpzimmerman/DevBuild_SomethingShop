using System.Web;
using System.Web.Mvc;

namespace DevBuild.WebRegistration {
    public class FilterConfig {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters) {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
