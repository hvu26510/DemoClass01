using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoClass01
{
    internal class SinhVien
    {
        private string hoTen;
        private double diemTB;

        public void nhap()
        {
            Console.WriteLine("Nhap vao ten SV:");
            string name = Console.ReadLine();
            Console.WriteLine("Nhap vao diem TB:");
            double diem = double.Parse(Console.ReadLine());

            this.hoTen = name;
            this.diemTB = diem;
        }

        public void xuat()
        {
            Console.WriteLine("Ho Ten: " + this.hoTen);
            Console.WriteLine("Diem : " + this.diemTB);
        }

        public string xepLoai()
        {
            if(this.diemTB >= 8)
            {
                return "Gioi";
            } else if(this.diemTB >= 6.5)
            {
                return "Kha";
            }else if(this.diemTB >= 5)
            {
                return "tb";
            }
            else
            {
                return "Yeu";
            }
        }

        public SinhVien(string hoTen, double diemTB)
        {
            this.hoTen = hoTen;
            this.diemTB = diemTB;
        }

        public SinhVien()
        {
        }
    }
}
