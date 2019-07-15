using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace Bai3_NhanPhanSo
{
    class CheckInput: Form
    {
        public static bool isNumber(string key) // ham nay dung de kiem tra giao tri nhap vao co phai la so hay ko
        {
            foreach (var item in key)
            {
                if (!char.IsNumber(item) && char.Parse("-") != item)
                {
                    return false;
                }
            }
            string[] stringToArrayHor = key.Split('-');
            if (stringToArrayHor.Length > 2)
            {
                return false;
            }
            return true;
        }
        public static bool checkInputAll()  //ham nay se kiem tra tat ca cac o input co nhap dung dinh dang hay ko
        {
            if (IPS.hsA && IPS.hsB && IPS.hsC && IPS.hsD)
            {
                return true;
            }
            return false;
        }
        public void evtFoEn(TextBox tx) // ham nay dung de set su kien enter focus vao mot o input nao do tren tu
        {
            if (!CheckInput.isNumber(tx.Text))
            {
                tx.Text = "";
                tx.ForeColor = Color.Black;
            }
        }
        public void evtFoEnM(TextBox tx) // ham nay dung de set su kien enter focus vao mot o input nao do duoi mau
        {
            if (!(CheckInput.isNumber(tx.Text) &&tx.Text !="0"))
            {
                tx.Text = "";
                tx.ForeColor = Color.Black;
            }
        }
        public bool evtFoLe(TextBox tx, Label lblMeEr, string who) // ham nay dung de set su kien khi da ra khoi o nhap lieu o tren tu
        {
            if(tx.Text == "")
            {
                tx.ForeColor = Color.Red;
                lblMeEr.Text = "Vui long nhap " + who;
                return false;
            }
            if (!CheckInput.isNumber(tx.Text))
            {
                tx.ForeColor = Color.Red;
                lblMeEr.Text = "Vui long nhap " + who + " la so thuc";
                return false;
            }
            if ((lblMeEr.Text == "Vui long nhap " + who) || lblMeEr.Text == "Vui long nhap " + who + " la so thuc")
            {
                lblMeEr.Text = "";
            }
            tx.ForeColor = Color.Black;
            return true;
        }
        public bool evtFoLeM(TextBox tx, Label lblMeEr, string who) // tuong tu ham tren nhung o duoi mau
        {
            if (tx.Text == "")
            {
                tx.ForeColor = Color.Red;
                lblMeEr.Text = "Vui long nhap " + who;
                return false;
            }
            if (tx.Text == "0")
            {
                tx.ForeColor = Color.Red;
                lblMeEr.Text = who + " phải khác 0";
                return false;
            }
            if (!CheckInput.isNumber(tx.Text))
            {
                tx.ForeColor = Color.Red;
                lblMeEr.Text = "Vui long nhap " + who + " la so thuc";
                return false;
            }
            tx.ForeColor = Color.Black;
            if((lblMeEr.Text == "Vui long nhap " + who) || (lblMeEr.Text == who + " phải khác 0") || lblMeEr.Text == "Vui long nhap " + who + " la so thuc")
            {
                lblMeEr.Text = "";
            }
            return true;
        }
        public Fract getOperation(TextBox a, TextBox b, TextBox c, TextBox d, ComboBox selectOp, Label mesEr) //ham nay dung de rut gon phan so khi da tinh toan xong
        {
            FractProces fractProces = new FractProces();
            Fract fract = new Fract();
            switch (selectOp.Text)
            {
                case "+":
                    fract.Element = Convert.ToDouble(a.Text) * Convert.ToDouble(d.Text) + Convert.ToDouble(b.Text)*Convert.ToDouble(c.Text);
                    fract.Sample = Convert.ToDouble(b.Text) * Convert.ToDouble(d.Text);
                    fractProces.compactFract(fract);
                    return fract = fractProces.compactFract(fract);
                case "-":
                    fract.Element = Convert.ToDouble(a.Text) * Convert.ToDouble(d.Text) - Convert.ToDouble(b.Text) * Convert.ToDouble(c.Text);
                    fract.Sample = Convert.ToDouble(b.Text) * Convert.ToDouble(d.Text);                    
                    return fract = fractProces.compactFract(fract);
                case "x":
                    fract.Element = Convert.ToDouble(a.Text) * Convert.ToDouble(c.Text);
                    fract.Sample = Convert.ToDouble(b.Text) * Convert.ToDouble(d.Text);
                    return fract = fractProces.compactFract(fract);
                case ":":
                    if(c.Text != "0")
                    {
                        fract.Element = Convert.ToDouble(a.Text) / Convert.ToDouble(c.Text);
                        fract.Sample = Convert.ToDouble(b.Text) / Convert.ToDouble(d.Text);
                        mesEr.Text = "";
                        return fract = fractProces.compactFract(fract);
                    } else { mesEr.Text = "Không thể thực hiện phép chia vì c =0"; }
                    break;

            }
            return fract;
        }


    }
    class IPS //inputstatus
    {
        public static bool hsA = false, hsB = false, hsC =false, hsD =false;
    }
}
