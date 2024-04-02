using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using QuanLiQuanCafeNew.Business.EntitiesClass;
using QuanLiQuanCafeNew.DataAccess;
using System.Windows.Forms;

namespace QuanLiQuanCafeNew.Business.Component
{
    internal class E_tb_Nhanvien
    {
        SQL_tb_NhanVien nvsql = new SQL_tb_NhanVien();
        public void ThemMoiNV(EC_tb_Nhanvien nv)
        {
            if (!nvsql.Equals(nv.MANV))
            {
                nvsql.ThemMoiNV(nv);
            }
            else
            {
                MessageBox.Show("Mã này đã tồn tại,xin chọn Mã khác", "Chú Ý", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        public void SuaNV(EC_tb_Nhanvien nv)
        {
            nvsql.SuaNV(nv);
        }
        public void XoaNV(EC_tb_Nhanvien nv)
        {
            nvsql.XoaNV(nv);
        }
        //load quê
        public void LoadMaQue(ComboBox cbq)
        {
            nvsql.LoadMaQue(cbq);
        }
        public string LoadTenQue(string Tenq, string Maq)
        {
            Tenq = nvsql.LoadTenQue(Tenq, Maq);
            return Tenq;
        }
    }
}
