using QuanLiQuanCafeNew.Business.EntitiesClass;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLiQuanCafeNew.DataAccess
{
    internal class SQL_tb_Sanpham
    {
        ConnectDB cn = new ConnectDB();
        public bool KiemTraHang(string mahang)
        {
            return cn.kiemtra("select count(*) from [tb_SanPham] where MaSP=N'" + mahang + "'");
        }
        public void ThemMoiHang(EC_tb_Sanpham hang)
        {
            SqlConnection con = cn.GetCon();
            try
            {
                

                string sql = @"INSERT INTO tb_SanPham  (MaSP, TenSP, MaLoai, GiaNhap, GiaBan, SoLuong, MaCD, HinhAnh) VALUES (N'" + hang.MASP + "',N'" + hang.TENSP + "',N'" + hang.MALOAI + "',N'" + hang.GIANHAP + "',N'" + hang.GIABAN + "',N'" + hang.SOLUONG + "',N'" + hang.MACONGDUNG + "',@HinhAnh)";
                SqlCommand cmd = new SqlCommand(sql, con);
                cmd.Parameters.Add(new SqlParameter("@HinhAnh", (object)hang.HINHANH));
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        public void XoaHang(EC_tb_Sanpham hang)
        {
            cn.ExcuteNonQuery("DELETE FROM [tb_SanPham] WHERE  MaSP=N'" + hang.MASP + "'");
        }

        public void SuaHang(EC_tb_Sanpham hang)
        {
            SqlConnection con = cn.GetCon();
            try
            {
                string sql = @"UPDATE    tb_SanPham
                SET  TenSP =N'" + hang.TENSP + "', MaLoai =N'" + hang.MALOAI + "', GiaBan =N'" + hang.GIABAN + "', SoLuong =N'" + hang.SOLUONG + "', MaCD =N'" + hang.MACONGDUNG + "',HinhAnh =@HinhAnh where MaSP=N'" + hang.MASP + "'";
                SqlCommand cmd = new SqlCommand(sql, con);
                cmd.Parameters.Add(new SqlParameter("@HinhAnh", (object)hang.HINHANH));
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        //load loại
        public void LoadMaLoai(ComboBox maloai)
        {
            cn.LoadLenCombobox(maloai, "SELECT     MaLoai FROM tb_Loai", 0);
        }
        public string LoadTenLoai(string tenloai, string maloai)
        {
            tenloai = cn.LoadLable("SELECT [TenLoai] From [tb_Loai] where MaLoai= N'" + maloai + "'");
            return tenloai;
        }
        //load công dụng
        public void LoadCD(ComboBox macd)
        {
            cn.LoadLenCombobox(macd, "SELECT     MaCD FROM tb_CongDung", 0);
        }
        public string LoadTenCD(string tenm, string mam)
        {
            tenm = cn.LoadLable("SELECT [TenCD] From [tb_CongDung] where MaCD= N'" + mam + "'");
            return tenm;
        }
    }
}
