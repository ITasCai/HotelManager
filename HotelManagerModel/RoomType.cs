using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelManagerModel
{
    /// <summary>
    /// 房间类型实体类
    /// </summary>
   public class RoomType
    {
        //房间类型id
        public int TypeID { get; set; }
        //犯贱类型名称
        public string TypeName { get; set; }
        //房间类型f价格
        public decimal TypePrice { get; set; }
    }
}
