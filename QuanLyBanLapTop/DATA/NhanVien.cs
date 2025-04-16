using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyBanLapTop.DATA
{
    class NhanVien
    {
        public int ID { get; set; }
        public string HoVaTen { get; set; } = null!;
        public string? DienThoai { get; set; }
        public string? DiaChi { get; set; }
        public string TenDangNhap { get; set; } = null!;
        public string MatKhau { get; set; } = null!;
        public string QuyenHan { get; set; } = null!; // admin, user
        public virtual ICollection<HoaDon> HoaDon { get; } = new List<HoaDon>();
    }
}
