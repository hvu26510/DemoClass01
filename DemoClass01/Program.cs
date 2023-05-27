using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoClass01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            SinhVien sv1 = new SinhVien();

            sv1.nhap();
            sv1.xuat();
            string hl = sv1.xepLoai();
            Console.WriteLine(hl);
            Console.ReadLine();
        }
    }

    //public class HinhTron
    //{
    //    private int bankinh;

    //    public int DuongKinh()
    //    {
    //        return bankinh * 2;
    //    }

    //} 
}
