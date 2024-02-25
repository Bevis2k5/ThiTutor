using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThiTutor
{
    internal class SinhVienUD
    {
        private int kiHoc;

        public SinhVienUD()
        {

        }

        public SinhVienUD(string ma, string ten, int tuoi, double diem, int kiHoc)
        {
            this.kiHoc = kiHoc;
        }

        public int KiHoc { get => kiHoc; set => kiHoc = value; }
        public void InThongTin()
        {
            Console.WriteLine($"{kiHoc}");
        }
    }
}

