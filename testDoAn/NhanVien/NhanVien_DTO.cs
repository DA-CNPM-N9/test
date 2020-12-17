using System;

namespace NhanVien
{
    public class NhanVien_DTO
    {
        public string maNV { get; set; }
        public string hoTenNV { get; set; }
        public string cmnd { get; set; }
        public string sdtNV { get; set; }
        public string mail { get; set; }
        public string ngaySinh { get; set; }
        public string diaChi { get; set; }
        public string hoTenNLH { get; set; }
        public string sdtNLH { get; set; }
        public string matKhau { get; set; }
        public int chucVu { get; set; }
        //static void Main(string[] args){}
        public NhanVien_DTO()
        {
            this.maNV = "null";
            this.hoTenNV = "null";
            this.cmnd = "null";
            this.sdtNV = "null";
            this.mail= "null";
            this.ngaySinh = "null";
            this.diaChi = "null";
            this.hoTenNLH = "null";
            this.sdtNLH = "null";
            this.matKhau = "null";
            this.chucVu = 0;
        }

        static void Main()
        {

        }
    }
}
