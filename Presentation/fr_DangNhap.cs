using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
using System.Data.SqlClient;
using QuanLiQuanCafeNew.DataAccess;
using QuanLiQuanCafeNew.Business.EntitiesClass;
using QuanLiQuanCafeNew.Business.Component;
using System.Security.Cryptography;
using System.IO;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace QuanLiQuanCafeNew.Presentation
{
    public partial class fr_DangNhap : Form
    {
        public fr_DangNhap()
        {
            InitializeComponent();
        }
        private ConnectDB cn = new ConnectDB();
        E_tb_User thucthi = new E_tb_User();
        //private connectdb con = new connectdb();
        private int Dem_sl_dn_sai = 0;
        EC_tb_User ck = new EC_tb_User();
        private void cmddn_Click(object sender, EventArgs e)
        {
            try
            {
                cn.GetCon();
                DataTable tbl_DSTK = new DataTable();
                tbl_DSTK = cn.TaoBang("select * from tb_User where Username= '" + txt_User.Text + "' and Passwork = '" + txt_Pass.Text + "'");
                // MessageBox.Show(tbl_DSGV.Rows.Count.ToString()); in ra so dong
                if (tbl_DSTK.Rows.Count > 0)
                {
                    // Mở form fr_Main
                    fr_Main frmMain = new fr_Main();
                    frmMain.ShowDialog();
                    // Hoặc sử dụng frmMain.ShowDialog(); nếu muốn đợi form fr_Main đóng lại
                }
                else
                {
                    MessageBox.Show("DN khong thanh cong");
                    Dem_sl_dn_sai++;
                    if (Dem_sl_dn_sai == 5)
                    {
                        MessageBox.Show("Bạn đã nhập sai 5 lần");
                        bt_OK.Enabled = false;
                        timer1.Enabled = true;
                        Dem_sl_dn_sai = 0;
                    }
                }
            }
            catch (Exception)
            {

            }
            //string user = txt_User.Text;
            //string pass = txt_Pass.Text;
            //try
            //{
            //    ck.UserName = user;
            //    ck.Password = pass;
            //    if (!thucthi.kiemtrauser(user, pass))
            //    {
            //        MessageBox.Show("Đăng Nhập Thành Công", "Chúc Mừng", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //        // Ẩn form fr_DangNhap
            //        this.Hide();

            //        // Mở form fr_Main
            //        fr_Main fr = new fr_Main();
            //        fr.Show();
            //    }
            //    else
            //    {
            //        MessageBox.Show("Tài khoản đăng nhập chưa đúng. Vui lòng kiểm tra lại.", "Chú Ý", MessageBoxButtons.OK, MessageBoxIcon.Error);

            //        txt_User.Text = "";
            //        txt_Pass.Text = "";
            //        txt_User.Focus();
            //        return;
            //    }
            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show("cút");
            //    MessageBox.Show(ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //}
        }

        private void bt_Thoat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void txt_User_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_Pass_TextChanged(object sender, EventArgs e)
        {

        }

		private void fr_DangNhap_Load(object sender, EventArgs e)
		{

		}
	}
}
