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
            Console.Write("Nhap ngay thang nam sinh cua ban (dd/mm/yyyy): ");
        inputDate:
            string stringDate = Console.ReadLine();
            string[] stringArrayDate = stringDate.Split('/');
            if (stringArrayDate.Length != 3)
            {
                Console.Write("Nhap ngay thang nam phai dung dinh dang dd/mm/yyyy: ");
                goto inputDate;
            }
            if (!Ft.isNumber(stringArrayDate[0]) || !Ft.isNumber(stringArrayDate[1]) || !Ft.isNumber(stringArrayDate[2]))
            {
                Console.Write("Nhap ngay thang nam phai dung dinh dang dd/mm/yyyy, trong do d,m,y la cac so: ");
                goto inputDate;
            }
            int dayInMonth = DateTime.DaysInMonth(int.Parse(stringArrayDate[2]), int.Parse(stringArrayDate[1]));
            if (int.Parse(stringArrayDate[1]) > 13 || int.Parse(stringArrayDate[1]) < 1 || stringArrayDate[2].Length != 4)
            {
                Console.Write("Ngay thang ban nhap vao khong hop le, vui long nhap lai: ");
                goto inputDate;
            }
            if (int.Parse(stringArrayDate[0]) > dayInMonth)
            {
                Console.WriteLine("Thang {0} cua nam {1} chi co {2} ngay. Vui long nhap du lieu dung dinh dang dd/mm/yyyy", stringArrayDate[1], stringArrayDate[2], dayInMonth);
            }
            DateTime birthday = DateTime.Parse(stringArrayDate[1] + "/" + stringArrayDate[0] + "/" + stringArrayDate[2]);
            Console.WriteLine("Xin chao {0}, nam nay ban {1} tuoi.", name, DateTime.Now.Year - birthday.Year);
            Console.ReadKey();

        }
    }

    class Ft
    {
        public static bool isNumber(string key)
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
