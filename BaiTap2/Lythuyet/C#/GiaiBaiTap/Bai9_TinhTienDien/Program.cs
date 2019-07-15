using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai9_TinhTienDien
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("====================Chuong trinh tinh tien dien====================");
            Customer customer = new Customer();
            startPoint:
            customer.getInfo();
            customer.showInfo();
            string myOption;
            Console.Write("Nhan Exit de thoat chuong trinh, nhan phim bat ki khac Exit de thuc hien lai: ");
            myOption = Console.ReadLine();
            if(myOption.ToLower() != "exit")
            {
                goto startPoint;
            }
        }
    }
    class Customer
    {
        string name;
        double kwInMonth;
        public void getInfo()
        {
            Console.Write("Nhap ho ten khach hang: ");
            this.name = Console.ReadLine();
            Console.Write("Nhap so kw da dung trong thang: ");
            string kwInMonthPre;
        inputKwInMonth:
            kwInMonthPre = Console.ReadLine();
            if (!Ft.isNumber(kwInMonthPre))
            {
                Console.Write("Vui long nhap so: ");
                goto inputKwInMonth;
            }
            this.kwInMonth = Double.Parse(kwInMonthPre);
        }
        public double countMoney()
        {
            double rankPrice = kwInMonth / 50;
            switch (Math.Floor(rankPrice)){
                case 0:
                    return 500 * kwInMonth;
                case 1:
                    return 500 * 50 + 650*(kwInMonth - 50);
                case 2:
                case 3:
                    return 500 * 50 + 650 * 50 + 850*(kwInMonth - 100);
                case 4:
                case 5:
                case 6:
                    return 500 * 50 + 650 * 50 + 850 * 100 + 1100 * (kwInMonth - 200);
                default:
                    return 500 * 50 + 650 * 50 + 850 * 100 + 1100 * 150 + (kwInMonth - 350)*1300;
                    
            }
        }
        public void showInfo()
        {
            Console.WriteLine("========================Hoa Don Tien Dien=====================");
            Console.WriteLine("Ten Khach Hang \t So Kw \t Thanh Tien");
            Console.WriteLine("{0} \t {1} \t{2}",this.name,this.kwInMonth, this.countMoney());
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
            string[] stringToArrayHor = key.Split('-');
            if (stringToArrayDot.Length > 2 || stringToArrayHor.Length > 2)
            {
                return false;
            }
            return true;
        }
    }
}
