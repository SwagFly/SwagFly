using Bll;
using IBll;
using IOC;
using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Newtonsoft.Json;
using System.Transactions;//事务包
namespace UI.Areas.Salary.Controllers
{
    public class Salary_DataController : Controller
    {
        //薪酬发放登记表
        salary_standardIBLL slbll = IocType.GetIocType<salary_standardBLL>("salary_grantBLL", "salary_grantBLL");
        //薪酬报销分类
        salary_projectIBLL spbll = IocType.GetIocType<salary_projectBLL>("salary_projectBLL", "salary_projectBLL");
        //薪酬标准详细表
        salary_standard_detailsIBLL sdbll = IocType.GetIocType<salary_standard_detailsBLL>("salary_standard_detailsBLL", "salary_standard_detailsBLL");
        // GET: Salary/Salary_Data
        public ActionResult Index()
        {
            //生成订单编号
            ViewData["dt"] = slbll.GetId();
            //制定人名称
            users us =(users) Session["userClass"];
            ViewData["user"] = us.u_name;
            //查询薪酬报销分类
            List<salary_project> list = spbll.selectsalary_project();
            return View(list);
        }
        ////查询薪酬报销分类
        //public ActionResult salary_project()
        //{
        //    //List<salary_project> list = spbll.selectsalary_project();
        //    return View();/* Content(JsonConvert.SerializeObject(list));*/
        //}


        // GET: Salary/Salary_Data/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Salary/Salary_Data/Create
        [HttpPost]
        public ActionResult Create(salary_standard sl, salary_standard_details[] sd)
        {
            int num = 0;
            int j = 0;
            //事务提交
            using (TransactionScope ts = new TransactionScope())
            {
                    foreach (salary_standard_details item in sd)
                    {
                    if (item.salary>0)
                    {
                        j++;
                        item.standard_id = sl.standard_id;
                        item.standard_name = sl.standard_name;
                        num += sdbll.salary_standard_detailsInsert(item);
                    }
                }
                if (slbll.salary_standardInsert(sl)>0&&num==j)
                {
                    ts.Complete();
                    return RedirectToAction("Index", "Salary_Data");
                }
                else
                {
                    return View();
                }

            }
                
        }





        //薪酬标准登记复核
        // GET: Salary/Salary_Data/Create
        public ActionResult salarystandard_check_list()
        {

            return View();
        }
        //薪酬标准登记复核修改
        public ActionResult salarystandard_check()
        {
            return View();
        }
        //薪酬标准登记复核修改成功
        public ActionResult salarystandard_check_success()
        {
            return View();
        }



        //薪酬标准查询
        public ActionResult salarystandard_query_locate()
        {
            return View();
        }
        //薪酬标准登记查询
        public ActionResult salarystandard_query_list()
        {
            return View();
        }
        ////薪酬标准登记查询
        //public ActionResult salarystandard_query()
        //{
        //    return View();
        //}
    }
}
