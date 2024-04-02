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
    internal class E_tb_Khachhang
    {
        SQL_tb_Khachhang khsql = new SQL_tb_Khachhang();
        public void ThemMoiKH(EC_tb_Khachhang kh)
        {
            if (!khsql.Equals(kh.MAKH))
            {
                khsql.ThemMoi(kh);
            }
            else
            {
                MessageBox.Show("Mã này đã tồn tại,xin chọn Mã khác", "Chú Ý", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        public void SuaKH(EC_tb_Khachhang kh)
        {
            khsql.Sua(kh);
        }
        public void XoaKH(EC_tb_Khachhang kh)
        {
            khsql.Xoa(kh);
        }
    }
}
