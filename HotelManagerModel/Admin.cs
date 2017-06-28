using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelManagerModel
{
    /// <summary>
    /// 用户登录实体类
    /// </summary>
    public class Admin
    {
        //登录名
        public string LoginId { get; set; }
        //登录密码
        public string LoginPwd { get; set; }
    }
}
