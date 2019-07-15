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
            string fullName, learningPower;
            float averageScore;
            Console.Write("Nhap ho va ten cua hoc sinh: ");
            fullName = Console.ReadLine();
            Console.WriteLine(fullName);
            Console.Write("Nhap diem trung binh cua hoc sinh: ");
            averageScore = float.Parse(Console.ReadLine());
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
}
