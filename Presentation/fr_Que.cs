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
    public partial class fr_Que : Form
    {
        public fr_Que()
        {
            InitializeComponent();
        }
        E_tb_Que ThucThi = new E_tb_Que();
        ConnectDB cn = new ConnectDB();
        EC_tb_Que ck = new EC_tb_Que();
        bool ThemMoi;
        int dong = 0;
        public void SetNull()
        {
            txt_MQ.Text = "";
            txt_TQ.Text = "";
        }
        public void LockText()
        {
            txt_MQ.Enabled = false;
            txt_TQ.Enabled = false;
            bt_TMoi.Enabled = true;
            bt_Luu.Enabled = false;
            bt_Sua.Enabled = true;
            bt_Xoa.Enabled = true;
        }
        public void Un_LockText()
        {
            txt_MQ.Enabled = true;
            txt_TQ.Enabled = true;
            bt_TMoi.Enabled = false;
            bt_Luu.Enabled = true;
            bt_Sua.Enabled = false;
            bt_Xoa.Enabled = false;
        }
        public void KhoiTaoLuoi()
        {
            ms_DS.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            ms_DS.Columns[0].HeaderText = "Mã Quê";
            ms_DS.Columns[0].Frozen = true;
            ms_DS.Columns[0].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            ms_DS.Columns[0].Width = 150;
            ms_DS.Columns[1].HeaderText = "Tên Quê";
            ms_DS.Columns[1].Width = 200;

        }
        public void HienThi()
        {
            MessageBox.Show("Tao đây");
            cn.GetCon();
            DataTable tmp = new DataTable();
            string Caulenhtruyvan = "SELECT MaQue, TenQue FROM [tb_Que]";
            ms_DS.DataSource = cn.TaoBang(Caulenhtruyvan);//ms_DS
            //for (int i = 0; i < tmp.Rows.Count; i++)
            //{
            //    ms_DS.Rows.Add();
            //    ms_DS.Rows[i].Cells[0].Value = i + 1;
            //    for (int j = 0; j < tmp.Columns.Count; j++)
            //    {
            //        ms_DS.Rows[i].Cells[j + 1].Value = tmp.Rows[i][j].ToString();
            //    }
            //}
            try
            {
                // Các thao tác với cơ sở dữ liệu ở đây
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
        private void btmoi_Click(object sender, EventArgs e)
        {
            ThemMoi = true;
            Un_LockText();
            SetNull();
            txt_MQ.Enabled = true;
            txt_MQ.Focus();
        }

        private void bt_Luu_Click(object sender, EventArgs e)
        {
            if (txt_MQ.Text != "")
            {
                if (ThemMoi == true)
                {
                    try
                    {
                        ck.MaQue = txt_MQ.Text;
                        ck.TenQue = txt_TQ.Text;
                        MessageBox.Show("Pass1");
                        ThucThi.ThemMoilg(ck);
                        MessageBox.Show("Pass2");

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
                {
                    try
                    {
                        ck.MAQUE = txt_MQ.Text;
                        ck.TENQUE = txt_TQ.Text;
                        ThucThi.Sualg(ck);
                        MessageBox.Show("Đã Sửa Thành Công Thành Công", "Chú Ý", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.ToString(), "Chú Ý", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    txt_MQ.Enabled = true;
                    LockText();
                    HienThi();
                }
            }
            else
            {
                MessageBox.Show("Mã Không được để trống", "Chú Ý", MessageBoxButtons.OK);
                txt_MQ.Focus();
            }
        }

        private void bt_Sua_Click(object sender, EventArgs e)
        {
            ThemMoi = false;
            Un_LockText();
            txt_MQ.Enabled = false;
            txt_TQ.Focus();
        }

        private void bt_Xoa_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Xóa dữ liệu này?", "Chú Ý", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                try
                {
                    ck.MAQUE = txt_MQ.Text;

                    ThucThi.Xoalg(ck);
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

        private void fr_Que_Load(object sender, EventArgs e)
        {
            LockText();
            HienThi();
            KhoiTaoLuoi();
        }

        private void ms_DS_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            dong = e.RowIndex;
            txt_MQ.Text = ms_DS.Rows[dong].Cells[0].Value.ToString();
            txt_TQ.Text = ms_DS.Rows[dong].Cells[1].Value.ToString();
            LockText();
        }
    }
}
