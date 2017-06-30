using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HotelManagerCommon;
using HotelManagerModel;
using System.Data.SqlClient;
using System.Data;

namespace HotelManagerDAL
{
    /// <summary>
    /// 客户入住访问层
    /// </summary>
    public class GuestRecordService
    {

        /// <summary>
        /// 添加
        /// </summary>
        /// <param name="g"></param>
        /// <returns></returns>
        public static int InsertGuestRecord(GuestRecord g) {
            string sql = SqlHelper.Dbowner + ".usp_insertGuestRecord";
            SqlParameter[] pars = new SqlParameter[]{
                new SqlParameter("@identityID",SqlDbType.VarChar),
                new SqlParameter("@guestName",SqlDbType.VarChar),
                new SqlParameter("@roomID",SqlDbType.Int),
                new SqlParameter("@deposit",SqlDbType.Decimal),
                new SqlParameter("@ResideDate",SqlDbType.DateTime),
            };

            pars[0].Value = g.IdentityID;
            pars[1].Value = g.GuestName;
            pars[2].Value = g.RoomID;
            pars[3].Value = g.Deposit;
            pars[4].Value = g.ResideDate;
            return SqlHelper.ExecuteNonQuery(CommandType.StoredProcedure,sql,pars);
        }
    }
}
