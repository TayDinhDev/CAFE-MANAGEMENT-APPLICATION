using QuanLiQuanCafeNew.Business.Component;
using QuanLiQuanCafeNew.Business.EntitiesClass;
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

namespace QuanLiQuanCafeNew.Presentation
{
    public partial class fr_Sanpham : Form
    {
        public fr_Sanpham()
        {
            InitializeComponent();
        }
        ConnectDB Conn = new ConnectDB();
        E_tb_Sanpham ThucThi = new E_tb_Sanpham();
        ConnectDB cn = new ConnectDB();
        EC_tb_Sanpham ck = new EC_tb_Sanpham();
        bool ThemMoi;
        int dong = 0;

        private byte[] hinhanh;
        public byte[] HINHANH
        {
            get
            {
                return hinhanh;
            }
            set
            {
                hinhanh = value;
            }
        }


        public void SetNull()
        {
            txt_Ma.Text = "";
            txt_Ten.Text = "";
            txt_DGB.Text = "0";
            txt_DGN.Text = "0";
            txt_SL.Text = "0";
            txt_Ngay.Text = "";
            //imghinhanh.Image = QuanLyCuaHangTivi.Properties.Resources.no;
        }
        public void LockText()
        {
            txt_Ma.Enabled = false;
            txt_Ten.Enabled = false;
            txt_Ngay.Enabled = false;


            bt_TMoi.Enabled = true;
            bt_Luu.Enabled = false;
            bt_Sua.Enabled = true;
            bt_Xoa.Enabled = true;
        }
        public void un_LockText()
        {
            txt_Ma.Enabled = true;
            txt_Ten.Enabled = true;
            txt_Ngay.Enabled = true;

            bt_TMoi.Enabled = false;
            bt_Luu.Enabled = true;
            bt_Sua.Enabled = false;
            bt_Xoa.Enabled = false;
        }
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
            string sql = "SELECT MaSP, TenSP, MaLoai, GiaNhap, GiaBan, SoLuong, MaCD, HinhAnh FROM tb_SanPham";
            msds.DataSource = cn.TaoBang(sql);
            Conn.GetCon();
            try
            {
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
        private void lbimgpath_Click(object sender, EventArgs e)
        {

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
                if (cb_Loai.Text != "")
                {
                    if (cb_MaCD.Text != "")
                    {
                        if (ThemMoi == true)
                        {
                            try
                            {
                                byte[] imageData = ReadFile(lbimgpath.Text);
                                ck.MASP = txt_Ma.Text;
                                ck.TENSP = txt_Ten.Text;
                                ck.MALOAI = cb_Loai.Text;
                                ck.GIABAN = txt_DGB.Text;
                                ck.GIANHAP = txt_DGN.Text;
                                ck.SOLUONG = txt_SL.Text;
                                ck.MACONGDUNG = cb_MaCD.Text;
                                ck.HINHANH = imageData;

                                ThucThi.ThemMoi(ck);
                                LockText();
                                hienthi();
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
                                byte[] imageData = ReadFile(lbimgpath.Text);
                                ck.MASP = txt_Ma.Text;
                                ck.TENSP = txt_Ten.Text;
                                ck.MALOAI = cb_Loai.Text;
                                ck.GIABAN = txt_DGB.Text;
                                ck.GIANHAP = txt_DGN.Text;
                                ck.SOLUONG = txt_SL.Text;
                                ck.MACONGDUNG = cb_MaCD.Text;
                                ck.HINHANH = imageData;

                                ThucThi.Sua(ck);
                                MessageBox.Show("Đã Sửa Thành Công Thành Công", "Chú Ý", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                            catch (Exception ex)
                            {
                                MessageBox.Show(ex.ToString(), "Chú Ý", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                        txt_Ma.Enabled = true;
                        LockText();
                        hienthi();
                    }
                    else
                    {
                        MessageBox.Show("Mã Không được để trống", "Chú Ý", MessageBoxButtons.OK);
                        cb_MaCD.Focus();
                    }
                }
                else
                {
                    MessageBox.Show("Mã Không được để trống", "Chú Ý", MessageBoxButtons.OK);
                    cb_Loai.Focus();
                }
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
                    ck.MASP = txt_Ma.Text;

                    ThucThi.xoa(ck);
                    MessageBox.Show("Đã Xóa Thành Công", "Chú Ý", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    hienthi();
                    SetNull();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Lỗi");
                }
            }
        }

        private void fr_Sanpham_Load(object sender, EventArgs e)
        {
            imghinhanh.SizeMode = PictureBoxSizeMode.StretchImage;
            try
            {
                //Get image data from gridview column.
                byte[] imageData = hinhanh;
                if (imageData == null || imageData.Length == 0)
                {
                    throw new ArgumentException("Invalid image data.");
                }
                //Initialize image variable
                Image newImage;
                //Read image data into a memory stream
                using (MemoryStream ms = new MemoryStream(imageData, 0, imageData.Length))
                {
                    ms.Write(imageData, 0, imageData.Length);

                    //Set image variable value using memory stream.
                    newImage = Image.FromStream(ms, true);
                }

                //set picture
                imghinhanh.Image = newImage;
            }
            catch
            {

            }
            ThucThi.LoadML(cb_Loai);
            ThucThi.LoadMaCD(cb_MaCD);
            LockText();
            hienthi();
            khoitaoluoi();
        }

        private void msds_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            dong = e.RowIndex;
            txt_Ma.Text = msds.Rows[dong].Cells[0].Value.ToString();
            txt_Ten.Text = msds.Rows[dong].Cells[1].Value.ToString();
            cb_Loai.Text = msds.Rows[dong].Cells[2].Value.ToString();

            txt_DGN.Text = msds.Rows[dong].Cells[3].Value.ToString();
            txt_DGB.Text = msds.Rows[dong].Cells[4].Value.ToString();
            txt_SL.Text = msds.Rows[dong].Cells[5].Value.ToString();
            cb_MaCD.Text = msds.Rows[dong].Cells[6].Value.ToString();
            //imghinhanh.Image = QuanLyCuaHangTivi.Properties.Resources.no;
            LockText();
        }
        byte[] ReadFile(string sPath)
        {

            byte[] data = null;

            //sử dụng FileInfo để lấy kích thước file.
            FileInfo fInfo = new FileInfo(sPath);
            long numBytes = fInfo.Length;

            //Đọc file
            FileStream fStream = new FileStream(sPath, FileMode.Open, FileAccess.Read);

            //Sử dụng BinaryReader để đọc file vào mảng byte.
            BinaryReader br = new BinaryReader(fStream);
            data = br.ReadBytes((int)numBytes);
            return data;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog dlg = new OpenFileDialog();

                dlg.Filter = "Image File (*.jpg;*.jpeg;*.bmp;*.gif;*.png)|*.jpg;*.jpeg;*.bmp;*.gif;*.png";
                dlg.Title = "Chọn Hình";

                DialogResult dlgRes = dlg.ShowDialog();
                if (dlgRes != DialogResult.Cancel)
                {
                    //Gán hình vào Picture box
                    imghinhanh.ImageLocation = dlg.FileName;
                    imghinhanh.SizeMode = PictureBoxSizeMode.StretchImage;
                    //Gán đường dẫn ảnh vào lbimgpath
                    lbimgpath.Text = dlg.FileName;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void cb_Loai_SelectedIndexChanged(object sender, EventArgs e)
        {
            lbl.Text = ThucThi.loadtenl(lbl.Text, cb_Loai.Text);
        }

        private void cb_MaCD_SelectedIndexChanged(object sender, EventArgs e)
        {
            lbcd.Text = ThucThi.loadtencd(lbcd.Text, cb_MaCD.Text);
        }
    }
}
