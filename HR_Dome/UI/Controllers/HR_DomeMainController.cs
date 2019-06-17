using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Models;

namespace UI.Controllers
{
    public class HR_DomeMainController : Controller
    {
        /// <summary>
        /// 总页面
        /// </summary>
        /// <returns></returns>
        // GET: HR_DomeMain
        public ActionResult MainIsUI()
        {
            return View();
        }

        /// <summary>
        /// 头部
        /// </summary>
        /// <returns></returns>
        // GET: HR_DomeMain
        public ActionResult MainIsUITop()
        {
            return View();
        }

        /// <summary>
        /// 底部背景
        /// </summary>
        /// <returns></returns>
        // GET: HR_DomeMain
        public ActionResult MainIsUIMain()
        {
            return View();
        }
    }
}