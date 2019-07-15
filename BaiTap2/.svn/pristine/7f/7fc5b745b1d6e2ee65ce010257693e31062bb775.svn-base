using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai_10_TinhVaXuatThe
{
    class Program
    {
        static void Main(string[] args)
        {
            string status;
            do
            {
                Person person = new Person();
                person.setInfor();
                person.showInfor();
                Console.WriteLine("\n================================================\n");
                Console.Write("Nhan phim 1 de tinh lai, nhan phim bat ki de thoa chuong trinh: ");
                status = Console.ReadLine();
                Console.WriteLine("\n================================================\n");
            } while (status == "1");         

        }
    }
    class Person
    {
        string fullname;
        int salarySum;
        int countRelationship;
        TinhThue tinhThue = new TinhThue();
        double thuNhapChiuThue;
        public void setInfor()
        {
            Console.Write("Nhap ho ten nguoi dung: ");
            fullname = Console.ReadLine();
            Console.Write("Tong thu nhap hang nam (trieu Dong): ");
            salarySum = Convert.ToInt32(Console.ReadLine());
            Console.Write("Co bao nhieu nguoi phu thuoc: ");
            countRelationship = Convert.ToInt32( Console.ReadLine() );
            thuNhapChiuThue = tinhThue.setThuNhapChiuThue(salarySum, countRelationship);
        }
        public void showInfor()
        {
            Console.WriteLine("So thu  nhap ma " + this.fullname + " phai nop la: " + string.Format("{0:#,0.000, Trieu Dong}" , tinhThue.tienThuePhaiNop())  );
        }
    }

    class TinhThue
    {
        float thuNhapChiuThue;
        public float setThuNhapChiuThue(int salarySum, int countRelationship)
        {
            return this.thuNhapChiuThue = salarySum - 4 - countRelationship * 16 / 10;
        }
        public float tienThuePhaiNop ()
        {
            if (thuNhapChiuThue <= 60) {
                return thuNhapChiuThue * 5 / 100;
            };
            if (thuNhapChiuThue <= 120)
            {
                return thuNhapChiuThue * 10 / 100;
            };
            if (thuNhapChiuThue <= 216)
            {
                return thuNhapChiuThue * 15 / 100;
            };
            if (thuNhapChiuThue <= 384)
            {
                return thuNhapChiuThue * 20 / 100;
            };
            if (thuNhapChiuThue <= 624)
            {
                return thuNhapChiuThue * 25 / 100;
            };
            if (thuNhapChiuThue <= 960)
            {
                return thuNhapChiuThue * 30 / 100;
            };
            return thuNhapChiuThue * 35 / 100;
        }
    }
}
