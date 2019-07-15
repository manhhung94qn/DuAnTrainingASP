using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai6_TinhTienGiamGia
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("");
            ManageProduce manageProduce = new ManageProduce();
            manageProduce.addInfoProduce();
            manageProduce.showInfo();
            Console.ReadKey();
        }
    }

    class ManageProduce
    {
        string name;
        int quality;
        float price;
        public void addInfoProduce()
        {
            Console.Write("Nhap ten san pham: ");
            this.name = Console.ReadLine();
            Console.Write("Nhap so luong san pham: ");
            string qualityPre;
        inputQuality:
            qualityPre = Console.ReadLine();
            if (!Ft.isNumberINT(qualityPre))
            {
                Console.Write("So luong phai la mot so nguyen duong, vui long nhap lai: ");
                goto inputQuality;
            }
            quality = int.Parse(qualityPre);
            string pricePre;
            Console.Write("Nhap gia san pham: ");
        inputPrice:
            pricePre = Console.ReadLine();
            if (!Ft.isNumber(pricePre))
            {
                Console.Write("Vui long nhap gia la mot so: ");
                goto inputPrice;
            }
            price = float.Parse(pricePre);
        }
        public double caculatorRank()
        {
            double rankVip = quality / 50;
            switch (Math.Floor(rankVip))
            {
                case 0:
                    return 1;
                case 1:
                    return 0.92;
                default:
                    return 0.88;
            }
        }
        public double caculatorMoney()
        {
            return this.quality * this.price * this.caculatorRank();
        }
        public void showInfo()
        {
            Console.WriteLine("======================HOA DON THANH TOAN======================");
            Console.WriteLine("Ten San Pham \tSo Luong \tDon Gia \tHe So Thanh Toan \tThanh Tien");
            Console.WriteLine("{0}\t\t{1}\t\t{2}\t\t{3}\t\t\t{4}",this.name,this.quality,this.price,this.caculatorRank() ,this.caculatorMoney());
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
