using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai7_XepLoaiHocLuc
{
    class Program
    {
        static void Main(string[] args)
        {
            string fullName, learningPower, scorePre;
            float averageScore;
            Console.Write("Nhap ho va ten cua hoc sinh: ");
            fullName = Console.ReadLine();
            Console.Write("Nhap diem trung binh cua hoc sinh: ");
            inputScore:
            scorePre = Console.ReadLine();
            if (!Ft.isNumber(scorePre))
            {
                Console.Write("Vui long nhap diem trung binh la mot so: ");
                goto inputScore;
            }
            averageScore = float.Parse(scorePre);
            if (averageScore > 8.5)
            {
                learningPower = "Gioi";
            }
            else if (averageScore >= 6.5)
            {
                learningPower = "kha";
            }
            else if (averageScore >= 5)
            {
                learningPower = "TB";
            }
            else learningPower = "Yeu";
            Console.WriteLine("Hoc sinh {0} co hoc luc {1}", fullName, learningPower);
            Console.ReadLine();
        }
    }

    class Ft
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
            return true;
        }
    }
}
