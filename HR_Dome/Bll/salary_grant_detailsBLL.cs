using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IBll;
using Models;
using Dao;
using IDao;
using IOC;
namespace Bll
{
    /// <summary>
    /// 薪酬发放详细
    /// </summary>
    public class salary_grant_detailsBLL: salary_grant_detailsIBLL
    {
        private static salary_grant_detailsIDao dao = IocType.GetIocType<salary_grant_detailsDao>("salary_grant_detailsDao", "salary_grant_detailsDao");
        //薪酬标准单详细信息表新增
        public int salary_grant_detailsInsert(salary_grant_details sd)
        {
            return dao.salary_grant_detailsInsert(sd);
        }
    }
}
