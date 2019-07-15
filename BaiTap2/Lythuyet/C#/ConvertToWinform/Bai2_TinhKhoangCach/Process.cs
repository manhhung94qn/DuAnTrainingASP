using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace Bai2_TinhKhoangCach
{
    public class Process: Form
    {
        public static bool isNumber(string key)
        {
            foreach (var item in key)
            {
                if (!char.IsNumber(item) && char.Parse("-") != item && item != Char.Parse("."))
                {
                    return false;
                }
            }
            string[] stringToArrayDot = key.Split('.');
            string[] stringToArrayHor = key.Split('-');
            if (stringToArrayDot.Length > 2 || stringToArrayHor.Length > 2)
            {
                return false;
            }
            return true;
        }
        public string calculaterDistance(TextBox a, TextBox b, TextBox c, TextBox x, TextBox y) {
            double aN = double.Parse(a.Text);
            double bN = double.Parse(b.Text);
            double cN = double.Parse(c.Text);
            double xN = double.Parse(x.Text);
            double yN = double.Parse(y.Text);
            return Convert.ToString((aN * xN + bN * yN + cN) / (Math.Sqrt(Math.Pow(aN, 2) + Math.Pow(bN, 2))));
        }
    }
    public class IputStatus
    {
        static public bool hsAB = false, hsBB = false, hsCB = false, hsXmB = false, hsYmB = false;
        public void evClickInput(TextBox textBox, string textInfo)
        {
            if (textBox.Text == textInfo)
            {
                textBox.Text = "";
                textBox.ForeColor = Color.Black;
            }
            if (!Process.isNumber(textBox.Text))
            {
                textBox.Text = "";
                textBox.ForeColor = Color.Black;
            }
        }
        public bool evLeave(TextBox textBox, string text, Label messError)
        {
            if (textBox.Text == "")
            {
                textBox.Text = text;
                textBox.ForeColor = Color.DimGray;
                return false;

            }
            else if (!Process.isNumber(textBox.Text))
            {
                textBox.ForeColor = Color.Red;
                messError.Text = "Vui lòng nhập " + text + " là số thực.";
                return false;
            }
            else {
                textBox.ForeColor = Color.Black;
                if(messError.Text == "Vui lòng nhập " + text + " là số thực.")
                {
                    messError.Text = "";
                }
            }
            return true;
        }
        public bool setMessErrAll(Label lbl)
        {
            bool res = hsAB && hsBB && hsCB && hsXmB && hsYmB;
            if (res)
            {
                lbl.Text = "";
            }
            else lbl.Text = "Vui lòng kiểm tra lại các số bạn đã nhập.";
            return res;
        }
    }

}
