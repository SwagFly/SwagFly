using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace IBll
{
    public interface UsersIBll
    {
        /// <summary>
        /// 查询登录信息
        /// </summary>
        /// <param name="user">包含账户/密码的实体类</param>
        /// <returns>单个信息</returns>
        users Login(users user);
        //分页查询
        List<users> PageData<K>(Expression<Func<users, K>> order, Expression<Func<users, bool>> where, PageModel page);
    }
}
