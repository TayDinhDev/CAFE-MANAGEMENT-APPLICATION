using QuanLiQuanCafeNew.Business.EntitiesClass;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLiQuanCafeNew.DataAccess
{
    internal class SQL_tb_CTHDN
    {
        ConnectDB cn = new ConnectDB();
        public bool kiemtratb_CTHDN(string mahdn, string masp)
        {
            return cn.kiemtra("select count(*) from [tb_CTHDN] where MaHDN=N'" + mahdn + "'and MaSP=N'" + masp + "'");
        }
        public void themmoicthdb(EC_tb_CTHDN cthdb)
        {
            cn.ExcuteNonQuery(@"INSERT INTO tb_CTHDN
                      (MaHDN, MaSP, SoLuong, DonGia, ThanhTien, KhuyenMai) VALUES   (N'" + cthdb.MAHDN + "',N'" + cthdb.MASP + "',N'" + cthdb.SOLUONG + "',N'" + cthdb.DONGIA + "',N'" + cthdb.THANHTIEN + "',N'" + cthdb.KHUYENMAI + "')");
        }
        public void xoacthdb(EC_tb_CTHDN cthdb)
        {
            cn.ExcuteNonQuery("DELETE FROM [tb_CTHDN] WHERE  MaHDN=N'" + cthdb.MAHDN + "' and MaSP=N'" + cthdb.MASP + "' ");
        }

        public void suacthdb(EC_tb_CTHDN cthdb)
        {
            string sql = (@"UPDATE tb_CTHDN
            SET SoLuong =N'" + cthdb.SOLUONG + "', KhuyenMai = N'" + cthdb.KHUYENMAI + "', ThanhTien = N'" + cthdb.THANHTIEN + "' where  MaHDB=N'" + cthdb.MAHDN + "' and MaSP=N'" + cthdb.MASP + "'");
            cn.ExcuteNonQuery(sql);
        }
        //load sp
        public void loadmasp(ComboBox masp)
        {
            cn.LoadLenCombobox(masp, "SELECT     MaSP FROM tb_SanPham", 0);
        }
        public string Loadtenhang(string tenhang, string masp)
        {
            tenhang = cn.LoadLable("SELECT [MaSP] From [tb_SanPham] where MaSP= N'" + masp + "'");
            return tenhang;
        }
        //load THD
        public void loadmahd(ComboBox mahdn)
        {
            cn.LoadLenCombobox(mahdn, "SELECT     MaHDN FROM tb_HDN", 0);
        }
        //load đơn giá bán
        public string Loaddgb(string dg, string masp)
        {
            dg = cn.LoadLable("SELECT [GiaNhap] From [tb_SanPham] where MaSP= N'" + masp + "'");
            return dg;
        }
    }
}
