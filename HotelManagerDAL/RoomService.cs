using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using HotelManagerModel;
using HotelManagerCommon;

namespace HotelManagerDAL
{
    /// <summary>
    /// 房间数据访问层
    /// </summary>
   public class RoomService
    {
        ///根据房间id,房间类型，查询所有查询信息

        public static IList<Room> GetRoomListByID(string roomID,string roomTypeID) {
            List<Room> list = new List<Room>();
            //连接字符串
            string sql = @"SELECT a.RoomID,a.BedNum,a.Description,a.GuestNum,a.RoomTypeID,b.TypeName,c.RoomStateName,c.RoomStateID FROM dbo.Room a
              INNER JOIN dbo.RoomType b
              ON a.RoomTypeID=b.TypeID INNER JOIN dbo.RoomState c
              ON a.RoomStateID=c.RoomStateID where 1=1";

            if (!string.IsNullOrEmpty(roomID))
            {
                sql += " and RoomID="+roomID;
            }

            if (!string.IsNullOrEmpty(roomTypeID))
            {
                sql += " and RoomTypeID=" + roomTypeID;
            }

            SqlDataReader dr = SqlHelper.GetDateReader(CommandType.Text,sql,null);

            while (dr.Read())
            {
                Room rm = new Room();
                rm.RoomID = Int32.Parse ( dr["RoomID"].ToString());
                rm.BedNum = Int32.Parse(dr["BedNum"].ToString());
                rm.Description = dr["Description"].ToString();
                rm.GuestNum = Int32.Parse(dr["GuestNum"].ToString());
                rm.RoomTypeID = Int32.Parse(dr["RoomTypeID"].ToString());
                rm.TypeName = dr["TypeName"].ToString();
                rm.RoomStateName = dr["RoomStateName"].ToString();
                rm.RoomStateID = Int32.Parse(dr["RoomStateID"].ToString());

                list.Add(rm);
            }
            return list;
        }

        ///房间添加
        public static int InserRoom(Room rm) {
            string sql = SqlHelper.Dbowner + ".usp_insertRoom";

            SqlParameter[] pars = {
                new SqlParameter("bedNum",SqlDbType.Int),
                new SqlParameter("description",SqlDbType.VarChar),
                new SqlParameter("roomTypeID",SqlDbType.Int)
            };

            pars[0].Value = rm.BedNum;
            pars[1].Value = rm.Description;
            pars[2].Value = rm.RoomTypeID;
            return SqlHelper.ExecuteNonQuery(CommandType.StoredProcedure,sql, pars);
        }

        ///房间修改

        public static int UpdateRoom(Room rm)
        {
            string sql = SqlHelper.Dbowner + ".usp_updateRoom";

            SqlParameter[] pars = {
                new SqlParameter("roomID",SqlDbType.Int),
                new SqlParameter("bedNum",SqlDbType.Int),
                new SqlParameter("description",SqlDbType.VarChar),
                new SqlParameter("roomTypeID",SqlDbType.Int)
            };
            pars[0].Value = rm.RoomID;
            pars[1].Value = rm.BedNum;
            pars[2].Value = rm.Description;
            pars[3].Value = rm.RoomTypeID;
            return SqlHelper.ExecuteNonQuery(CommandType.StoredProcedure, sql, pars);
        }

        ///删除

        public static int DeleteRoom(int roomID)
        {
            string sql = "delete from Room where RoomID=@roomID";
            SqlParameter pars = new SqlParameter("@roomID",roomID);
            return SqlHelper.ExecuteNonQuery(CommandType.Text,sql,pars);
        }

        //读取房间空闲列表
        public static IList<Room> GetLeiureList()
        {
            List<Room> list = new List<Room>();


            string sql = @" SELECT RoomID, CONVERT( VARCHAR(10),RoomID)+'号房(床位'+CONVERT( VARCHAR(2), BedNum-                GuestNum)+')'AS  Description  FROM dbo.Room
                               WHERE BedNum>GuestNum";
            SqlDataReader ds = SqlHelper.GetDateReader(CommandType.Text,sql,null);

            while (ds.Read())
            {
                Room room = new Room();
                room.RoomID = Convert.ToInt32(ds["RoomID"]);
                room.Description = ds["Description"].ToString();
                list.Add(room);
            }
            return list;
        }



        }
}
