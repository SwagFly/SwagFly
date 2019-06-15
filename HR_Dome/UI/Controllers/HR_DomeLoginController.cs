using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace UI.Controllers
{
    
    public class HR_DomeLoginController : Controller
    {
        /// <summary>
        /// 程序入口
        /// </summary>
        /// <returns></returns>
        // GET: HR_DomeMain
        public ActionResult Login()
        {
            return View();
        }
        /// <summary>
        /// 验证登录/存储登录者信息
        /// </summary>
        /// <returns></returns>
        public ActionResult Show() {
            return Content("1");
        }
    }
}