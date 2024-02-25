using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThiTutor
{
    internal class SinhVien
    {
        private string ma;
        private string ten;
        private int tuoi;
        private double diem;

        public SinhVien()
        {

        }
        public SinhVien(string ma, string ten, int tuoi, double diem)
        {
            this.ma = ma;
            this.ten = ten;
            this.tuoi = tuoi;
            this.diem = diem;
        }

        public string Ma { get => ma; set => ma = value; }
        public string Ten { get => ten; set => ten = value; }
        public int Tuoi { get => tuoi; set => tuoi = value; }
        public double Diem { get => diem; set => diem = value; }
        public void InThongTin()
        {
            Console.WriteLine($"{ma} | {Ten} | {Tuoi} | {Diem}");
        }
    }
}
