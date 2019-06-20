using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models;
using IDao;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Linq.Expressions;

namespace Dao
{
    /// <summary>
    /// 薪酬基本信息IDao
    /// </summary>
    public class salary_standardDao:DaoBase<salary_standard_details>, salary_standardIDao
    {
        HR_DBEntities hr = new HR_DBEntities();
        /// <summary>
        /// 执行存储过程
        /// </summary>
        /// <param name="sql">存储过程的名字</param>
        /// <param name="frmName"></param>
        /// <param name="sp"></param>
        /// <returns></returns>
        //存储过程
        public static DataTable SelectProc(SqlParameter[] ps, string fileName)
        {
            string str = @"Data Source=DESKTOP-UQF2PKO\MSSQLSERVER2012;Initial Catalog=HR_DB;Integrated Security=True";
            SqlConnection cn = new SqlConnection(str);
            string sql = "procDanHao";
            SqlDataAdapter ad = new SqlDataAdapter(sql, cn);
            //执行的是存储过程
            ad.SelectCommand.CommandType = CommandType.StoredProcedure;
            //命令对象添加参数对象
            ad.SelectCommand.Parameters.AddRange(ps);
            DataTable dt = new DataTable();
            try
            {
                ad.Fill(dt);
            }
            catch (Exception ex)
            {
                using (StreamWriter sw = new StreamWriter("错误日志.txt", true))
                {
                    sw.WriteLine("错误信息：" + ex.Message);
                    sw.WriteLine("错误时间:" + DateTime.Now);
                    sw.WriteLine("报错窗体名:" + fileName);
                    sw.WriteLine("----------------------------");
                }
            }
            return dt;
        }
        public string GetId()
        {
            //string sql = "[dbo].[procDanHao]";
            SqlParameter[] sp = {
                new SqlParameter(){ ParameterName="@danhao", SqlDbType= SqlDbType.VarChar, Direction= ParameterDirection.Output,Size=14}
            };
            DataTable dt = SelectProc(sp, "salary_standardDao");
            return sp[0].Value.ToString();
        }
        //薪酬新增
        public int salary_standardInsert(salary_standard sl)
        {
            hr.Entry<salary_standard>(sl).State = System.Data.Entity.EntityState.Added;
            return hr.SaveChanges();
        }
        //薪酬标准登记复核分页
        public List<salary_standard> PageData<K>(Expression<Func<salary_standard, K>> order, Expression<Func<salary_standard, bool>> where, PageModel page)
        {
            throw new NotImplementedException();
        }
    }
}
