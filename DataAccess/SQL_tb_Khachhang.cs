using QuanLiQuanCafeNew.Business.EntitiesClass;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLiQuanCafeNew.DataAccess
{
    internal class SQL_tb_Khachhang
    {
        ConnectDB cn = new ConnectDB();
        public bool KiemTra(string tenkh)
        {
            return cn.kiemtra("select count(*) from [tb_KhachHang] where TenKH=N'" + tenkh + "'");
        }
        public void ThemMoi(EC_tb_Khachhang q)
        {
            cn.ExcuteNonQuery(@"INSERT INTO tb_KhachHang
                      (MaKH, TenKH) VALUES   (N'" + q.MAKH + "',N'" + q.TENKH + "')");
        }
        public void Xoa(EC_tb_Khachhang q)
        {
            cn.ExcuteNonQuery("DELETE FROM [tb_Khachhang] WHERE [MaKH] = N'" + q.MAKH + "'");
        }

        public void Sua(EC_tb_Khachhang q)
        {
            string sql = (@"UPDATE tb_KhachHang
            SET TenKH =N'" + q.TENKH + "' where  MaKH =N'" + q.MAKH + "'");
            cn.ExcuteNonQuery(sql);
        }
    }
}
