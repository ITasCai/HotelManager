using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using HotelManagerModel;
using HotelManagerDAL;

namespace HotelManagerBLL
{
    public class RoomTypeManager
    {
        /// <summary>
        /// 查询所有类型的房间
        /// </summary>
        /// <returns></returns>
        public static DataSet GetAllRoomTypeList()
        {
            return RoomTypeService.GetAllRoomTypeList();
        }

        //根据房间类型模糊查询
        public static DataTable GetRoomTypeListByName(string type)
        {
            return RoomTypeService.GetRoomTypeListByName(type);
        }


        //根据房间类型id获取房间类型名称
        public static DataTable GetRoomTypeListByID(int typeID)
        {
            return RoomTypeService.GetRoomTypeListByID(typeID);
        }

        //添加一个房间类型
        public static int AddRoomType(RoomType roomType)
        {
            return RoomTypeService.AddRoomType(roomType);
        }
        //修改一个房间类型
        public static int UpdateRoomType(RoomType roomType)
        {
            return RoomTypeService.UpdateRoomType(roomType);
        }

        //删除一个房间类型

        public static int DeleteRoomType(int roomTypeID)
        {
            return RoomTypeService.DeleteRoomType(roomTypeID);
        }

     }
}
