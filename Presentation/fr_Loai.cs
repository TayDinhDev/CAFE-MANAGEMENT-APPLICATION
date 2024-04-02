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
    public partial class fr_Loai : Form
    {
        public fr_Loai()
        {
            InitializeComponent();
        }
        E_tb_Loai thucthi = new E_tb_Loai();
        ConnectDB cn = new ConnectDB();
        EC_tb_Loai ck = new EC_tb_Loai();
        bool themmoi;
        int dong = 0;

        public void SetNull()
        {
            txt_MaL.Text = "";
            txt_TenL.Text = "";
        }
        public void LockText()
        {
            txt_MaL.Enabled = false;
            txt_TenL.Enabled = false;
            bt_TMoi.Enabled = true;
            bt_Luu.Enabled = false;
            bt_Sua.Enabled = true;
            bt_Xoa.Enabled = true;
        }
        public void un_Locktext()
        {
            txt_MaL.Enabled = true;
            txt_TenL.Enabled = true;
            bt_TMoi.Enabled = false;
            bt_Luu.Enabled = true;
            bt_Sua.Enabled = false;
            bt_Xoa.Enabled = false;
        }
        public void KhoiTaoLuoi()
        {
            msds.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            msds.Columns[0].HeaderText = "Mã Loại";
            msds.Columns[0].Frozen = true;
            msds.Columns[0].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            msds.Columns[0].Width = 150;
            msds.Columns[1].HeaderText = "Tên Loại";
            msds.Columns[1].Width = 200;

        }
        public void HienThi()
        {
            cn.GetCon();
            string sql = "SELECT MaLoai, TenLoai FROM tb_Loai";
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
        private void btmoi_Click(object sender, EventArgs e)
        {
            themmoi = true;
            un_Locktext();
            SetNull();
            txt_MaL.Enabled = true;
            txt_MaL.Focus();
        }

        private void bt_Luu_Click(object sender, EventArgs e)
        {
            if (txt_MaL.Text != "")
            {
                if (themmoi == true)
                {
                    try
                    {
                        ck.MALOAI = txt_MaL.Text;
                        ck.TENLOAI = txt_TenL.Text;
                        thucthi.ThemMoilg(ck);
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
                        ck.MALOAI = txt_MaL.Text;
                        ck.TENLOAI = txt_TenL.Text;
                        thucthi.Sualg(ck);
                        MessageBox.Show("Đã Sửa Thành Công Thành Công", "Chú Ý", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.ToString(), "Chú Ý", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                txt_MaL.Enabled = true;
                LockText();
                HienThi();
            }
            else
            {
                MessageBox.Show("Mã Không được để trống", "Chú Ý", MessageBoxButtons.OK);
                txt_MaL.Focus();
            }
        }

        private void bt_Sua_Click(object sender, EventArgs e)
        {
            themmoi = false;
            un_Locktext();
            txt_MaL.Enabled = false;
            txt_TenL.Focus();
        }

        private void bt_Xoa_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Xóa dữ liệu này?", "Chú Ý", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                try
                {
                    ck.MALOAI = txt_MaL.Text;

                    thucthi.Xoalg(ck);
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

        private void fr_Loai_Load(object sender, EventArgs e)
        {
            LockText();
            HienThi();
            KhoiTaoLuoi();
        }

        private void msds_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            dong = e.RowIndex;
            txt_MaL.Text = msds.Rows[dong].Cells[0].Value.ToString();
            txt_TenL.Text = msds.Rows[dong].Cells[1].Value.ToString();
            LockText();
        }
    }
}
