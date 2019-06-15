using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dao
{
    /// <summary>
    /// EF数据模型通用Dao层操作
    /// </summary>
    /// <typeparam name="T">实体模型</typeparam>
    public class DaoBase<T> where T : class
    {
        //数据库名 models = CreateDBContent();
        ///// <summary>
        ///// 获取数据对象
        ///// </summary>
        ///// <returns>数据对象</returns>
        //public static 数据库名 CreateDBContent() {
        //    数据库名 modelSet = CallContext.GetData("modelClass");
        //    if (modelSet==null) {
        //        modelSet = new 数据库名();
        //        CallContext.SetData("modelClass",modelSet);
        //    }
        //    return modelSet;
        //}

    }
}
