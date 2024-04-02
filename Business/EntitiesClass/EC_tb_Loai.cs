using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLiQuanCafeNew.Business.EntitiesClass
{
    internal class EC_tb_Loai
    {
        private string MaLoai;
        private string TenLoai;

        public string MALOAI
        {
            get
            {
                return MaLoai;
            }
            set
            {
                MaLoai = value;
                if (MaLoai == "")
                {
                    throw new Exception("Mã không để trống");
                }
            }
        }
        public string TENLOAI
        {
            get
            {
                return TenLoai;
            }
            set
            {
                TenLoai = value;
            }
        }
    }
}
