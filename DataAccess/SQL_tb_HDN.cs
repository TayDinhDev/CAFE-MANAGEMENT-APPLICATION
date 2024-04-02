using QuanLiQuanCafeNew.Business.EntitiesClass;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLiQuanCafeNew.DataAccess
{
    internal class SQL_tb_HDN
    {
        ConnectDB cn = new ConnectDB();
        public bool kiemtraHDN(string mahdn)
        {
            return cn.kiemtra("select count(*) from [tb_HDN] where MaHDN=N'" + mahdn + "'");
        }
        public void themmoiHDN(EC_tb_HDN hdn)
        {
            cn.ExcuteNonQuery(@"INSERT INTO tb_HDN
                      (MaHDN, NgayNhap, MaNV, MaNCC, TongTien) VALUES   (N'" + hdn.MAHDN + "',N'" + hdn.NGAYNHAP + "',N'" + hdn.MANV + "',N'" + hdn.MANCC + "',N'" + hdn.TONGTIEN + "')");
        }
        public void xoaHDN(EC_tb_HDN hdn)
        {
            cn.ExcuteNonQuery("DELETE FROM [tb_HDN] WHERE [MaHDN] = N'" + hdn.MAHDN + "'");
        }

        public void suaHDN(EC_tb_HDN hdn)
        {
            string sql = (@"UPDATE tb_HDN
            SET MaNV =N'" + hdn.MANV + "',NgayNhap =N'" + hdn.NGAYNHAP + "',MaNCC =N'" + hdn.MANCC + "' where  MaHDN =N'" + hdn.MAHDN + "'");
            cn.ExcuteNonQuery(sql);
        }
        //load nhân viên
        public void loadmanv(ComboBox manv)
        {
            cn.LoadLenCombobox(manv, "SELECT     manv FROM tb_NhanVien", 0);
        }
        public string Loadtennv(string tennv, string manv)
        {
            tennv = cn.LoadLable("SELECT [TenNV] From [tb_NhanVien] where MaNV= N'" + manv + "'");
            return tennv;
        }
        //load mã nhà cung cấp
        public void loadmancc(ComboBox macc)
        {
            cn.LoadLenCombobox(macc, "SELECT     MaNCC FROM tb_NhaCungCap", 0);
        }
        public string Loadtenncc(string tencc, string macc)
        {
            tencc = cn.LoadLable("SELECT [TenNCC] From [tb_NhaCungCap] where MaNCC= N'" + macc + "'");
            return tencc;
        }
    }
}
