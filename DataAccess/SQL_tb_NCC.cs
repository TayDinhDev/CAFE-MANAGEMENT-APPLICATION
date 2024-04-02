using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using QuanLiQuanCafeNew.DataAccess;
using QuanLyCafe.Business.EntitiesClass;

namespace QuanLyCafe.DataAccess
{
    class SQL_tb_NCC
    {
        ConnectDB cn = new ConnectDB();
        public bool kiemtrancc(string mancc)
        {
            return cn.kiemtra("select count(*) from [tb_NhaCungCap] where MaNCC=N'" + mancc + "'");
        }
        public void themmoincc(EC_tb_NCC ncc)
        {
            cn.ExcuteNonQuery(@"INSERT INTO tb_NhaCungCap
                      (MANCC, TenNCC, DiaChi, SDT) VALUES   (N'" + ncc.MANCC + "',N'" + ncc.TENNCC + "',N'" + ncc.DIACHI + "',N'" + ncc.DIENTHOAI + "')");
        }
        public void xoancc(EC_tb_NCC ncc)
        {
            cn.ExcuteNonQuery("DELETE FROM [tb_NhaCungCap] WHERE MaNCC=N'" + ncc.MANCC + "'");
        }

        public void suancc(EC_tb_NCC ncc)
        {
            string sql = (@"UPDATE    tb_NhaCungCap
            SET TenNCC =N'" + ncc.TENNCC + "', DiaChi =N'" + ncc.DIACHI + "', SDT =N'" + ncc.DIENTHOAI + "' where MaNCC=N'" + ncc.MANCC + "'");
            cn.ExcuteNonQuery(sql);
        }
    }
}
