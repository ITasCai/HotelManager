using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using HotelManagerCommon;
using HotelManagerModel;


namespace HotelManagerDAL
{
    /// <summary>
    /// 房间类型数据访问
    /// </summary>
    public class RoomTypeService
    {
        /// <summary>
        /// 查询所有类型的房间
        /// </summary>
        /// <returns></returns>
        public static DataSet GetAllRoomTypeList() {
            //定义查询的sql语句
            string sql = "SELECT*FROM dbo.RoomType";
            //返回结果集
            return SqlHelper.ExecuteDataSet(CommandType.Text,sql,null);
            
        }

        //根据房间类型模糊查询
        public static DataTable GetRoomTypeListByName(string type) {
            //定义查询的sql语句
            string sql = string.Format("SELECT*FROM dbo.RoomType WHERE TypeName LIKE '%{0}%'",type);
            //返回结果
            return SqlHelper.ExecuteDataTable(CommandType.Text,sql,null);
        }

        //根据房间类型id获取房间类型名称
        public static DataTable GetRoomTypeListByID(int typeID) {
            //定义查询的sql语句
            string sql = string.Format("SELECT TypeName FROM dbo.RoomType WHERE TypeID={0}", typeID);
            //返回结果
            return SqlHelper.ExecuteDataTable(CommandType.Text, sql, null);
        }

        //添加一个房间类型
        public static int AddRoomType(RoomType roomType) {

            string sql = SqlHelper.Dbowner + ".usp_insertRoomType";
            SqlParameter[] paras = {
                new SqlParameter("TypeName",SqlDbType.VarChar),
                 new SqlParameter("TypePrice",SqlDbType.Decimal)
            };
            paras[0].Value = roomType.TypeName;
            paras[1].Value = roomType.TypePrice;
            return SqlHelper.ExecuteNonQuery(CommandType.StoredProcedure,sql,paras);
        }


        //修改一个房间类型
        public static int UpdateRoomType(RoomType roomType)
        {

            string sql = SqlHelper.Dbowner + ".usp_updateRoomType";
            SqlParameter[] paras = {
                 new SqlParameter("TypeID",SqlDbType.Int),
                 new SqlParameter("TypeName",SqlDbType.VarChar),
                 new SqlParameter("TypePrice",SqlDbType.Decimal)
            };
            paras[0].Value = roomType.TypeID;
            paras[1].Value = roomType.TypeName;
            paras[2].Value = roomType.TypePrice;
            return SqlHelper.ExecuteNonQuery(CommandType.StoredProcedure, sql, paras);
        }

        //删除一个房间类型

        public static int DeleteRoomType(int roomTypeID)
        {

            string sql = "DELETE FROM dbo.RoomType WHERE TypeID=@roomTypeID";
            SqlParameter parm = new SqlParameter("@roomTypeID", roomTypeID);
      
            return SqlHelper.ExecuteNonQuery(CommandType.Text, sql, parm);
        }
    }
}
