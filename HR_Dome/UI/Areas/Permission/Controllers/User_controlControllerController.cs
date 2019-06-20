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
using System.Data;

namespace UI.Areas.Permission.Controllers
{
    /*
    *权限管理-用户管理
    */
    public class User_controlControllerController : Controller
    {
        RoleIBLL role = IocType.GetIocType<RoleBLL>("RoleBLL", "RoleBLL");
        UsersIBll ui = IocType.GetIocType<UsersBLL>("UsersBLL", "UsersBLL");//用户表
        UsersAndRoleIBll ur = IocType.GetIocType<UsersAndRoleBll>("UsersAndRoleBll", "UsersAndRoleBll");//用户表和管理员表
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
            List<vw_usersAndRole> datas = ur.PageData(e => e.u_id, e => e.u_id > 0, page);
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
        public ActionResult Create(users us)
        {
            if (ui.Insert(us) > 0)
            {
                return RedirectToAction("Index");
            }
            else
            {
                return RedirectToAction("Create");
            }
        }
        // GET: Permission/User_controlController/Edit/5
        public ActionResult Edit(int id)
        {
            users uss = ui.SelectWhere(e => e.u_id == id).FirstOrDefault();
            return View(uss);
        }
        // POST: Permission/User_controlController/Edit/5
        [HttpPost]
        public ActionResult Edit(users us)
        {
            if (ui.Updates(us) > 0)
            {
                return RedirectToAction("Index");
            }
            else
            {
                return RedirectToAction("Edit");
            }
        }

        // GET: Permission/User_controlController/Delete/5

        // POST: Permission/User_controlController/Delete/5
        //删除用户
        public ActionResult Delete(int id)
        {
            users us = new users()
            {
                u_id=(short)id
            };
            if (ui.Delete(us) > 0)
            {
                return RedirectToAction("Index");
            }
            else
            {
                return RedirectToAction("Index");
            }
        }
        //查询管理员表
        public ActionResult GetOption()
        {
            List<Role> list = role.SelectAll();
            return Content(JsonConvert.SerializeObject(list));
        }
    }
}
