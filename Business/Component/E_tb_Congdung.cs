using QuanLiQuanCafeNew.Business.EntitiesClass;
using QuanLiQuanCafeNew.DataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLiQuanCafeNew.Business.Component
{
    internal class E_tb_Congdung
    {
        SQL_tb_Congdung nvsql = new SQL_tb_Congdung();
        public void ThemMoinv(EC_tb_Congdung nv)
        {
            if (!nvsql.Equals(nv.MACONGDUNG))
            {
                nvsql.ThemMoi(nv);
            }
            else
            {
                MessageBox.Show("Mã này đã tồn tại,xin chọn Mã khác", "Chú Ý", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        public void Suanv(EC_tb_Congdung nv)
        {
            nvsql.Sua(nv);
        }
        public void Xoanv(EC_tb_Congdung nv)
        {
            nvsql.Xoa(nv);
        }
    }
}
