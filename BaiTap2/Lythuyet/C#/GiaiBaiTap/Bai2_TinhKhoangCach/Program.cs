using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai2_TinhKhoangCach
{
    class Program
    {
        static void Main(string[] args)
        {
            float hoanhDo, tungDo, a, b, c;
            string apr, bpr, cpr, hoanhDoPr, tungDoPr;
            double khoangCach;
            Console.WriteLine("Nhap he so a, b, c cua phuong trinh ax + by +c = 0");
            Console.Write("a = ");
        inputA:
            apr = Console.ReadLine();
            if (!Ft.isNumber(apr))
            {
                Console.Write("Vui long nhap a la mot so: ");
                goto inputA;
            }
            a = float.Parse(apr);
            Console.Write("b = ");
        inputB:
            bpr = Console.ReadLine();
            if (!Ft.isNumber(bpr))
            {
                Console.Write("Vui long nhap b la mot so: ");
                goto inputB;
            }
            b = float.Parse(bpr);
        inputC:
            Console.Write("c = ");
            cpr = Console.ReadLine();
            if (!Ft.isNumber(cpr))
            {
                Console.WriteLine("Vui long nhap c la mot so: ");
                goto inputC;
            }
            c = float.Parse(cpr);
            Console.Write("Diem M co ");
        inputXM:
            Console.Write("xM = ");
            hoanhDoPr = Console.ReadLine();
            if (!Ft.isNumber(hoanhDoPr))
            {
                Console.Write("Vui long nhap hoanh do cua M la mot so: ");
                goto inputXM;
            }
            hoanhDo = float.Parse(hoanhDoPr);

        inputYM:
            Console.Write("yM = ");
            tungDoPr = Console.ReadLine();
            if (!Ft.isNumber(tungDoPr))
            {
                Console.Write("Vui long nhap tung do cua M la mot so: ");
                goto inputYM;
            }
            tungDo = float.Parse(tungDoPr);

            khoangCach = (a * hoanhDo + b * tungDo + c) / (Math.Sqrt(Math.Pow(a, 2) + Math.Pow(b, 2)));
            Console.WriteLine("Khoang cach tu diem M({0};{1}) den duong" +
                " thang (d): {2}x + {3}y + {4} = 0 la: {5}", hoanhDo, tungDo, a, b, c, khoangCach);


            Console.ReadLine();
        }
    }
    class Ft
    {
        public static bool isNumber(string key)
        {
            foreach (var item in key)
            {
                if (!char.IsNumber(item) && char.Parse("-") != item && item != Char.Parse("."))
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
