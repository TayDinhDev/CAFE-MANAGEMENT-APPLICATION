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
    internal class E_tb_Sanpham
    {
        SQL_tb_Sanpham spsql = new SQL_tb_Sanpham();
        public void ThemMoi(EC_tb_Sanpham lg)
        {
            if (!spsql.Equals(lg.MASP))
            {
                spsql.ThemMoiHang(lg);
            }
            else
            {
                MessageBox.Show("Mã này đã tồn tại,xin chọn Mã khác", "Chú Ý", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        public void Sua(EC_tb_Sanpham lg)
        {
            spsql.SuaHang(lg);
        }
        public void xoa(EC_tb_Sanpham lg)
        {
            spsql.XoaHang(lg);
        }
        //load công việc
        public void LoadML(ComboBox cbl)
        {
            spsql.LoadMaLoai(cbl);
        }
        public string loadtenl(string Tenl, string Mal)
        {
            Tenl = spsql.LoadTenLoai(Tenl, Mal);
            return Tenl;
        }
        //load loại
        public void LoadMaCD(ComboBox cbcd)
        {
            spsql.LoadCD(cbcd);
        }
        public string loadtencd(string Tencd, string Macd)
        {
            Tencd = spsql.LoadTenCD(Tencd, Macd);
            return Tencd;
        }
    }
}
