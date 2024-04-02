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
    internal class E_tb_Que
    {
        SQL_tb_Que lgsql = new SQL_tb_Que();
        public void ThemMoilg(EC_tb_Que lg)
        {
            if (!lgsql.Equals(lg.MAQUE))
            {
                MessageBox.Show("Có thể thêm");
                lgsql.ThemMoi(lg);
            }
            else
            {
                MessageBox.Show("Mã này đã tồn tại, xin chọn Mã khác", "Chú Ý", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        public void Sualg(EC_tb_Que lg)
        {
            lgsql.Sua(lg);
        }

        public void Xoalg(EC_tb_Que lg)
        {
            lgsql.Xoa(lg);
        }
    }
}
