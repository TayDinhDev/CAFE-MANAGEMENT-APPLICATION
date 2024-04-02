using QuanLiQuanCafeNew.Business.EntitiesClass;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLiQuanCafeNew.DataAccess
{
    internal class SQL_tb_CTHDB
    {
        ConnectDB cn = new ConnectDB();
        public bool kiemtratb_CTHBD(string mahdb, string masp)
        {
            cn.GetCon();
            return cn.kiemtra("select count(*) from [tb_CTHDB] where MaHDB=N'" + mahdb + "'and MaSP=N'" + masp + "'");
        }
        public void themmoicthdb(EC_tb_CTHDB cthdb)
        {
            cn.ExcuteNonQuery(@"INSERT INTO tb_CTHDB
                      (MaHDB, MaSP, TenSP, SoLuong, ThanhTien, KhuyenMai) VALUES   (N'" + cthdb.MAHDB + "',N'" + cthdb.MASP + "',N'" + cthdb.TENSP + "',N'" + cthdb.SOLUONG + "',N'" + cthdb.THANHTIEN + "',N'" + cthdb.KHUYENMAI + "')");
        }
        public void xoacthdb(EC_tb_CTHDB cthdb)
        {
            cn.ExcuteNonQuery("DELETE FROM [tb_CTHDB] WHERE  MaHDB=N'" + cthdb.MAHDB + "' and MaSP=N'" + cthdb.MASP + "' ");
        }

        public void suacthdb(EC_tb_CTHDB cthdb)
        {
            string sql = (@"UPDATE tb_CTHDB
            SET SoLuong =N'" + cthdb.SOLUONG + "', KhuyenMai = N'" + cthdb.KHUYENMAI + "', ThanhTien = N'" + cthdb.THANHTIEN + "' where  [MaHDB]=N'" + cthdb.MAHDB + "' and MaSP=N'" + cthdb.MASP + "'");
            cn.ExcuteNonQuery(sql);
        }
        //load sp
        public void loadmasp(ComboBox masp)
        {
            cn.LoadLenCombobox(masp, "SELECT     MaSP FROM tb_SanPham", 0);
        }
        public string Loadtenhang(string tenhang, string masp)
        {
            tenhang = cn.LoadLable("SELECT [TenSP] From [tb_SanPham] where MaSP= N'" + masp + "'");
            return tenhang;
        }
        //load THD
        public void loadmahd(ComboBox mahdb)
        {
            cn.LoadLenCombobox(mahdb, "SELECT MaHDB FROM tb_HDB", 0);
        }
        //load đơn giá bán
        public string Loaddgb(string dg, string masp)
        {
            dg = cn.LoadLable("SELECT [GiaBan] From [tb_SanPham] where MaSP= N'" + masp + "'");
            return dg;
        }
    }
}
