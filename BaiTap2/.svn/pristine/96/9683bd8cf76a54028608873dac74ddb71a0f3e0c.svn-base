using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai9_TinhSoTienDien
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Programe export Bill");
            Console.WriteLine("===============================================");

            string fullName;
            float countKW, countMoney;
            Console.Write("Nhap ho ten khach hang: ");
            fullName = Console.ReadLine();
            Console.Write("Nhap so KW da tieu thu trong thang: ");
            countKW = float.Parse(Console.ReadLine());
            
            if(countKW <= 50)
            {
                countMoney = countKW * 500;
            } else if(countKW <= 100 && countKW >50)
            {
                countMoney = 50 * 500 + (countKW - 50) * 650;
            } else if(countKW <= 150 && countKW >100)
            {
                countMoney = 50 * 500 + 50*650 + (countKW - 100) * 850;
            } else countMoney = 50 * 500 + 50 * 650 + 50 * 850 + (countKW - 150)*1300;

            Console.Write("Tien dien cua " + fullName + " la: " + string.Format( "{0:#,0.00, VND}" ,countMoney ));

            Console.ReadKey();



        }
    }
}
