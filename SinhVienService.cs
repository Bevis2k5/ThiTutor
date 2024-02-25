using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThiTutor
{
    internal class SinhVienService
    {
        List<SinhVien> lstSinhVien;
        string input;
        public SinhVienService()
        {
            lstSinhVien = new List<SinhVien>();
            SinhVien nct = new SinhVien("1", "A",  2005, 2);
            lstSinhVien.Add(nct);
        }
        public void Nhap()
        {
            do
            {
                SinhVien sinhVien = new SinhVien();
                Console.Write("Mời nhập mã sinh viên: ");
                sinhVien.Ma = Console.ReadLine();
                Console.Write("Mời bạn nhập tên sinh viên: ");
                sinhVien.Ten = Console.ReadLine();
                Console.Write("Mời bạn nhập năm sinh của sinh viên: ");
                sinhVien.Tuoi = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Mời bạn nhập điểm của sinh viên: ");
                sinhVien.Diem = Convert.ToInt32(Console.ReadLine());
                lstSinhVien.Add(sinhVien);
                Console.Write("Bạn có muốn nhập tiếp không ?");
                input = Console.ReadLine();
            } while (input == "Y" || input == "y");
        }
        private bool CheckCount()
        {
            if (lstSinhVien.Count == 0)
            {
                return true;
            }
            return false;
        }
        public void Xuat()
        {
            if (CheckCount())
            {
                Console.WriteLine("Chưa có dữ liệu sinh viên nhập vào");
                return;
            }
            foreach (var item in lstSinhVien)
            {
                item.InThongTin();
            }
        }
        public void DiemSinhVien()
        {
            if (CheckCount())
            {
                Console.WriteLine("Chưa có điểm nhập vào ");
                return;
            }
            bool isExist = false;
            foreach (var sinh in lstSinhVien)
            {
                if (sinh.Diem >= 8)
                {
                    sinh.InThongTin();
                    isExist = true;
                }
            }
            if (!isExist)
            {
                Console.WriteLine("Không có sinh viên nào >=8");
            }
        }
        public void KeThua()
        {
            List<SinhVienUD> LstVienUD = new List<SinhVienUD>()
            {
                new SinhVienUD("1", "A", 15, 7, 2),
            };
            foreach (var sinh in lstSinhVien)
            {
                sinh.InThongTin();
            }
        }
        public void XoaDSSinhVienKCoVeHappyBee()
        {
            List<SinhVien> sinhVienCanXoa = new List<SinhVien>();

            foreach (var sv in lstSinhVien)
            {
                if (sv.Diem < 8 || sv.Tuoi < DateTime.Now.Year - 25)
                {
                    sinhVienCanXoa.Add(sv);
                }
            }

            foreach (var sv in sinhVienCanXoa)
            {
                lstSinhVien.Remove(sv);
                Console.WriteLine("Đã xóa thành công sinh viên:");
                sv.InThongTin();
                break;
            }
        }
    }
}
