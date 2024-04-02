using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLiQuanCafeNew.Business.EntitiesClass
{
    internal class EC_tb_Khachhang
    {
        private string MaKH;
        private string TenKH;

        public string MAKH
        {
            get
            {
                return MaKH;
            }
            set
            {
                MaKH = value;
                if (MaKH == "")
                {
                    throw new Exception("Mã không để trống");
                }
            }
        }
        public string TENKH
        {
            get
            {
                return TenKH;
            }
            set
            {
                TenKH = value;
            }
        }
    }
}
