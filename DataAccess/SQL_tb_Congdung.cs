using QuanLiQuanCafeNew.Business.EntitiesClass;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLiQuanCafeNew.DataAccess
{
    internal class SQL_tb_Congdung
    {
        ConnectDB cn = new ConnectDB();
        public bool KiemTra(string macongdung)
        {
            return cn.kiemtra("select count(*) from [tb_CongDung] where MaCD=N'" + macongdung + "'");
        }
        public void ThemMoi(EC_tb_Congdung q)
        {
            cn.ExcuteNonQuery(@"INSERT INTO tb_CongDung
                      (MaCD, TenCD) VALUES   (N'" + q.MACONGDUNG + "',N'" + q.TENCONGDUNG + "')");
        }
        public void Xoa(EC_tb_Congdung q)
        {
            cn.ExcuteNonQuery("DELETE FROM [tb_CongDung] WHERE [MaCD] = N'" + q.MACONGDUNG + "'");
        }

        public void Sua(EC_tb_Congdung q)
        {
            string sql = (@"UPDATE tb_CongDung
            SET TenCD =N'" + q.TENCONGDUNG + "' where  MaCD =N'" + q.MACONGDUNG + "'");
            cn.ExcuteNonQuery(sql);
        }
    }
}
