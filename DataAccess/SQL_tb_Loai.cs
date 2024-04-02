using QuanLiQuanCafeNew.Business.EntitiesClass;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLiQuanCafeNew.DataAccess
{
    internal class SQL_tb_Loai
    {
        ConnectDB cn = new ConnectDB();
        public bool KiemTra(string maloai)
        {
            return cn.kiemtra("select count(*) from [tb_Loai] where MaLoai=N'" + maloai + "'");
        }
        public void ThemMoi(EC_tb_Loai q)
        {
            cn.ExcuteNonQuery(@"INSERT INTO tb_Loai
                      (MaLoai, TenLoai) VALUES   (N'" + q.MALOAI + "',N'" + q.TENLOAI + "')");
        }
        public void Xoa(EC_tb_Loai q)
        {
            cn.ExcuteNonQuery("DELETE FROM [tb_Loai] WHERE [MaLoai] = N'" + q.MALOAI + "'");
        }

        public void Sua(EC_tb_Loai q)
        {
            string sql = (@"UPDATE tb_Loai
            SET TenLoai =N'" + q.TENLOAI + "' where  MaLoai =N'" + q.MALOAI + "'");
            cn.ExcuteNonQuery(sql);
        }
    }
}
