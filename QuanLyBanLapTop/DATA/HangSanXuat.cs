using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyBanLapTop.DATA
{
    class HangSanXuat
    {
        public int ID { get; set; }
        public string? TenHangSanXuat { get; set; }
        public string? DiaChi { get; set; }
        // Navigation property
        public virtual ICollection<SanPham> SanPham { get; set; } = new HashSet<SanPham>();
    }
}
