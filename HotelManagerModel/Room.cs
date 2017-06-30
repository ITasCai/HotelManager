using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelManagerModel
{
    /// <summary>
    /// 房间实体类
    /// </summary>
   public class Room
    {
        //房间编号
        public int RoomID { set; get; }

       
        public int BedNum { set; get; }

        public string Description { set; get; }

        public int RoomStateID { set; get; }

        /// <summary>
        ///房间客房数
        /// </summary>
        public int GuestNum { set; get; }
        /// <summary>
        /// 房间类型编号
        /// </summary>
        public int RoomTypeID { set; get; }
        /// <summary>
        /// 房间类型名称
        /// </summary>
        public string TypeName { set; get; }
        /// <summary>
        /// 房间状态名称
        /// </summary>
        public string RoomStateName { set; get; }






    }
}
