using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai_10_TinhVaXuatThue
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
        double salarySum;
        int countRelationship;
        TinhThue tinhThue = new TinhThue();
        double thuNhapChiuThue;
        public void setInfor()
        {
            Console.Write("Nhap ho ten nguoi dung: ");
            fullname = Console.ReadLine();
            Console.Write("Tong thu nhap hang nam (trieu Dong): ");
            string salarySumPre;
        inputSumSalary:
            salarySumPre = Console.ReadLine();
            if(!Ft.isNumber(salarySumPre))
            {
                Console.Write("Vui long nhap thu nhap ca nhan la so theo don vi Trieu Dong: ");
                goto inputSumSalary;
            }
            salarySum = Double.Parse(salarySumPre);
            Console.Write("Co bao nhieu nguoi phu thuoc: ");
            string countRelationshipPre;
        inputRelationship:
            countRelationshipPre = Console.ReadLine();
            if (!Ft.isNumberINT(countRelationshipPre))
            {
                Console.Write("Vui long nhap vao so nguyen duong: ");
                goto inputRelationship;
            }
            countRelationship = Convert.ToInt32(countRelationshipPre);
            thuNhapChiuThue = tinhThue.setThuNhapChiuThue(salarySum, countRelationship);
        }
        public void showInfor()
        {
            Console.WriteLine("So thue nhap ma " + this.fullname + " phai nop la: " + string.Format("{0:#,0.000, Trieu Dong}", tinhThue.tienThuePhaiNop()));
        }
    }

    class TinhThue
    {
        double thuNhapChiuThue;
        public double setThuNhapChiuThue(double salarySum, int countRelationship)
        {
            return this.thuNhapChiuThue = salarySum - 4 - countRelationship * 16 / 10;
        }
        public double tienThuePhaiNop()
        {
            if (thuNhapChiuThue <= 60)
            {
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

    static class Ft
    {
        public static bool isNumber(string key)
        {
            foreach (var item in key)
            {
                if (!char.IsNumber(item) && item != Char.Parse("."))
                {
                    return false;
                }
            }
            string[] stringToArrayDot = key.Split('.');
            if (stringToArrayDot.Length > 2)
            {
                return false;
            }
            return true;
        }
        public static bool isNumberINT(string key)
        {
            foreach (var item in key)
            {
                if (!char.IsNumber(item))
                {
                    return false;
                }
            }
            return true;
        }
    }

}
