using Microsoft.Office.Interop.Excel;
using QuanLiQuanCafeNew.DataAccess;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace QuanLiQuanCafeNew.Presentation
{
    public partial class fr_Splash_Screen : Form
    {
        public fr_Splash_Screen()
        {
            InitializeComponent();
            timer1.Interval = 1000; // Đơn vị là mili giây, ở đây là 5 giây
            timer1.Tick += Timer1_Tick; ; // Đăng ký sự kiện Tick cho Timer
        }

        private void Timer1_Tick(object sender, EventArgs e)
        {
           // throw new NotImplementedException();
        }

        private ConnectDB Cn = new ConnectDB();
        private int Dem_SL_DN_Sai = 0;

        //ConnectDB cn = new ConnectDB();

        //SqlConnection Conn;
        //SqlCommand Comm;
        //SqlDataReader sqlDR;
        private void fr_Splash_Screen_Load(object sender, EventArgs e)
        {
            ////cn.GetCon();
            ////DataTable tbl_DSTK = new DataTable();
            ////tbl_DSTK = Con.LayDL("select * from TaiKhoan where TK= '" + textBox1.Text + "' and MK = '" + textBox2.Text + "'");
            //SqlConnection Conn = cn.GetCon();
            //StreamReader read = new StreamReader("Sinfo");
            //this.Server = (read.ReadLine().Split(':')[1]);
            //try
            //{
            //    Conn.Open();
            //    Conn.Close();
            //    timer1.Enabled = true;
            //    read.Close();
            //}
            //catch
            //{
            //    //fr_Ketnoi fr = new fr_Ketnoi();
            //    //read.Close();
            //    //fr.ShowDialog();

            //}
            timer1.Start();

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            //fr_DangNhap fr = new fr_DangNhap();
            //Cn.GetCon();
            //fr_DangNhap fr = new fr_DangNhap();
            //fr = Cn.GetCon("select * from [tb_User] where Username= '" + txt_User.Text + "' and MK = '" + textBox2.Text + "'");
            //fr.ShowDialog(); // Mở form fr_DangNhap dưới dạng dialog để chờ người dùng đăng nhập
            //if (fr.DialogResult == DialogResult.OK) // Kiểm tra kết quả trả về khi form fr_DangNhap đóng lại
            //{
            //    if (fr.LoginSuccessful) // Kiểm tra nếu đăng nhập đúng
            //    {
            //        fr_Main frMain = new fr_Main();
            //        frMain.Show(); // Mở form fr_Main
            //        this.Hide();
            //    }
            //}
            // Tạo một instance của form fr_DangNhap

            //fr_DangNhap frDangNhap = new fr_DangNhap();

            //// Mở form fr_DangNhap
            //frDangNhap.Show();

            //// Ẩn form fr_Splash_Screen
            //this.Hide();
            // Dừng Timer
            timer1.Enabled = false;

            // Mở Form fr_DangNhap
            fr_DangNhap frDangNhap = new fr_DangNhap();
            frDangNhap.ShowDialog();

            // Sau khi Form fr_DangNhap đóng lại, đặt lại Enabled của Timer là true để tiếp tục chạy Timer
            timer1.Enabled = true;
        }

    }
}
