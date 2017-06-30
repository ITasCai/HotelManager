using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelManagerModel
{
    /// <summary>
    /// 客户入住实体类
    /// </summary>
    public class GuestRecord
    {
        //客房id
        public int GuestID { get; set; }
        //客房身份证号
        public string IdentityID { get; set; }
        //客户姓名
        public string GuestName { get; set; }
        //房间id
        public int RoomID { get; set; }
        
        //入住id
        public int ResideID { get; set; }
        //入住时间
        public DateTime ResideDate { get; set; }
        //结账时间
        public DateTime LeaveDate { get; set; }
        //押金
        public decimal Deposit { get; set; }
        //总金额
        public decimal TotalMoney { get; set; }
    }
}
