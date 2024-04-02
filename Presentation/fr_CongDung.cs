using QuanLiQuanCafeNew.Business.Component;
using QuanLiQuanCafeNew.Business.EntitiesClass;
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
    public partial class fr_CongDung : Form
    {
        public fr_CongDung()
        {
            InitializeComponent();
        }
        E_tb_Congdung ThucThi = new E_tb_Congdung();
        ConnectDB cn = new ConnectDB();
        EC_tb_Congdung ck = new EC_tb_Congdung();
        bool ThemMoi;
        int dong = 0;

        public void SetNull()
        {
            txt_Ma.Text = "";
            txt_Ten.Text = "";
        }
        public void LockText()
        {
            txt_Ma.Enabled = false;
            txt_Ten.Enabled = false;
            bt_TMoi.Enabled = true;
            bt_Luu.Enabled = false;
            bt_Sua.Enabled = true;
            bt_Xoa.Enabled = true;
        }
        public void un_LockText()
        {
            txt_Ma.Enabled = true;
            txt_Ten.Enabled = true;
            bt_TMoi.Enabled = false;
            bt_Luu.Enabled = true;
            bt_Sua.Enabled = false;
            bt_Xoa.Enabled = false;
        }
        public void KhoiTaoLuoi()
        {
            msds.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            msds.Columns[0].HeaderText = "Mã Công Dụng";
            msds.Columns[0].Frozen = true;
            msds.Columns[0].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            msds.Columns[0].Width = 150;
            msds.Columns[1].HeaderText = "Tên Công Dụng";
            msds.Columns[1].Width = 200;

        }
        public void HienThi()
        {
            cn.GetCon();
            string sql = "SELECT MaCD, TenCD FROM tb_CongDung";
            msds.DataSource = cn.TaoBang(sql);
            SqlConnection con = cn.GetCon();
            try
            {
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
        private void bt_TMoi_Click(object sender, EventArgs e)
        {
            ThemMoi = true;
            un_LockText();
            SetNull();
            txt_Ma.Enabled = true;
            txt_Ma.Focus();
        }

        private void bt_Luu_Click(object sender, EventArgs e)
        {
            if (txt_Ma.Text != "")
            {
                if (ThemMoi == true)
                {
                    try
                    {
                        ck.MACONGDUNG = txt_Ma.Text;
                        ck.TENCONGDUNG = txt_Ten.Text;
                        ThucThi.ThemMoinv(ck);
                        LockText();
                        HienThi();
                        MessageBox.Show("Đã Lưu Thành Công", "Chú Ý", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.ToString(), "Chú Ý", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                else
                    try
                    {
                        ck.MACONGDUNG = txt_Ma.Text;
                        ck.TENCONGDUNG = txt_Ten.Text;
                        ThucThi.Suanv(ck);
                        MessageBox.Show("Đã Sửa Thành Công Thành Công", "Chú Ý", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.ToString(), "Chú Ý", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                txt_Ma.Enabled = true;
                LockText();
                HienThi();
            }
            else
            {
                MessageBox.Show("Mã Không được để trống", "Chú Ý", MessageBoxButtons.OK);
                txt_Ma.Focus();
            }
        }

        private void bt_Sua_Click(object sender, EventArgs e)
        {
            ThemMoi = false;
            un_LockText();
            txt_Ma.Enabled = false;
            txt_Ten.Focus();
        }

        private void bt_Xoa_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Xóa dữ liệu này?", "Chú Ý", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                try
                {
                    ck.MACONGDUNG = txt_Ma.Text;

                    ThucThi.Xoanv(ck);
                    MessageBox.Show("Đã Xóa Thành Công", "Chú Ý", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    HienThi();
                    SetNull();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Lỗi");
                }
            }
        }

        private void fr_CongDung_Load(object sender, EventArgs e)
        {
            LockText();
            HienThi();
            KhoiTaoLuoi();
        }

        private void msds_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            dong = e.RowIndex;
            txt_Ma.Text = msds.Rows[dong].Cells[0].Value.ToString();
            txt_Ten.Text = msds.Rows[dong].Cells[1].Value.ToString();
            LockText();
        }
    }
}
