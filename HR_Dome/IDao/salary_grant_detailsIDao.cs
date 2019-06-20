using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models;
namespace IDao
{
    /// <summary>
    /// 薪酬发放详细IDao
    /// </summary>
    public interface salary_grant_detailsIDao
    {
        //薪酬发放详细信息表新增
        int salary_grant_detailsInsert(salary_grant_details sd);
    }
}
