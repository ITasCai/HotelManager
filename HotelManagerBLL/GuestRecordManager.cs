using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HotelManagerDAL;
using HotelManagerModel;

namespace HotelManagerBLL
{
   public class GuestRecordManager
    {

        /// <summary>
        /// 添加
        /// </summary>
        /// <param name="g"></param>
        /// <returns></returns>
        public static int InsertGuestRecord(GuestRecord g)
        {
            return GuestRecordService.InsertGuestRecord(g);
        }
        }
}
