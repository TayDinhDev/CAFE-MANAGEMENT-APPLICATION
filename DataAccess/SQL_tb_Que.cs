using QuanLiQuanCafeNew.Business.EntitiesClass;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLiQuanCafeNew.DataAccess
{
    internal class SQL_tb_Que
    {
        ConnectDB cn = new ConnectDB();
        public bool Kiemtra(string MaQue)
        {
            Console.WriteLine(  "ĐANG KTRA");
            Console.WriteLine(MaQue);
            return cn.kiemtra("select count(*) from [tb_Que] where TenQue=N'"+MaQue+"'");
        }
        public void ThemMoi(EC_tb_Que q)
        {
            cn.ExcuteNonQuery(@"INSERT INTO tb_Que (MaQue, TenQue) VALUES   (N'" + q.MAQUE + "',N'" + q.TENQUE + "')");
        }
        public void Xoa(EC_tb_Que q)
        {
            cn.ExcuteNonQuery("DELETE FROM [tb_que] WHERE [MaQue] = N'" + q.MAQUE + "'");
        }

        public void Sua(EC_tb_Que q)
        {
            string sql = (@"UPDATE [tb_Que]
            SET TenQue =N'" + q.TENQUE + "' where  MaQue =N'" + q.MAQUE + "'");
            cn.ExcuteNonQuery(sql);
        }
    }
}
