using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace Bai11_MangSoNguyen
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("===============Chuong trinh nhap va tinh tong cac so nguyen trong mang==========================");
            ManageArray manageArray = new ManageArray();
            string myOption;
            myFutures.showMenu(out myOption);
            while (myFutures.checkOption(myOption))
            {
                switch (myOption)
                {
                    case "1":
                        manageArray.addElement();
                        myFutures.showMenu(out myOption);
                        break;
                    case "2":
                        manageArray.showItem();
                        myFutures.showMenu(out myOption);
                        break;
                    default:
                        Environment.Exit(0);
                        break;
                }
            }
        }
    }
    class ManageArray
    {
        static List<int> myArray = new List<int>();
        public void addElement()
        {
            Console.Write("Nhap so can them vao mang: ");
            string inputCurrent;
            do
            {
            inputCurrentPoint:
                inputCurrent = Console.ReadLine();
                if (!myFutures.isNumber(inputCurrent))
                {
                    Console.Write("Vui long nhap vao so nguyen: ");
                    goto inputCurrentPoint;
                }
            checkInput:
                myArray.Add(Convert.ToInt32(inputCurrent));
                Console.Write("Nhap so de tiep tuc them, nhap phim \"KHONG PHAI SO\" de thoat chuong trinh: ");
                inputCurrent = Console.ReadLine();
                if (myFutures.isNumber(inputCurrent))
                {
                    goto checkInput;
                }

            } while (myFutures.isNumber(inputCurrent) && inputCurrent != "");
        }// ham nay dung de them phan tu can them vao mang

        public void showItem()
        {
            Console.WriteLine("=================================================================================");
            if(myArray.Count == 0)
            {
                Console.WriteLine("Ban chua nhap so nao, vui long nhap so");
                this.addElement();
                return;
            }
            Console.WriteLine("Tong cac so trong mang tren la: " + myArray.Sum());
            Console.WriteLine("So lon nhat trong mang tren la: " + myArray.Max());
            void howMany()
            {
                int countNumber = 0;
                foreach (var item in myArray)
                {
                    if (item >= 0)
                    {
                        countNumber += 1;
                    }
                }
                Console.WriteLine("Mang tren co: {0} so lon hon 0.", countNumber);
            }
            howMany();
            Console.WriteLine("=================================================================================");

        }// ham nay dung de hien thi ket qua thong tin ra man hinh
    }
    static class myFutures
    {
        public static bool checkOption(string key)
        {

            if (key != "")
            {
                char newkey = Convert.ToChar(key);
                string myOption = "12";
                foreach (var item in myOption)
                {
                    if (item == newkey)
                    {
                        return true;
                    }
                }
            }
            return false;
        } // ham nay dung de kiem tra xem nguoi dung co chon nhung chuc nang da duoc goi y hay ko
        public static string showMenu(out string myOption)
        {
            Console.WriteLine("1: \tNhap them so vao mang.");
            Console.WriteLine("2: \tHien thi thong tin.");
            Console.WriteLine("0: \tThoat chuong trinh.");
            Console.Write("Chon chuc nang tuong ung trong bang tren: ");
            return myOption = Console.ReadLine();
        } //ham nay dung de hien thi menu cho nguoi dung chon chuc nang
        public static bool isNumber(string key)
        {
            foreach (var item in key)
            {
                if (!char.IsNumber(item) && item != char.Parse("-") )
                {
                    return false;
                }
            }
            string[] stringToArrayDot = key.Split('-');
            if (stringToArrayDot.Length > 2)
            {
                return false;
            }
            return true;
        }
    }

    static class Ft
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
            string[] stringToArrayDot = key.Split('.');
            if (stringToArrayDot.Length > 2)
            {
                return false;
            }
            return true;
        }
        public static bool isNumberINT(string key)
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
