using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HotelManagerDAL;
using HotelManagerModel;

namespace HotelManagerBLL
{
    public    class RoomManager
    {
        ///根据房间id,房间类型，查询所有查询信息

        public static IList<Room> GetRoomListByID(string roomID, string roomTypeID)
        {
            return RoomService.GetRoomListByID(roomID, roomTypeID);
         }

        ///房间添加
        public static int InserRoom(Room rm)
        {
            return RoomService.InserRoom(rm);
        }

        ///房间修改

        public static int UpdateRoom(Room rm) {
            return RoomService.UpdateRoom(rm);
        }

        ///删除

        public static int DeleteRoom(int roomID)
        {
            return RoomService.DeleteRoom(roomID);
        }


        //读取房间空闲列表
        public static IList<Room> GetLeiureList()
        {
            return RoomService.GetLeiureList();
        }
        }
}
