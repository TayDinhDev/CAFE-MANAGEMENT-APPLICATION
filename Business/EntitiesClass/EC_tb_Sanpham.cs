using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLiQuanCafeNew.Business.EntitiesClass
{
    internal class EC_tb_Sanpham
    {
        private string MaSP;
        private string TenSP;
        private string MaLoai;
        private string GiaNhap;
        private string GiaBan;
        private string SoLuong;
        private string MaCD;
        private byte[] HinhAnh;

        public string MASP
        {
            get
            {
                return MaSP;
            }
            set
            {
                MaSP = value;
                if (MaSP == "")
                {
                    throw new Exception("Mã không để trống");
                }
            }
        }
        public string TENSP
        {
            get
            {
                return TenSP;
            }
            set
            {
                TenSP = value;
            }
        }
        public string MALOAI
        {
            get
            {
                return MaLoai;
            }
            set
            {
                MaLoai = value;
                if (MaLoai == "")
                {
                    throw new Exception("Mã không để trống");
                }
            }
        }
        public string GIANHAP
        {
            get
            {
                return GiaNhap;
            }
            set
            {
                GiaNhap = value;
            }
        }
        public string GIABAN
        {
            get
            {
                return GiaBan;
            }
            set
            {
                GiaBan = value;
            }
        }
        public string SOLUONG
        {
            get
            {
                return SoLuong;
            }
            set
            {
                SoLuong = value;
            }
        }
        public string MACONGDUNG
        {
            get
            {
                return MaCD;
            }
            set
            {
                MaCD = value;
                if (MaCD == "")
                {
                    throw new Exception("Mã không để trống");
                }
            }
        }
        public byte[] HINHANH
        {
            get
            {
                return HinhAnh;
            }
            set
            {
                HinhAnh = value;
            }
        }
    }
}
