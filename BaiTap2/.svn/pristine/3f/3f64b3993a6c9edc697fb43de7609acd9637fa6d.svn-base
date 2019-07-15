using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace Bai13_NhapXuatHoaDon
{
    class Program
    {
        static void Main(string[] args)
        {
            Manage manage = new Manage();
            string myOption;
            do
            {
                ft.showMenu();
                myOption = Console.ReadLine();
                switch (myOption)
                {
                    case "1":
                        manage.addProduct();
                        break;
                    case "2":
                        manage.showInfo();
                        break;
                    default:
                        System.Environment.Exit(-1);
                        break;
                }
            } while (myOption != "0");
        }
    }
    class Manage
    {
        static List<Product> Products = new List<Product>();
        public void addProduct()
        {
            Product newProduct = new Product();
            Console.Write("Nhap ten san pham: ");
            newProduct.name = Console.ReadLine();
            bool status;
            Console.Write("Nhap gia san pham: ");
            do
            {
                string cur = Console.ReadLine();
                if (ft.isNumber(cur))
                {
                    newProduct.price = Convert.ToInt32(cur);
                    status = true;
                }
                else
                {
                    status = false;
                    Console.Write("Vui long nhap so: ");
                };

            } while (!status);
            Console.Write("Nhap so luong san pham: ");
            do
            {
                string cur = Console.ReadLine();
                if (ft.isNumber(cur))
                {
                    newProduct.quality = Convert.ToInt32(cur);
                    status = true;
                }
                else
                {
                    status = false;
                    Console.Write("Vui long nhap so: ");
                };

            } while (!status);
            Products.Add(newProduct);
            Console.WriteLine("San pham {0} da duoc them vao danh sach", newProduct.name);
            Console.WriteLine("=================================================================");
        }
        public float DGTB(int opt)
        {
            int sumItem = 0;
            float sumPrice = 0;
            foreach (var item in Products)
            {
                sumItem += item.quality;
                sumPrice += item.price * item.quality;
            }
            if (opt == 0)
            {
                return sumPrice;
            }
            return sumPrice / sumItem;
        }
        public void showInfo()
        {
            Console.WriteLine("============= Hoa Don Cua Ban =============\n");
            Console.Write("STT\tName\tSo Luong\tGia\tThanh Tien\n");
            int index = 1;
            foreach (var item in Products)
            {
                Console.WriteLine("{0}\t{1}\t{2}\t\t{3}\t{4}", index, item.name, item.quality, item.price, item.price * item.quality);
                index++;
            }
            Console.WriteLine("\n________________________________________________");
            Console.WriteLine(index++ + "\tDGTB:\t\t\t\t" + DGTB(1));
            Console.WriteLine(index++ + "\tThanh tien: \t\t\t" + DGTB(0));
            Console.WriteLine("\n================================================");
        }

    }
    class Product
    {
        public string name;
        public float price;
        public int quality;

    }

    static class ft //future cac tien ich
    {

        public static void showMenu()
        {
            Console.WriteLine("1:\tThem mat hang vao danh sach");
            Console.WriteLine("2:\tXuat hoa don");
            Console.WriteLine("Nhan phim bat ki khong la chuc nang tren de thoat");
            Console.Write("Chon chuc nang phia tren: ");

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


    }


}
