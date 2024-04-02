using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLiQuanCafeNew.Business.EntitiesClass
{
    internal class EC_tb_Nhanvien
    {
        private string MaNV;
        private string TenNV;
        private string DiaChi;
        private string GioiTinh;
        private string NgaySinh;
        private string MaQue;
        private string SDT;

        public string MANV
        {
            get
            {
                return MaNV;
            }
            set
            {
                MaNV = value;
                if (MaNV == "")
                {
                    throw new Exception("Mã không để trống");
                }
            }
        }
        public string TENNV
        {
            get
            {
                return TenNV;
            }
            set
            {
                TenNV = value;
            }
        }
        public string DIACHI
        {
            get
            {
                return DiaChi;
            }
            set
            {
                DiaChi = value;
            }
        }
        public string GIOITINH
        {
            get
            {
                return GioiTinh;
            }
            set
            {
                GioiTinh = value;
            }
        }
        public string NGAYSINH
        {
            get
            {
                return NgaySinh;
            }
            set
            {
                NgaySinh = value;
            }
        }
        public string MAQUE
        {
            get
            {
                return MaQue;
            }
            set
            {
                MaQue = value;
                if (MaQue == "")
                {
                    throw new Exception("Mã không được để trống");
                }
            }
        }
        public string SDThoai
        {
            get
            {
                return SDT;
            }
            set
            {
                SDT = value;
            }
        }
    }
}
