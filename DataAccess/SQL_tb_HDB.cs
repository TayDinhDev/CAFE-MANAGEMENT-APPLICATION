using QuanLiQuanCafeNew.Business.EntitiesClass;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLiQuanCafeNew.DataAccess
{
    internal class SQL_tb_HDB
    {
        ConnectDB cn = new ConnectDB();
        public bool kiemtraHDB(string mahdb)
        {
            return cn.kiemtra("select count(*) from [tb_HDB] where MaHDB=N'" + mahdb + "'");
        }
        public void themmoiHDB(EC_tb_HDB hdb)
        {
            cn.ExcuteNonQuery(@"INSERT INTO tb_HDB
                      (MaHDB,NgayBan, MaNV, MaKH, TongTien) VALUES   (N'" + hdb.MAHDB + "',N'" + hdb.NGAYBAN + "',N'" + hdb.MANV + "',N'" + hdb.MAKH + "',N'" + hdb.TONGTIEN + "')");
        }
        public void xoaHDB(EC_tb_HDB hdb)
        {
            cn.ExcuteNonQuery("DELETE FROM [tb_HDB] WHERE [MaHDB] = N'" + hdb.MAHDB + "'");
        }

        public void suaHDB(EC_tb_HDB hdb)
        {
            string sql = (@"UPDATE tb_HDB
            SET MaNV =N'" + hdb.MANV + "',NgayBan =N'" + hdb.NGAYBAN + "',MaKH =N'" + hdb.MAKH + "' where  MaHDB =N'" + hdb.MAHDB + "'");
            cn.ExcuteNonQuery(sql);
        }
        //load nhân viên
        public void loadmanv(ComboBox manv)
        {
            cn.LoadLenCombobox(manv, "SELECT     MaNV FROM tb_NhanVien", 0);
        }
        public string Loadtennv(string tennv, string manv)
        {
            tennv = cn.LoadLable("SELECT [TenNV] From [tb_NhanVien] where MaNV= N'" + manv + "'");
            return tennv;
        }
        //load mã khách hàng
        public void loadmakhach(ComboBox mak)
        {
            cn.LoadLenCombobox(mak, "SELECT     MaKH FROM tb_KhachHang", 0);
        }
        public string Loadtenkhach(string tenk, string mak)
        {
            tenk = cn.LoadLable("SELECT [TenKH] From [tb_KhachHang] where MaKH= N'" + mak + "'");
            return tenk;
        }
    }
}
