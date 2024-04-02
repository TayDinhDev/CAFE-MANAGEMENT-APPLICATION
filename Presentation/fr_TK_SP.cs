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
    public partial class fr_TK_SP : Form
    {
        public fr_TK_SP()
        {
            InitializeComponent();
        }
        ConnectDB cn = new ConnectDB();
        public void khoitaoluoi()
        {
            //RepositoryItemPictureEdit image = msds.RepositoryItems.Add("PictureEdit") as RepositoryItemPictureEdit;
            msds.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            msds.Columns[0].HeaderText = "Mã Sản Phẩm";
            msds.Columns[0].Frozen = true;
            msds.Columns[0].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            msds.Columns[0].Width = 200;

            msds.Columns[1].HeaderText = "Tên Sản Phẩm";
            msds.Columns[1].Width = 200;

            msds.Columns[2].HeaderText = "Mã Loại";
            msds.Columns[2].Width = 200;

            msds.Columns[3].HeaderText = "Giá Nhập";
            msds.Columns[3].Width = 200;

            msds.Columns[4].HeaderText = "Giá Bán";
            msds.Columns[4].Width = 200;

            msds.Columns[5].HeaderText = "số Lượng";
            msds.Columns[5].Width = 200;

            msds.Columns[6].HeaderText = "Công Dụng";
            msds.Columns[6].Width = 200;

            msds.Columns[7].HeaderText = "Ảnh";
            msds.Columns[7].Width = 200;


        }
        public void hienthi()
        {
            cn.GetCon();
            string sql = "SELECT MaSP, TenSP, MaLoai, GiaNhap, GiaBan, SoLuong, MaCD, HinhAnh FROM tb_SanPham";
            msds.DataSource = cn.TaoBang(sql);
            try
            {
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
        private void msds_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void txtthongtin_TextChanged(object sender, EventArgs e)
        {
            khoitaoluoi();
            if (txtthongtin.Text.Length == 0)
            {
                string sql = @"SELECT MaSP, TenSP, MaLoai, GiaNhap, GiaBan, SoLuong, MaCD, HinhAnh FROM tb_SanPham";
                msds.DataSource = cn.TaoBang(sql);
                cn.GetCon();
                //SqlConnection con = cn.GetCon();
                //con.Open();
            }
            if (op1.Checked)
            {
                string sql = @"SELECT MaSP, TenSP, MaLoai, GiaNhap, GiaBan, SoLuong, MaCD, HinhAnh FROM tb_SanPham WHERE MaLoai= '" + txtthongtin.Text + "'";
                msds.DataSource = cn.TaoBang(sql);
                cn.GetCon();
                //SqlConnection con = cn.GetCon();
                //con.Open();
            }
            if (op2.Checked)
            {
                string sql = @"SELECT MaSP, TenSP, MaLoai, GiaNhap, GiaBan, SoLuong, MaCD, HinhAnh FROM tb_SanPham WHERE GiaNhap= '" + txtthongtin.Text + "'";
                msds.DataSource = cn.TaoBang(sql);
                cn.GetCon();
                //SqlConnection con = cn.GetCon();
                //con.Open();
            }
            if (op3.Checked)
            {
                string sql = @"SELECT MaSP, TenSP, MaLoai, GiaNhap, GiaBan, SoLuong, MaCD, HinhAnh FROM tb_SanPham WHERE MaCD= '" + txtthongtin.Text + "'";
                msds.DataSource = cn.TaoBang(sql);
                cn.GetCon();
                //SqlConnection con = cn.GetCon();
                //con.Open();
            }
            if (op4.Checked)
            {
                string sql = @"SELECT MaSP, TenSP, MaLoai, GiaNhap, GiaBan, SoLuong, MaCD, HinhAnh FROM tb_SanPham where TenSP  like N'%" + txtthongtin.Text + "%'";
                msds.DataSource = cn.TaoBang(sql);
                cn.GetCon();
                //SqlConnection con = cn.GetCon();
                //con.Open();
            }
        }

    }
}
