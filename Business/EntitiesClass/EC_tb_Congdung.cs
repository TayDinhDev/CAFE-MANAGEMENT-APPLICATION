using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLiQuanCafeNew.Business.EntitiesClass
{
    internal class EC_tb_Congdung
    {
        private string MaCD;
        private string TenCD;

        public string MACONGDUNG
        {
            get
            {
                return MaCD;
            }
            set
            {
                MaCD = value;
                if (MaCD == "")
                {
                    throw new Exception("Mã không để trống");
                }
            }
        }
        public string TENCONGDUNG
        {
            get
            {
                return TenCD;
            }
            set
            {
                TenCD = value;
            }
        }
    }
}
