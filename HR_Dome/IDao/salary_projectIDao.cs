using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models;
namespace IDao
{
    /// <summary>
    /// 薪酬报销分类IDao
    /// </summary>
    public interface salary_projectIDao
    {
        //查询
        List<salary_project> selectsalary_project();
    }
}
