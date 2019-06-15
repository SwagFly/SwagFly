using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models;
using IDao;

namespace Dao
{
    public class UserDao : DaoBase<users>, UsersIDao
    {
        public void text()
        {

        }
    }
}