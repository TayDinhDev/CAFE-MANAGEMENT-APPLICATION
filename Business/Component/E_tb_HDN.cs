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
    internal class E_tb_HDN
    {
        SQL_tb_HDN hdnsql = new SQL_tb_HDN();
        public void themoihdn(EC_tb_HDN hdn)
        {
            if (!hdnsql.Equals(hdn.MAHDN))
            {
                hdnsql.themmoiHDN(hdn);
            }
            else
            {
                MessageBox.Show("Mã này đã tồn tại,xin chọn Mã khác", "Chú Ý", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        public void suahdn(EC_tb_HDN hdn)
        {
            hdnsql.suaHDN(hdn);
        }
        public void xoahdn(EC_tb_HDN hdn)
        {
            hdnsql.xoaHDN(hdn);
        }
        //load nv
        public void loadmanv(ComboBox cbnv)
        {
            hdnsql.loadmanv(cbnv);
        }
        public string loadtenl(string Tennv, string Manv)
        {
            Tennv = hdnsql.Loadtennv(Tennv, Manv);
            return Tennv;
        }
        //load khách
        public void loadmancc(ComboBox cbncc)
        {
            hdnsql.loadmancc(cbncc);
        }
        public string loadtenncc(string Tenncc, string Mancc)
        {
            Tenncc = hdnsql.Loadtenncc(Tenncc, Mancc);
            return Tenncc;
        }
    }
}
