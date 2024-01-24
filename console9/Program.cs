using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace console9
{
    internal class Program
    {
        

// Lớp cha DienThoai
       class DienThoai
        {
            public string MaDienThoai { get; set; }
            public string TenDienThoai { get; set; }
            public string ThuongHieu { get; set; }

            // Constructor của lớp DienThoai
            public DienThoai(string maDienThoai, string tenDienThoai, string thuongHieu)
            {
                MaDienThoai = maDienThoai;
                TenDienThoai = tenDienThoai;
                ThuongHieu = thuongHieu;
            }
        }

        // Lớp con DienThoaiChiTiet kế thừa từ DienThoai
        class DienThoaiChiTiet : DienThoai
        {
            public int DungLuong { get; set; }
            public string MauSac { get; set; }
            public int SoLuong { get; set; }
            public decimal GiaTien { get; set; }
            public bool TrangThai { get; set; }

            // Constructor của lớp DienThoaiChiTiet, gọi constructor của lớp cha để khởi tạo các thuộc tính của lớp cha
            public DienThoaiChiTiet(string maDienThoai, string tenDienThoai, string thuongHieu, int dungLuong, string mauSac, int soLuong, decimal giaTien, bool trangThai)
                : base(maDienThoai, tenDienThoai, thuongHieu)
            {
                DungLuong = dungLuong;
                MauSac = mauSac;
                SoLuong = soLuong;
                GiaTien = giaTien;
                TrangThai = trangThai;
            }
        }
            static void Main()
            {
                // Sử dụng lớp DienThoaiChiTiet để tạo một đối tượng điện thoại chi tiết
                DienThoaiChiTiet dienThoaiChiTiet = new DienThoaiChiTiet("DT001", "Smartphone ABC", "Samsung", 64, "Đen", 100, 5000000, true);

                // In thông tin điện thoại chi tiết
                Console.WriteLine($"Mã điện thoại: {dienThoaiChiTiet.MaDienThoai}");
                Console.WriteLine($"Tên điện thoại: {dienThoaiChiTiet.TenDienThoai}");
                Console.WriteLine($"Thương hiệu: {dienThoaiChiTiet.ThuongHieu}");
                Console.WriteLine($"Dung lượng: {dienThoaiChiTiet.DungLuong} GB");
                Console.WriteLine($"Màu sắc: {dienThoaiChiTiet.MauSac}");
                Console.WriteLine($"Số lượng: {dienThoaiChiTiet.SoLuong}");
                Console.WriteLine($"Giá tiền: {dienThoaiChiTiet.GiaTien:C}");
                Console.WriteLine($"Trạng thái kinh doanh: {(dienThoaiChiTiet.TrangThai ? "Đang kinh doanh" : "Ngừng kinh doanh")}");
            }
        }

    }


