using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bai4_TinhNgayVeHuu
{
    public partial class Form1 : Form
    {
        ProcessInfo process = new ProcessInfo();
        public Form1()
        {
            InitializeComponent();
        }

        private void BtnExportInfo_Click(object sender, EventArgs e)
        {
            if (process.checVal(inpputName, pnSelectSex))
            {
                outputName.Text = process.getName(inpputName, pnSelectSex);
                outputCountday.Text = process.getCountDay(selectBirthday, pnSelectSex);
                mesErr.Text = "";
            }
            else
            {
                mesErr.Text = process.showErr();
            }
        }

        private void InpputName_Enter(object sender, EventArgs e)
        {
            process.checVal(inpputName, pnSelectSex);
            if (!Status.Name)
            {
                inpputName.Text = "";
                inpputName.ForeColor = Color.Black;
            }
        }

        private void InpputName_Leave(object sender, EventArgs e)
        {
            process.checVal(inpputName, pnSelectSex);
            if (!Status.Name)
            {
                inpputName.Text = "Nhập họ tên...";
                inpputName.ForeColor = Color.Red;
            }
        }
    }
}
