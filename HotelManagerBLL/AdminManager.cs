using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HotelManagerDAL;

namespace HotelManagerBLL
{
    /// <summary>
    /// 管理员登录管理类
    /// </summary>
    public class AdminManager
    {
        public static bool AdminLogtin(string loginid, string logpwd)
        {
            //调用数据访问层的执行管理员登录查询的sql语句
            return AdminService.AdminLogtin(loginid, logpwd);
        }
     }
}
