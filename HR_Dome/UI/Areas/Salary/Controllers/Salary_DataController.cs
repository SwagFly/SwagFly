using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace UI.Areas.Salary.Controllers
{
    public class Salary_DataController : Controller
    {
        // GET: Salary/Salary_Data
        public ActionResult Index()
        {
            return View();
        }

        // GET: Salary/Salary_Data/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Salary/Salary_Data/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Salary/Salary_Data/Create
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

        // GET: Salary/Salary_Data/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Salary/Salary_Data/Edit/5
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

        // GET: Salary/Salary_Data/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Salary/Salary_Data/Delete/5
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
