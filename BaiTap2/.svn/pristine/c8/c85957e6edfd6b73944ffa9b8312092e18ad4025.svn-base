using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai5_XuatSoDauTienVaCuoiCung
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Programe print the first and the last of number");
            Console.WriteLine("================================================");
            object inputNumber;
            Console.Write("Nhap mot so co ba chu so: ");
            inputNumber = Console.ReadLine();
            checkInput checkInputNumber = new checkInput();
            bool status = checkInputNumber.checkLength(inputNumber, 3) && checkInputNumber.isNumber(inputNumber);
            while (!status)
            {
                Console.Write("Ki tu ban nhap vao khong hop le, vui long nhap vao so co 3 chu so: ");
                inputNumber = Console.ReadLine();
                status = checkInputNumber.checkLength(inputNumber, 3) && checkInputNumber.isNumber(inputNumber);
            }

            Console.WriteLine("So dau tien cua so ban nhap la: " + Convert.ToString(inputNumber)[0]);
            Console.WriteLine("So dau tien cua so ban nhap la: " + Convert.ToString(inputNumber)[2]);
            Console.ReadKey();
        }
    }


    // lớp này dùng để kiểm tra xem kết quả người dùng nhập vào có phải là định dạng bạn mong muốn hay ko
    class checkInput
    {
        object val;

        // tạo hàm check thử kí tự nhập vào có phải là số hay ko,
        public bool isNumber(object _val)
        {
            this.val = _val;
            bool valid = true;
            do
            {
                foreach (char ch in Convert.ToString(val))
                {
                    if (!char.IsNumber(ch))
                    {
                        return valid = false;
                    }
                }
            } while (!valid);
            return valid;
        }
        public bool checkLength(object _val, int le)
        {
            this.val = _val;
            int lenghtInputNumber = Convert.ToString(val).Length;
            if (lenghtInputNumber != le)
            {
                return false;
            }
            return true;
        }

    }

}
