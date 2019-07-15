using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai3_PhanSo
{
    class Program
    {
        static void Main(string[] args)
        {
            ProcessFract processFract = new ProcessFract();
            string myOption;
            ft.showMenu();
            do
            {
                myOption = Console.ReadLine();
                switch (myOption)
                {
                    case "1":
                        processFract.setFract(processFract.Fract1);
                        break;
                    case "2":
                        processFract.setFract(processFract.Fract2);
                        break;
                    case "3":
                        processFract.showInfor();
                        break;
                    default:
                        Environment.Exit(-1);
                        break;
                }
                ft.showMenu();
            } while (ft.radioButtom(myOption, "123").Length != 0);
            Console.ReadKey();
        }
    }

    class ProcessFract
    {
        Fract fract = new Fract();
        Fract fract1 = new Fract();
        Fract fract2 = new Fract();

        internal Fract Fract1 { get => fract1; set => fract1 = value; }
        internal Fract Fract2 { get => fract2; set => fract2 = value; }

        public void setFract(Fract opt)
        {
            Console.Write("Nhap tu so: ");
            string cur;
            bool status;
            do
            {
                cur = Console.ReadLine();
                if (ft.isNumber(cur))
                {
                    opt.Element = int.Parse(cur);
                    status = true;
                }
                else
                {
                    Console.Write("Vui long nhap vao so: ");
                    status = false;
                }
            } while (!status);
            Console.Write("Nhap mau so (mau so phai khac 0): ");
            do
            {
                cur = Console.ReadLine();
                if (ft.isNumber(cur) && int.Parse(cur) != 0)
                {
                    opt.Sample = int.Parse(cur);
                    status = true;
                }
                else
                {
                    Console.Write("Vui long nhap vao so va khac 0: ");
                    status = false;
                }
            } while (!status);
            Console.WriteLine("Ban da luu phan so: {0}/{1} vao bo nho.", opt.Element, opt.Sample);
            Console.WriteLine("========================================================================\n");
        }

        public Fract compactFract(Fract opt)
        {
            if (opt.Element == 0)
            {
                return opt;
            }
            if (opt.Element == opt.Sample)
            {
                opt.Element = 1; opt.Sample = 1;
                return opt;
            }
        FindCom:
            if (getDivesor(opt.Element, opt.Sample) != 1)
            {
                int commonDevisor = getDivesor(opt.Element, opt.Sample);
                opt.Element = opt.Element / commonDevisor;
                opt.Sample = opt.Sample / commonDevisor;
            }
            if (getDivesor(opt.Element, opt.Sample) != 1)
            {
                goto FindCom;
            }
            return opt;
        }

        public void showInfor()
        {
            fract.Element = Fract1.Element * Fract2.Element;
            fract.Sample = Fract1.Sample * Fract2.Sample;
            Console.WriteLine("========================================================================");
            if (fract.Element == 0)
            {
                Console.WriteLine("\nTich hai phan so " + Fract1.Element + "/" + Fract1.Sample + " va " + Fract2.Element + "/" + Fract2.Sample + " bang 0");
            }
            else
            {
                compactFract(fract);
                Console.WriteLine("\nTich hai phan so " + Fract1.Element + "/" + Fract1.Sample + " va " + Fract2.Element + "/" + Fract2.Sample + " bang " + fract.Element + "/" + fract.Sample);
            }
            Console.WriteLine("\n========================================================================\n");
        }

        public int getMin(int opt1, int opt2)
        {
            return Math.Min(Math.Abs(opt1), Math.Abs(opt2));
        }
        public int getDivesor(int opt1, int opt2)
        {
            for (int i = 2; i < getMin(opt1, opt2) + 1; i++)
            {
                if (opt1 % i == 0 && opt2 % i == 0)
                {
                    return i;
                }
            }
            return 1;
        }

    }
    class Fract
    {
        int element;
        int sample;

        public int Element { get => element; set => element = value; }
        public int Sample { get => sample; set => sample = value; }
    }
    static class ft //cac chuc nang phu
    {
        public static void showMenu()
        {
            Console.WriteLine("1:\tNhap phan so thu nhat.");
            Console.WriteLine("2:\tNhap phan so thu hai.");
            Console.WriteLine("3:\tTinh tich hai phan so.");
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

