using Sinhvien;
using System;
public class Program 
{
    public static void Main(string[] args)
    {
        int n;
        do
        {
            Console.WriteLine("Nhap so luong sinh vien( sl >= 3):");
            n = Convert.ToInt32(Console.ReadLine());

            if(n < 3)
            {
                Console.WriteLine("So luong sinh vien phai lon hon hoac bang 3, vui long nhap lai!!!");
                continue;
            }

            DanhSachSinhVien dssv = new DanhSachSinhVien();
            for(int i = 0; i < n; i++)
            {
                dssv.themSV();
            }

            Console.WriteLine("Danh sach da nhap:");
            dssv.HienthiDS();
            string x = Console.ReadLine();
            Console.WriteLine($"thong tin sv {x}:");
            dssv.timSVtheoMaSV(x);
            Console.WriteLine("Sinh vien co diem cao nhat:");
            dssv.DiemTBCaoNhat();
        }
        while (true);
        
        Console.ReadKey();
    }
}