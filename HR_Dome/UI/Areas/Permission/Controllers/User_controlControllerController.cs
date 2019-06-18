using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using IOC;
using Models;
using Bll;
using IBll;
using Newtonsoft.Json;

namespace UI.Areas.Permission.Controllers
{
    /*
    *权限管理-用户管理
    */
    public class User_controlControllerController : Controller
    {
        UsersIBll ui = IocType.GetIocType<UsersBLL>("UsersBLL", "UsersBLL");
        // GET: Permission/User_controlController
        public ActionResult Index()
        {
            return View();
        }
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public ActionResult Users()
        {
            PageModel page = new PageModel()
            {
                CurrentPage = Convert.ToInt32(Request["currentPage"]),
                PageSize = 3//每页显示记录数
            };
            List<users> datas = ui.PageData(e => e.u_id, e => e.u_id > 0, page);
            Dictionary<string, object> dic = new Dictionary<string, object>();
            dic.Add("data", datas);
            dic.Add("page", page);
            return Content(JsonConvert.SerializeObject(dic));
        }

        // GET: Permission/User_controlController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Permission/User_controlController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Permission/User_controlController/Create
        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Permission/User_controlController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Permission/User_controlController/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Permission/User_controlController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Permission/User_controlController/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
