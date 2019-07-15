using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace Bai12_ChuongTrinhNhapVaoMang
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
        List<int> myArray = new List<int>();
        List<int> b = new List<int>();
        List<int> c = new List<int>();
        List<int> d = new List<int>();
        public void addElement()
        {
            Console.Write("Nhap so can them vao mang: ");
            var inputCurrent = Console.ReadLine();
            if (inputCurrent != "")
            {
                do
                {
                    myArray.Add(Convert.ToInt32(inputCurrent));
                    Console.Write("Nhap so de tiep tuc them, nhan phim bat ki \"KHONG PHAI SO\" de thoat khoi chuc nang nhap so: ");
                    inputCurrent = Console.ReadLine();
                } while (myFutures.isNumber(inputCurrent) && inputCurrent != "");
            }
        }// ham nay dung de them phan tu can them vao mang

        public void putArray()
        {
            foreach (var item in myArray)
            {
                if (item < 0) b.Add(item);
                if (item % 2 == 0) c.Add(item);
                if (item > 10 || item < 1) d.Add(item);
            }
        }
        public void showItem()
        {
            putArray();
            Console.WriteLine("=================================================================================");
            Console.WriteLine("Cac phan tu cua mang b la: ");
            int itemIndexb, itemIndexc, itemIndexd;
            itemIndexb = itemIndexc = itemIndexd = 0;
            foreach (var item in b)
            {
                if (itemIndexb % 5 == 0)
                {
                    Console.WriteLine(); //cai nay de canh cho no cu 5 phan tu thi no se xuong hang cho de nhin thoi
                }
                Console.Write("\t\t" + item);
                itemIndexb++;

            }
            Console.WriteLine("\n=================================================================================");
            Console.WriteLine("Cac phan tu cua mang c la: ");
            foreach (var item in c)
            {
                if (itemIndexc % 5 == 0)
                {
                    Console.WriteLine(); //cai nay de canh cho no cu 5 phan tu thi no se xuong hang cho de nhin thoi
                }
                Console.Write("\t\t" + item);
                itemIndexc++;

            }
            Console.WriteLine("\n=================================================================================");
            Console.WriteLine("Cac phan tu cua mang d la: ");
            foreach (var item in d)
            {
                if (itemIndexd % 5 == 0)
                {
                    Console.WriteLine(); //cai nay de canh cho no cu 5 phan tu thi no se xuong hang cho de nhin thoi
                }
                Console.Write("\t\t" + item);
                itemIndexd++;

            }
            Console.WriteLine("\n=================================================================================");

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
        public static bool isNumber(string str)
        {
            char keyset = Convert.ToChar("-");
            foreach (var item in str)
            {
                if (!char.IsNumber(item) && item != keyset) return false;
            }
            return true;
        }// ham nay dung de kiem tra xem nguoi dung nhap vao co phai la so hay ko
    }
}
