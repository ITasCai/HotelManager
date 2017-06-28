using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelManagerCommon
{
   public static class Check
    {
        //判断是否为数字
        public static bool IsNumber(string number) {
            try
            {
                number = number.Replace(".","");
                for (int i = 0; i < number.Length; i++)
                {
                    if (!char.IsNumber(number,i))
                    {
                        return false;
                    }
                 
                }
                return true;
            }
            catch
            {
                return false;
             
            }
        }
    }
}
