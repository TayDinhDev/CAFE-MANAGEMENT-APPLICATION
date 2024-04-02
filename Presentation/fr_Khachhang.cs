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
    public partial class fr_Khachhang : Form
    {
        public fr_Khachhang()
        {
            InitializeComponent();
        }
        E_tb_Khachhang ThucThi = new E_tb_Khachhang();
        ConnectDB cn = new ConnectDB();
        EC_tb_Khachhang ck = new EC_tb_Khachhang();
        bool ThemMoi;
        int dong = 0;
        public void SetNull()
        {
            txt_MaKH.Text = "";
            txt_TenKH.Text = "";
        }
        public void LockText()
        {
            txt_MaKH.Enabled = false;
            txt_TenKH.Enabled = false;

            bt_TMoi.Enabled = true;
            bt_Luu.Enabled = false;
            bt_Sua.Enabled = true;
            bt_Xoa.Enabled = true;
        }
        public void un_LockText()
        {
            txt_MaKH.Enabled = true;
            txt_TenKH.Enabled = true;

            bt_TMoi.Enabled = false;
            bt_Luu.Enabled = true;
            bt_Sua.Enabled = false;
            bt_Xoa.Enabled = false;
        }
        public void KhoiTaoLuoi()
        {
            msds.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            msds.Columns[0].HeaderText = "Mã KH";
            msds.Columns[0].Frozen = true;
            msds.Columns[0].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            msds.Columns[0].Width = 150;
            msds.Columns[1].HeaderText = "Tên KH";
            msds.Columns[1].Width = 200;

        }
        public void HienThi()
        {
            cn.GetCon();
            string sql = "SELECT     makh, tenkh  FROM tb_Khachhang";
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
            txt_MaKH.Enabled = true;
            txt_MaKH.Focus();
        }

        private void bt_Luu_Click(object sender, EventArgs e)
        {
            if (txt_MaKH.Text != "")
            {
                if (ThemMoi == true)
                {
                    try
                    {
                        ck.MAKH = txt_MaKH.Text;
                        ck.TENKH = txt_TenKH.Text;

                        ThucThi.ThemMoiKH(ck);
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
                        ck.MAKH = txt_MaKH.Text;
                        ck.TENKH = txt_TenKH.Text;

                        ThucThi.SuaKH(ck);
                        MessageBox.Show("Đã Sửa Thành Công Thành Công", "Chú Ý", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.ToString(), "Chú Ý", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                txt_MaKH.Enabled = true;
                LockText();
                HienThi();
            }
            else
            {
                MessageBox.Show("Mã Không được để trống", "Chú Ý", MessageBoxButtons.OK);
                txt_MaKH.Focus();
            }
        }

        private void bt_Sua_Click(object sender, EventArgs e)
        {
            ThemMoi = false;
            un_LockText();
            txt_MaKH.Enabled = false;
            txt_TenKH.Focus();
        }

        private void bt_Xoa_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Xóa dữ liệu này?", "Chú Ý", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                try
                {
                    ck.MAKH = txt_MaKH.Text;

                    ThucThi.XoaKH(ck);
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

        private void fr_Khachhang_Load(object sender, EventArgs e)
        {
            LockText();
            HienThi();
            KhoiTaoLuoi();
        }

        private void msds_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            dong = e.RowIndex;
            txt_MaKH.Text = msds.Rows[dong].Cells[0].Value.ToString();
            txt_TenKH.Text = msds.Rows[dong].Cells[1].Value.ToString();
            LockText();
        }
    }
}
