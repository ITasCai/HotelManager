using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using HotelManagerCommon;
using System.Data;

namespace HotelManagerDAL
{
    /// <summary>
    /// 管理员的登录数据访问
    /// </summary>
    public class AdminService
    {
        public static bool AdminLogtin(string loginid,string logpwd) {
            string sql = string.Format(" SELECT * FROM dbo.Admin WHERE LoginId =@LoginId AND LoginPwd = @LoginPwd");

            SqlParameter[] parm = new SqlParameter[] {
                new SqlParameter("@LoginId",loginid),
                new SqlParameter("@LoginPwd",logpwd)
            };
            try
            {
                SqlDataReader dr = SqlHelper.GetDateReader(CommandType.Text, sql,parm);
                //如果检索到则返回TRUE，否则返回FALSE
                if (dr.Read())
                {
                    return true;
                }
                else
                {
                    return false;
                }

            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
    }
}
