using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using QuanLiQuanCafeNew.Business.EntitiesClass;

namespace QuanLiQuanCafeNew.DataAccess
{
    internal class SQL_tb_User
    {
        ConnectDB cn = new ConnectDB();

        public bool Kiemtrauser(EC_tb_User user)
        {
            string sql = "select count(*) from tb_User where Username ='" + user.UserName + "' and Password = '" + user.Password + "'";
            return cn.KiemtraUsername(sql);
        }
    }
}
