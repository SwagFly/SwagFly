using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models;
using IDao;

namespace Dao
{
    /// <summary>
    /// 薪酬发放详细IDao
    /// </summary>
    public class salary_grant_detailsDao : DaoBase<salary_grant_details>, salary_grant_detailsIDao
    {
        HR_DBEntities hr = new HR_DBEntities();
        //薪酬发放单详细信息表新增
        public int salary_grant_detailsInsert(salary_grant_details sg)
        {
            hr.Entry<salary_grant_details>(sg).State = System.Data.Entity.EntityState.Added;
            return hr.SaveChanges();
        }
    }
}
