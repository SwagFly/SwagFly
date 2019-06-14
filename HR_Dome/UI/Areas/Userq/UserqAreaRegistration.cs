using System.Web.Mvc;

namespace UI.Areas.Userq
{
    public class UserqAreaRegistration : AreaRegistration 
    {
        public override string AreaName 
        {
            get 
            {
                return "Userq";
            }
        }

        public override void RegisterArea(AreaRegistrationContext context) 
        {
            context.MapRoute(
                "Userq_default",
                "Userq/{controller}/{action}/{id}",
                new { action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}