using QuanLiQuanCafeNew.Business.EntitiesClass;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLiQuanCafeNew.DataAccess
{
    internal class SQL_tb_NhanVien
    {
        ConnectDB cn = new ConnectDB();
        public bool KiemTraNV(string MaNV)
        {
            return cn.kiemtra("select count(*) from [tb_NhanVien] where MaNV=N'" + MaNV + "'");
        }
        public void ThemMoiNV(EC_tb_Nhanvien nv)
        {
            cn.ExcuteNonQuery( @"INSERT INTO tb_NhanVien (MaNV, TenNV, DiaChi, GioiTinh, NgaySinh, MaQue, SDT) VALUES   (N'" + nv.MANV + "',N'" + nv.TENNV + "',N'" + nv.DIACHI + "',N'" + nv.GIOITINH + "',N'" + nv.NGAYSINH + "',N'" + nv.MAQUE + "',N'" + nv.SDThoai + "')");
            
        }
        public void XoaNV(EC_tb_Nhanvien nv)
        {
            cn.ExcuteNonQuery("DELETE FROM [tb_NhanVien] WHERE MaNV=N'" + nv.MANV + "'");
        }

        public void SuaNV(EC_tb_Nhanvien nv)
        {
            string sql = (@"UPDATE    tb_NhanVien
                    SET TenNV =N'" + nv.TENNV + "', GioiTinh =N'" + nv.GIOITINH + "', NgaySinh =N'" + nv.NGAYSINH + "', SDT =N'" + nv.SDThoai + "', DiaChi =N'" + nv.DIACHI + "',MaQue =N'" + nv.MAQUE + "'  where MaNV=N'" + nv.MANV + "'");
            cn.ExcuteNonQuery(sql);
        }
        //load quê
        public void LoadMaQue(ComboBox maq)
        {
            cn.LoadLenCombobox(maq, "SELECT     MaQue FROM tb_Que", 0);
        }
        public string LoadTenQue(string tenq, string maq)
        {
            tenq = cn.LoadLable("SELECT [TenQue] From [tb_Que] where MaQue= N'" + maq + "'");
            return tenq;
        }
    }
}
