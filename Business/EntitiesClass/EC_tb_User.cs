using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLiQuanCafeNew.Business.EntitiesClass
{
    internal class EC_tb_User
    {
        private string username;
        private string password;
        public string UserName
        {
            get 
            { 
                return username; 
            }
            set 
            { 
                username = value;
                if (username == "")
                {
                    throw new Exception("Tên Đăng Nhập Không Được Để Trống !");
                }
            }
        }
        public string Password
        {
            get
            {
                return password;
            }
            set
            {
                password = value;
                if (password == "")
                {
                    throw new Exception("Mật khẩu không được để trống!");
                }
            }
        }
    }
}
