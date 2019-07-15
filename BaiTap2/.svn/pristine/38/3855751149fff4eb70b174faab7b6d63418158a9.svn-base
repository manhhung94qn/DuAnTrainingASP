using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai8_TinhTienDiTaxi
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("This is programe count money go by taxi");
            Console.WriteLine("=========================================");

            string fullName;
            float distance, countMoney = 11000;
            Console.Write("Nhap ho va ten khach hang: ");
            fullName = Console.ReadLine();
            Console.Write("Nhap do dai quang duong da di (km): ");
            distance = float.Parse(Console.ReadLine());
            
            if(distance > 1)
            {
                countMoney += (distance - 1) * 9000;
            }
            Console.WriteLine("=========================================");
            Console.WriteLine("Hoa don tien taxi cua khach hang: " + fullName);
            Console.WriteLine("So km da di: " + string.Format("{0:#,0.0, KM}",distance));
            Console.WriteLine("Thanh tien: " + string.Format("{0:#,0.000, VND}",countMoney));
            Console.ReadKey();

        }
    }
}
