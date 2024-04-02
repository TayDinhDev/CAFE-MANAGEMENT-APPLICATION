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
    public partial class fr_Nhanvien : Form
    {
        public fr_Nhanvien()
        {
            InitializeComponent();
        }
        E_tb_Nhanvien ThucThi = new E_tb_Nhanvien();
        ConnectDB cn = new ConnectDB();
        EC_tb_Nhanvien ck = new EC_tb_Nhanvien();
        bool ThemMoi;
        int dong = 0;
        public void SetNull()
        {
            txt_MaNV.Text = "";
            txt_TenNV.Text = "";
            cb_GioiTinh.Text = "Nam";
            txt_NgaySinh.Text = DateTime.Now.ToShortTimeString();
            txt_ĐT.Text = "";
            txt_DiaChi.Text = "";
            cb_MQ.Text = "";
        }
        public void LockText()
        {
            txt_MaNV.Enabled = false;
            txt_TenNV.Enabled = false;
            cb_GioiTinh.Enabled = false;
            txt_NgaySinh.Enabled = false;
            txt_DiaChi.Enabled = false;
            txt_ĐT.Enabled = false;
            cb_MQ.Enabled = false;


            bt_TMoi.Enabled = true;
            bt_Luu.Enabled = false;
            bt_Sua.Enabled = true;
            bt_Xoa.Enabled = true;
        }
        public void Un_LockText()
        {
            txt_MaNV.Enabled = true;
            txt_TenNV.Enabled = true;
            cb_GioiTinh.Enabled = true;
            txt_NgaySinh.Enabled = true;
            txt_DiaChi.Enabled = true;
            txt_ĐT.Enabled = true;
            cb_MQ.Enabled = true;

            bt_TMoi.Enabled = false;
            bt_Luu.Enabled = true;
            bt_Sua.Enabled = false;
            bt_Xoa.Enabled = false;
        }
        public void KhoiTaoLuoi()
        {
            msds.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            msds.Columns[0].HeaderText = "Mã Nhân Viên";
            msds.Columns[0].Frozen = true;
            msds.Columns[0].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            msds.Columns[0].Width = 200;
            msds.Columns[1].HeaderText = "Tên Nhân Viên";
            msds.Columns[1].Width = 200;
            msds.Columns[2].HeaderText = "Địa Chỉ";
            msds.Columns[2].Width = 200;
            msds.Columns[3].HeaderText = "Giới Tính";
            msds.Columns[3].Width = 200;
            msds.Columns[4].HeaderText = "Ngày Sinh";
            msds.Columns[4].Width = 200;
            msds.Columns[5].HeaderText = "Mã Quê";
            msds.Columns[5].Width = 200;
            msds.Columns[6].HeaderText = "SĐT";
            msds.Columns[6].Width = 200;


        }
        public void HienThi()
        {
            cn.GetCon();
            DataTable tmp = new DataTable();
            string sql = "SELECT MaNV, TenNV, DiaChi, GioiTinh, NgaySinh, MaQue, SDT FROM [tb_NhanVien]";
            msds.DataSource = cn.TaoBang(sql);
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
            Un_LockText();
            SetNull();
            txt_MaNV.Enabled = true;
            txt_MaNV.Focus();
        }

        private void bt_Luu_Click(object sender, EventArgs e)
        {
            if (txt_MaNV.Text != "")
            {
                if (cb_MQ.Text != "")
                {
                    if (ThemMoi == true)
                    {
                        try
                        {
                            ck.MANV = txt_MaNV.Text;
                            ck.TENNV = txt_TenNV.Text;
                            ck.GIOITINH = cb_GioiTinh.Text;
                            ck.NGAYSINH = txt_NgaySinh.Text;
                            ck.SDThoai = txt_ĐT.Text;
                            ck.DIACHI = txt_DiaChi.Text;
                            ck.MAQUE = cb_MQ.Text;

                            ThucThi.ThemMoiNV(ck);
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
                            ck.MANV = txt_MaNV.Text;
                            ck.TENNV = txt_TenNV.Text;
                            ck.GIOITINH = cb_GioiTinh.Text;
                            ck.NGAYSINH = txt_NgaySinh.Text;
                            ck.SDThoai = txt_ĐT.Text;
                            ck.DIACHI = txt_DiaChi.Text;
                            ck.MAQUE = cb_MQ.Text;

                            ThucThi.SuaNV(ck);
                            MessageBox.Show("Đã Sửa Thành Công Thành Công", "Chú Ý", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.ToString(), "Chú Ý", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    txt_MaNV.Enabled = true;
                    LockText();
                    HienThi();
                }
                else
                {
                    MessageBox.Show("Mã Không được để trống", "Chú Ý", MessageBoxButtons.OK);
                    cb_MQ.Focus();
                }
            }
            else
            {
                MessageBox.Show("Mã Không được để trống", "Chú Ý", MessageBoxButtons.OK);
                txt_MaNV.Focus();
            }
        }

        private void bt_Sua_Click(object sender, EventArgs e)
        {
            ThemMoi = false;
            Un_LockText();
            txt_MaNV.Enabled = false;
            txt_TenNV.Focus();
        }

        private void bt_Xoa_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Xóa dữ liệu này?", "Chú Ý", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                try
                {
                    ck.MANV = txt_MaNV.Text;

                    ThucThi.XoaNV(ck);
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

        private void fr_Nhanvien_Load(object sender, EventArgs e)
        {
            ThucThi.LoadMaQue(cb_MQ);
            LockText();
            HienThi();
            KhoiTaoLuoi();
        }

        private void cb_MQ_SelectedIndexChanged(object sender, EventArgs e)
        {
            lb_TQ.Text = ThucThi.LoadTenQue(lb_TQ.Text, cb_MQ.Text);
        }

        private void msds_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            dong = e.RowIndex;
            txt_MaNV.Text = msds.Rows[dong].Cells[0].Value.ToString();
            txt_TenNV.Text = msds.Rows[dong].Cells[1].Value.ToString();
            txt_DiaChi.Text = msds.Rows[dong].Cells[2].Value.ToString();
            cb_GioiTinh.Text = msds.Rows[dong].Cells[3].Value.ToString();
            txt_NgaySinh.Text = msds.Rows[dong].Cells[4].Value.ToString();
            cb_MQ.Text = msds.Rows[dong].Cells[5].Value.ToString();
            txt_ĐT.Text = msds.Rows[dong].Cells[6].Value.ToString();
            LockText();
        }
    }
}
