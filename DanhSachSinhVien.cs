namespace Sinhvien
{
    public class DanhSachSinhVien
    {
        private List<SinhVien> list = new List<SinhVien>();

        public void themSV()
        {
            SinhVien sv = new SinhVien("", "", 0);
            sv.NhapThongTin();
            list.Add(sv);
            Console.WriteLine("Thêm thành công!");
        }
        public void HienthiDS()
        {
            foreach (SinhVien sv in list) 
            {
                sv.HienThiTT();
            }
        }
        public void timSVtheoMaSV(string x)
        {
            bool check = false;
        
            foreach (var sv in list)
            {
                if(x == sv.MaSV)
                {
                    check = true;
                    sv.HienThiTT();
                    
                }  
            }
            if (!check)
            {
                Console.WriteLine("Not found it!");
            }
        }
        public SinhVien DiemTBCaoNhat()
        {
            if(list.Count == 0)
            {
                return null;
            }    
            SinhVien svMax = list[0];
            foreach (var sv in list)
            {
                if(svMax.DiemTB < sv.DiemTB)
                {
                    svMax = sv;
                }    
            }
            svMax.HienThiTT();
            return svMax;
        }
    }
}
