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
    internal class E_tb_Loai
    {
        SQL_tb_Loai lgsql = new SQL_tb_Loai();
        public void ThemMoilg(EC_tb_Loai lg)
        {
            if (!lgsql.Equals(lg.MALOAI))
            {
                lgsql.ThemMoi(lg);
            }
            else
            {
                MessageBox.Show("Mã này đã tồn tại,xin chọn Mã khác", "Chú Ý", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        public void Sualg(EC_tb_Loai lg)
        {
            lgsql.Sua(lg);
        }
        public void Xoalg(EC_tb_Loai lg)
        {
            lgsql.Xoa(lg);
        }
    }
}
