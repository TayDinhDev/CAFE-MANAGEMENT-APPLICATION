using QuanLiQuanCafeNew.DataAccess;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLiQuanCafeNew.Presentation
{
    public partial class fr_TKHDB : Form
    {
        public fr_TKHDB()
        {
            InitializeComponent();
        }
        ConnectDB cn = new ConnectDB();
        public void khoitaoluoi()
        {
            msds.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            msds.Columns[0].HeaderText = "Số HDB";
            msds.Columns[0].Frozen = true;
            msds.Columns[0].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            msds.Columns[0].Width = 100;
            msds.Columns[1].HeaderText = "Nhân Viên";
            msds.Columns[1].Width = 100;
            msds.Columns[2].HeaderText = "Ngày Bán";
            msds.Columns[2].Width = 200;
            msds.Columns[3].HeaderText = "Khách Hàng";
            msds.Columns[3].Width = 100;
            msds.Columns[4].HeaderText = "Tổng Tiền";
            msds.Columns[4].Width = 100;

        }
        public void hienthi()
        {
            cn.GetCon();
            string sql = "SELECT     MaHDB,NgayBan, MaNV, MaKH, TongTien FROM tb_HDB";
            msds.DataSource = cn.TaoBang(sql);
            try
            {
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
        private void txtthongtin_TextChanged(object sender, EventArgs e)
        {
            khoitaoluoi();
            if (txtthongtin.Text.Length == 0)
            {
                string sql = @"SELECT     tb_HDB.MaHDB, tb_HDB.NgayBan, tb_HDB.MaNV, tb_HDB.MaKH, tb_HDB.TongTien FROM tb_HDB INNER JOIN tb_CTHDB ON tb_HDB.MaHDB = tb_CTHDB.MaHDB";
                msds.DataSource = cn.TaoBang(sql);
                cn.GetCon();
                //SqlConnection con = 
                //con.Open();
            }
            if (op1.Checked)
            {
                string sql = @"SELECT     tb_HDB.MaHDB, tb_HDB.NgayBan, tb_HDB.MaNV, tb_HDB.MaKH, tb_HDB.TongTien FROM tb_HDB INNER JOIN tb_CTHDB ON tb_HDB.MaHDB = tb_CTHDB.MaHDB WHERE tb_CTHDB.MaSP= '" + txtthongtin.Text + "'";
                msds.DataSource = cn.TaoBang(sql);
                cn.GetCon();
                //SqlConnection con = 
                //con.Open();
            }
            if (op2.Checked)
            {
                string sql = @"SELECT     tb_HDB.MaHDB, tb_HDB.NgayBan, tb_HDB.MaNV, tb_HDB.MaKH, tb_HDB.TongTien FROM tb_HDB INNER JOIN tb_CTHDB ON tb_HDB.MaHDB = tb_CTHDB.MaHDB WHERE tb_HDB.NgayBan = '" + txtthongtin.Text + "'";
                msds.DataSource = cn.TaoBang(sql);
                cn.GetCon();
                //SqlConnection con = 
                //con.Open();
            }
            if (op3.Checked)
            {
                string sql = @"SELECT     tb_HDB.MaHDB, tb_HDB.NgayBan, tb_HDB.MaNV, tb_HDB.MaKH, tb_HDB.TongTien FROM tb_HDB INNER JOIN tb_CTHDB ON tb_HDB.MaHDB = tb_CTHDB.MaHDB WHERE tb_HDB.MaNV = '" + txtthongtin.Text + "'";
                msds.DataSource = cn.TaoBang(sql);
                cn.GetCon();
                //SqlConnection con = 
                //con.Open();
            }
        }
    }
}
