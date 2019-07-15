using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai1
{
    class XuatTuoi
    {
        static void Main(string[] args)
        {
            string name;
            DateTime timeNow;
            Console.Write("Xin moi nhap ten cua ban: ");
            name = Console.ReadLine();
            Console.Write("Nhap ngay thang nam sinh cua ban (yyyy/mm/dd): ");
            timeNow = Convert.ToDateTime(Console.ReadLine());


            /*
            byte dayOfBirth , monthOfBirth;
            int yearOfBirth;
            Console.Write("Nhap ngay sinh cua ban: ");
            dayOfBirth = Convert.ToByte(Console.ReadLine());
            Console.Write("Nhap thang sinh cua ban: ");
            monthOfBirth = Convert.ToByte(Console.ReadLine());
            Console.Write("Nhap nam sinh cua ban: ");
            yearOfBirth = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine("Xin chao " + name);
            */

            int old = DateTime.Now.Year - timeNow.Year;
            Console.WriteLine("Xin chao {0}, nam nay {0} {1} tuoi",name, old);

            Console.ReadKey();

        }
    }
}
