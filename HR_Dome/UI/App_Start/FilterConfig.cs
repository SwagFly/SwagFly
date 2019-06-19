using System.Web;
using System.Web.Mvc;
using UI.Filters;

namespace UI
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
            //filters.Add(new ExceptionsAttribute());//异常拦截，展出友好界面
            //filters.Add(new LoginAttribute());//全局使用登录验证，防止非法侵入
        }
    }
}
