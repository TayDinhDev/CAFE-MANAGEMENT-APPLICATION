using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using QuanLiQuanCafeNew.Business.EntitiesClass;
using QuanLiQuanCafeNew.DataAccess;
using System.Windows.Forms;

namespace QuanLiQuanCafeNew.Business.Component
{
    internal class E_tb_User
    {
        EC_tb_User ck = new EC_tb_User();
        SQL_tb_User sql = new SQL_tb_User();
        public bool kiemtrauser(string user, string pass)
        {
            ck.UserName = user;
            ck.Password = pass;
            return sql.Kiemtrauser(ck);
        }
    }
}
