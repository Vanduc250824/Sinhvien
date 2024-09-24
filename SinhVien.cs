using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sinhvien
{
    public class SinhVien
    {
        public string MaSV { get; set; }
        public string HoTen { get; set; }
        public double DiemTB { get; set; }


        public SinhVien(string maSV, string hoTen, double diemTB)
        {
            this.MaSV = maSV;
            this.HoTen = hoTen;
            this.DiemTB = diemTB;
        }

        public void NhapThongTin()
        {
            Console.WriteLine("Ma sinh vien:");
            this.MaSV = Console.ReadLine();
            Console.WriteLine("Ho ten: ");
            this.HoTen = Console.ReadLine();
            Console.WriteLine("Diem trung binh:");
            DiemTB = Convert.ToDouble(Console.ReadLine());
        }
        public void HienThiTT()
        {
            Console.WriteLine($"Ma sinh vien: {this.MaSV},  Ten: {this.HoTen}, Diem trung binh: {this.DiemTB:F2}");
        }
        public double diemTB()
        {
            return this.DiemTB;
        }
        public string LayMaSv()
        {
            return this.MaSV;
        }
    }

}
