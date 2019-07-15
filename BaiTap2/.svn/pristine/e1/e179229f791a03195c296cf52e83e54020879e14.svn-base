using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bai4_TinhNgayVeHuu
{
    class ProcessInfo: Form
    {
        DMY birthday = new DMY(); //Biến này sẽ lưu trữ giá trị ngày sinh của ai đó
        public string getName(TextBox text, Panel panel)  // hàm này dùng để hiển thi thông tin ra ngoài thông báo chào ai đó
        {
            string wel = "Xin chào ";
            if( getSex(panel) != "")
            {
                switch (getSex(panel))
                {
                    case "Nam":
                        wel += "ông: " + text.Text;
                        break;
                    case "Nữ":
                        wel += "bà: " + text.Text;
                        break;
                }
            }
            return wel;
        }
        public string getCountDay(DateTimePicker dateTime, Panel panel)  // Hàm này dùng để hiển thị số ngày sẽ về hưu
        {
            setBirthday(dateTime);
            int countday = countDay(panel);
            string count = "";
            if (countDay(panel) <= 0)
            {
                if (getSex(panel) != "")
                {
                    switch (getSex(panel))
                    {
                        case "Nam":
                            count += "Ông đã về hưu được: " + Convert.ToString(Math.Abs(countday));
                            break;
                        case "Nữ":
                            count += "Bà đã về hưu được: " + Convert.ToString(Math.Abs(countday));
                            break;
                    }
                }
                return count;
            }
            if (getSex(panel) != "")
            {
                switch (getSex(panel))
                {
                    case "Nam":
                        count += "Ông sẽ về hưu sau: " + Convert.ToString(countday) + " ngày nữa";
                        break;
                    case "Nữ":
                        count += "Bà sẽ về hưu sau: " + Convert.ToString(countday) + " ngày nữa";
                        break;
                }
            }
            return count;
        }
       
        public string getSex(Panel panel) // Hàm này dùng để xác định giới tính, được dùng để kiểm tra cách xưng hô.
        {
            string sex = "";
            foreach (RadioButton item in panel.Controls)
            {
                if (item.Checked)
                {
                    sex = item.Text;
                    return sex;
                }
            }
            return sex;
        }
        public void setBirthday(DateTimePicker dateTime)  // Hàm này dùng để gán giá trị ngày tháng sinh nhận được từ select datePicker
        {
            string birts = Convert.ToDateTime(dateTime.Text).ToShortDateString();
            string[] birtar = birts.Split('/');
            birthday.Yyyy = Convert.ToInt16(birtar[2]);
            birthday.Mm = Convert.ToInt16(birtar[0]);
            birthday.Dd = Convert.ToInt16(birtar[1]);
        }
        public int countDay(Panel panel)  // Hàm này dùng để tính số ngày sẽ về hưu
        {
            string affter60Y ="";

            if (getSex(panel) != "")
            {
                switch (getSex(panel))
                {
                    case "Nam":
                        affter60Y = Convert.ToString(birthday.Mm) + "/" + Convert.ToString(birthday.Dd) + "/" + Convert.ToString(birthday.Yyyy + 60);
                        break;
                    case "Nữ":
                        affter60Y = Convert.ToString(birthday.Mm) + "/" + Convert.ToString(birthday.Dd) + "/" + Convert.ToString(birthday.Yyyy + 55);
                        break;
                }
            }
            return (Convert.ToDateTime(affter60Y) - DateTime.Now).Days;
        }
        internal class DMY  // tao định dạng ngày tháng năm của riêng mình
        {
            int dd, mm, yyyy;

            public int Dd { get => dd; set => dd = value; }
            public int Mm { get => mm; set => mm = value; }
            public int Yyyy { get => yyyy; set => yyyy = value; }
        }

        public bool checVal(TextBox name, Panel panel)
        {
            bool status = false;
            if(name.Text != "" && name.Text != "Nhập họ tên...")
            {
                Status.Name = true;
            } else
            {
                Status.Name = false;
                status = false;
                return status;
            }
            foreach (RadioButton item in panel.Controls)
            {
                status |= item.Checked;
            }
            Status.Sex = status;
            return status;
        }
        public string showErr()
        {
            if (!Status.Name)
            {
                return "Vui lòng nhập tên.";
            }
            if (!Status.Sex)
            {
                return "Vui lòng chọn giới tính";
            }
            return "";
        }
    }
    class Status
    {
        static bool name = false;
        static bool sex = false;

        public static bool Name { get => name; set => name = value; }
        public static bool Sex { get => sex; set => sex = value; }
    }
}
