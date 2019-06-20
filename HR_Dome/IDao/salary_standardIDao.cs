using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models;
namespace IDao
{
    /// <summary>
    /// 薪酬基本信息IDao
    /// </summary>
    public interface salary_standardIDao
    {
        //生成单号存储过程
        string GetId();
        //薪酬标准新增
        int salary_standardInsert(salary_standard sl);
    }
}
