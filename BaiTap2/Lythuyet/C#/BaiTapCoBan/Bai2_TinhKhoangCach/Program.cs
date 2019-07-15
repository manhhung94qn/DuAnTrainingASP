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
            double khoangCach;
            Console.WriteLine("Nhap he so a, b, c cua phuong trinh ax + by +c = 0");
            Console.Write("a = ");
            a = float.Parse(Console.ReadLine());
            Console.Write("b = ");
            b = float.Parse(Console.ReadLine());
            Console.Write("c = ");
            c = float.Parse(Console.ReadLine());
            Console.WriteLine("Diem M co ");
            Console.Write("xM =  ");
            hoanhDo = float.Parse(Console.ReadLine());
            Console.Write("yM =  ");
            tungDo = float.Parse(Console.ReadLine());
            khoangCach = ( a * hoanhDo + b * tungDo + c)/ ( Math.Sqrt( Math.Pow( a,2) + Math.Pow(b,2) ) );
            Console.WriteLine("Khoang cach tu diem M({0};{1}) den duong" +
                " thang (d): {2}x + {3}y + {4} = 0 la: {5}",hoanhDo, tungDo,a,b,c, khoangCach);


            Console.ReadLine();
        }
    }
}
