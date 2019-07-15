using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bai1_TinhTuoi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void inputName_Enter(object sender, EventArgs e)
        {
            if (inputName.Text == "Nhập họ và  tên...")
            {
                inputName.Text = "";
                inputName.ForeColor = Color.Black;
            }
        }

        private void InputName_Leave(object sender, EventArgs e)
        {
            if(inputName.Text == "")
            {
                inputName.Text = "Nhập họ và  tên...";
                inputName.ForeColor = Color.Gray;
            }
        }

        private void Button1_MouseClick(object sender, MouseEventArgs e)
        {
            SInfoName checkVail = getName();
            if (checkVail.Status)
            {
                OutputInfo.Visible = true;
                label2.Text = checkVail.FullName;
                label3.Text = "Tuổi: " + checkVail.Age;
            } else
            {
                MessageBox.Show("Thông tin bạn nhập không hợp lệ, vui lòng nhập lại!!!");
            }
        }


        private SInfoName getName()
        {
            SInfoName sInfoName = new SInfoName();
            if (inputName.Text != "" && inputName.Text != "Nhập họ và  tên...")
            {
                sInfoName.Status = true;
                sInfoName.FullName ="Họ tên: "+ inputName.Text;
                sInfoName.Age = DateTime.Now.Year - Convert.ToDateTime(inputBirthday.Value).Year ;
            }
            else sInfoName.Status = false;
            return sInfoName;
        }
        struct SInfoName
        {
            bool status;
            string fullName;
            float age;
            public bool Status { get => status; set => status = value; }
            public string FullName { get => fullName; set => fullName = value; }
            public float Age { get => age; set => age = value; }
        }
    }

}
