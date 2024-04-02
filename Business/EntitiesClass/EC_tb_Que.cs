using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLiQuanCafeNew.Business.EntitiesClass
{
    internal class EC_tb_Que
    {
        public string MaQue;
        public string TenQue;
        public string MAQUE
        {
            get { return MaQue; } 
            set
            {
                MaQue = value;
                if(MaQue == "")
                {
                    throw new Exception("Mã không được để trống");
                }
            }
        }
        public string TENQUE
        {
            get { return TenQue; }
            set
            {
                TenQue = value;
            }
        }
    }
}
