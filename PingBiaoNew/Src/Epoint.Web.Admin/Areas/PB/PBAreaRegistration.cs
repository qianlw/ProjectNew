using System.Web.Mvc;

namespace Epoint.Web.Admin.Areas.PB
{
    public class PBAreaRegistration : AreaRegistration
    {
        public override string AreaName
        {
            get
            {
                return "PB";
            }
        }

        public override void RegisterArea(AreaRegistrationContext context)
        {
            context.MapRoute(
                "PB_default",
                "PB/{controller}/{action}/{id}",
                new { action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}
