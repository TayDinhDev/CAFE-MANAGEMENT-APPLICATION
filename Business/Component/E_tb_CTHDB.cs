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
    internal class E_tb_CTHDB
    {
        SQL_tb_CTHDB cthdbsql = new SQL_tb_CTHDB();
        public void themoicthdb(EC_tb_CTHDB cthdb)
        {
            MessageBox.Show("Tao đây1");

            if (!cthdbsql.kiemtratb_CTHBD(cthdb.MAHDB, cthdb.MASP))
            {
                MessageBox.Show("Tao đây2");
                cthdbsql.themmoicthdb(cthdb);
                MessageBox.Show("Tao đây3");

            }
            else
            {
                MessageBox.Show("Mã này đã tồn tại,xin chọn Mã khác", "Chú Ý", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        public void suacthdb(EC_tb_CTHDB cthdb)
        {
            cthdbsql.suacthdb(cthdb);
        }
        public void xoacthdb(EC_tb_CTHDB cthdb)
        {
            cthdbsql.xoacthdb(cthdb);
        }
        //load hóa đơn
        public void loadmahd(ComboBox cbhd)
        {
            cthdbsql.loadmahd(cbhd);
        }
        //load hóa đơn
        public void loadmasp(ComboBox cbsp)
        {
            cthdbsql.loadmasp(cbsp);
        }
        public string loadtensp(string TenSP, string MaSP)
        {
            TenSP = cthdbsql.Loadtenhang(TenSP, MaSP);
            return TenSP;
        }

        public string loaddg(string dg, string Masp)
        {
            dg = cthdbsql.Loaddgb(dg, Masp);
            return dg;
        }
    }
}
