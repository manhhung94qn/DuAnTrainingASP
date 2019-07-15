using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai14_QuanLyNhanVien
{
    class Program
    {
        static void Main(string[] args)
        {
            ManageStaff manageStaff = new ManageStaff();
            string myOption;
            ft.showMenu();
            do
            {
                myOption = Console.ReadLine();
                switch (myOption)
                {
                    case "1":
                        manageStaff.addStaff();
                        break;

                    case "2":
                        manageStaff.showInfo(2);
                        break;
                    case "3":
                        manageStaff.showInfo(3);
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
    class ManageStaff
    {
        static List<Staff> staffs = new List<Staff>();
        static List<Staff> staffsMale = new List<Staff>();
        static List<Staff> staffsOld = new List<Staff>();
        public void addStaff()
        {
            Staff newStaff = new Staff();
            Console.Write("Nhap ho ten nhan vien: ");
            newStaff.fullName = Console.ReadLine();
            Console.WriteLine("0:\tNu\n1:\tNam");
            Console.Write("Chon gioi tinh:");
            string inputCurrent;
            bool status = false;
            do
            {
                inputCurrent = Console.ReadLine();
                if (inputCurrent == "0")
                {
                    newStaff.sex = false;
                    status = true;
                }
                else if (inputCurrent == "1")
                {
                    newStaff.sex = true;
                    status = true;
                }
                else
                {
                    Console.Write("Vui long chon 0 neu la nu, chon 1 neu la nam: ");
                }
            } while (!status);
            Console.Write("Nhap ngay sinh: ");
            string currentDay = "";
            bool checkDay = false;
            do
            {
                inputCurrent = Console.ReadLine();
                if (Convert.ToInt16(inputCurrent) < 32 && Convert.ToInt16(inputCurrent) > 0)
                {
                    currentDay += inputCurrent;
                    checkDay = true;
                }
                else { Console.Write("Vui long nhap ngay sinh la mot so tu 1 den 31: "); };
            } while (!checkDay);
            Console.Write("Nhap thang sinh: ");
            bool checkMonth = false;
            do
            {
                inputCurrent = Console.ReadLine();
                if (Convert.ToInt16(inputCurrent) < 13 && Convert.ToInt16(inputCurrent) > 0)
                {
                    currentDay = inputCurrent + "-" + currentDay;
                    checkMonth = true;
                }
                else { Console.Write("Vui long nhap thang sinh la mot so tu 1 den 12: "); };

            } while (!checkMonth);
            Console.Write("Nhap nam sinh: ");
            bool checkYear = false;
            do
            {
                inputCurrent = Console.ReadLine();
                if (inputCurrent.Length == 4 && ft.isNumber(inputCurrent))
                {
                    currentDay = currentDay + "-" + inputCurrent;
                    checkYear = true;
                }
                else { Console.Write("Vui long nhap nam sinh la mot so co 4 chu so: "); };

            } while (!checkYear);
            newStaff.birthday = Convert.ToDateTime(currentDay);
            Console.Write("Nhap muc luong nhan vien: ");
            inputCurrent = Console.ReadLine();
            do
            {
                if (ft.isNumber(inputCurrent))
                {
                    newStaff.salary = Convert.ToInt32(inputCurrent);
                }
                else
                {
                    Console.Write("Vui long nhap so: ");
                    inputCurrent = Console.ReadLine();
                }
            } while (!ft.isNumber(inputCurrent));
            staffs.Add(newStaff);
            if (newStaff.sex)
            {
                staffsMale.Add(newStaff);
            }
            if (DateTime.Now.Year - newStaff.birthday.Year > 20 && DateTime.Now.Year - newStaff.birthday.Year < 40)
            {
                staffsOld.Add(newStaff);
            }
            Console.WriteLine(newStaff.fullName + " da duoc them vao mang");
        }

        public List<Staff> setStaffMale()
        {

            return staffsMale;
        }
        public void showInfo(int option)
        {
            Console.WriteLine("\n==================================================================");
            switch (option)
            {
                case 2:
                    Console.WriteLine("Danh sach nhan vien nam trong cong ty ban");
                    Console.WriteLine("STT\tHo va Ten\tNgay Sinh\tMuc Luong");
                    int index2 = 1;
                    foreach (var item in staffsMale)
                    {
                        Console.WriteLine(index2 + "\t" + item.fullName + "\t" + item.birthday.ToShortDateString() + "\t" + item.salary);
                        index2++;
                    }
                    break;

                case 3:
                    Console.WriteLine("Danh sach nhan vien co tuoi tu 20 den 40");
                    Console.WriteLine("STT\tHo va Ten\tNgay Sinh\tMuc Luong");
                    int index3 = 1;
                    foreach (var item in staffsOld)
                    {
                        Console.WriteLine(index3 + "\t" + item.fullName + "\t" + item.birthday.ToShortTimeString() + "\t" + item.salary);
                        index3++;
                    }
                    break;

                default:
                    break;
            }
            Console.WriteLine("==================================================================\n");
        }
    }
    class Staff
    {
        internal string fullName;
        internal bool sex;
        internal DateTime birthday;
        internal int salary;
    }

    static class ft //cac chuc nang phu
    {
        public static void showMenu()
        {
            Console.WriteLine("1:\tThem nhan vien vao danh sach.");
            Console.WriteLine("2:\tXuat thong tin cac nhan vien nam.");
            Console.WriteLine("3:\tXuat thong tin cac nhan vien co tuoi tu 20 den 40.");
            Console.WriteLine("Nhan phim bat ki \"KHONG THUOC\" cac chuc nang tren de thoat");
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
