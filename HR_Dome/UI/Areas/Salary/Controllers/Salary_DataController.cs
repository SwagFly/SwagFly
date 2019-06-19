using Bll;
using IBll;
using IOC;
using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace UI.Areas.Salary.Controllers
{
    public class Salary_DataController : Controller
    {
        //薪酬发放登记表
        salary_standardIBLL slbll = IocType.GetIocType<salary_standardBLL>("salary_grantBLL", "salary_grantBLL");
        //薪酬发放详细表
        salary_standard_detailsIBLL sdbll = IocType.GetIocType<salary_standard_detailsBLL>("salary_grant_detailsBLL", "salary_grant_detailsBLL");
        // GET: Salary/Salary_Data
        public ActionResult Index()
        {
            //生成订单编号
            ViewData["dt"] = slbll.GetId();
            return View();
        }

      
        // GET: Salary/Salary_Data/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Salary/Salary_Data/Create
        [HttpPost]
        public ActionResult Create(salary_standard sl)
        {
            try
            {
                // TODO: Add insert logic here
                int num = slbll.salary_standardInsert(sl);
                if (num > 0)
                {
                    return RedirectToAction("Index", "Salary_Data");
                }
                else
                {
                    return View();
                }
            }
            catch
            {
                return View();
            }
        }

    

       

    
    }
}
