using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models;
namespace IBll
{
    /// <summary>
    /// 薪酬发放详细
    /// </summary>
    public interface salary_grant_detailsIBLL
    {
        //薪酬标准单详细信息表新增
        int salary_grant_detailsInsert(salary_grant_details sd);
    }
}
