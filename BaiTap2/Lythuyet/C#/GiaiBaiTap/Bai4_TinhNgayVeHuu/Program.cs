using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai4_TinhNgayHuu
{
    class Program
    {
        static void Main(string[] args)
        {
            Person person = new Person();
            string myOption;
            Ft.showMenu();
            do
            {
                myOption = Console.ReadLine();
                switch (myOption)
                {
                    case "1":
                        person.setInfo();
                        break;
                    case "2":
                        person.showInfo();
                        break;
                    default:
                        Environment.Exit(-1);
                        break;
                }
                Ft.showMenu();
            } while (Ft.radioButtom(myOption, "12").Length != 0);
            Console.ReadKey();

        }
    }

    class Person
    {
        string fullName;
        DateTime birthday;
        ProcesssDate processsDate = new ProcesssDate();
        bool status = false;

        public string FullName { get => fullName; set => fullName = value; }
        public DateTime Birthday { get => birthday; set => birthday = value; }

        public void setInfo()
        {
            Console.Write("Nhap ho ten: ");
            fullName = Console.ReadLine();
            setBirthday();
            status = true;
            Console.WriteLine("=========================================================================\n");
        }
        public void showInfo()
        {
            if (status)
            {
                Console.WriteLine("Xin chao " + fullName + ", " + fullName + " se ve huu sau " + countDay() + " ngay.");
            }
            else
            {
                Console.WriteLine("Ban chua nhap thong tin, vui long nhap thong tin");
            }
            Console.WriteLine("=========================================================================\n");
        }
        public void setBirthday()
        {
            string cur = processsDate.setDatatimeString();
            birthday = DateTime.Parse(cur);
        }
        public int countDay()
        {
            DateTime x = processsDate.dataOfRetimenter();
            TimeSpan countTime = x - DateTime.Now;
            return countTime.Days;
        }
    }
    public class ProcesssDate
    {
        string dateTimeString;
        string yearString;
        string monthString;
        string dayString;

        public void getYear()
        {
            Console.Write("Nhap nam sinh cua ban: ");
        SetInputYear:
            yearString = Console.ReadLine();
            if (!Ft.isNumber(yearString) || yearString.Length != 4)
            {
                Console.Write("Nam sinh phai la so va co 4 chu so, vui long nhap lai: ");
                goto SetInputYear;
            }
        }
        public void getMonth()
        {
            Console.Write("Nhap thang sinh cua ban: ");
        SetInputMonth:
            monthString = Console.ReadLine();
            if (!Ft.isNumber(monthString))
            {
                Console.Write("Thang sinh la mot so tu 0 den 12, vui long nhap lai: ");
                goto SetInputMonth;
            }
            else if (int.Parse(monthString) > 12 || int.Parse(monthString) < 1)
            {
                Console.Write("Thang sinh la mot so tu 0 den 12, vui long nhap lai: ");
                goto SetInputMonth;
            }
        }
        public void getDay()
        {
            Console.Write("Nhap ngay sinh cua ban: ");
        SetInputDay:
            dayString = Console.ReadLine();
            if (!Ft.isNumber(dayString) || int.Parse(dayString) < 1 || int.Parse(dayString) > DateTime.DaysInMonth(int.Parse(yearString), int.Parse(monthString)))
            {
                Console.Write("Vui long nhap ngay sinh la so tu 1 den " + DateTime.DaysInMonth(int.Parse(yearString), int.Parse(monthString)) + ": ");
                goto SetInputDay;
            }
        }
        public string setDatatimeString()
        {
            getYear(); getMonth(); getDay();
            return dateTimeString = monthString + "/" + dayString + "/" + yearString;
        }
        public DateTime dataOfRetimenter()
        {
            string curY = Convert.ToString(int.Parse(yearString) + 60);
            return DateTime.Parse(monthString + "/" + dayString + "/" + curY);
        }
    } // ham xu ly ngay thang nam

    static class Ft //cac chuc nang phu
    {
        public static void showMenu()
        {
            Console.WriteLine("1:\tNhap thong tin.");
            Console.WriteLine("2:\tTinh so ngay ve huu.");
            Console.WriteLine("Nhan phim khong thuoc chuc nang tren de thoat.");
            Console.Write("Nhap chuc nang trong bang tren: ");
        }
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
        public static string radioButtom(string key, string keyPartent)
        {
            if (key.Length > 1) return "";

            foreach (var item in keyPartent)
            {
                if (item == Convert.ToChar(key))
                {
                    return key;
                }
            }

            return "";
        }

    }

}
