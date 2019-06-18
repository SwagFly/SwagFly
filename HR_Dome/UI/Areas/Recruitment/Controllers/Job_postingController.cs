using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Models;
using Bll;
using IBll;
using IOC;
using Newtonsoft.Json;

namespace UI.Areas.Recruitment.Controllers
{
    /// <summary>
    /// 职位发布管理控制器：（职位发布登记、变更、查询）
    /// </summary>
    public class Job_postingController : Controller
    {
        private config_file_first_kindIBLL bll = IocType.GetIocType<config_file_first_kindBLL>("config_file_first_kindBLL", "config_file_first_kindBLL");
        private config_file_second_kindBLL second_bll = IocType.GetIocType<config_file_second_kindBLL>("config_file_second_kindBLL", "config_file_second_kindBLL");
        /// <summary>
        /// 职位发布登记页面入口
        /// </summary>
        /// <returns></returns>
        // GET: Recruitment/Job_posting
        public ActionResult Registration_entrance()
        {
            return View();
        }
        /// <summary>
        /// 查询一级机构
        /// </summary>
        /// <returns>异步一级机构</returns>
        public ActionResult firstKindIdVue()
        {
            List<config_file_first_kind> list = bll.SelectFirst_kind();
            return Content(JsonConvert.SerializeObject(list));
        }
        /// <summary>
        /// 查询二级机构
        /// </summary>
        /// <returns>异步二级机构</returns>
        public ActionResult secondKindIdVue()
        {
            config_file_second_kind second = new config_file_second_kind() {
                second_kind_id=Request["fatherId"]
            };
            List<config_file_second_kind> list = second_bll.SelectSecond_kind(second);
            return Content(JsonConvert.SerializeObject(list));
        }
    }
}