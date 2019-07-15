using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bai2_TinhKhoangCach
{
    public partial class Form1 : Form 
    {
        Process process = new Process();
        IputStatus iS = new IputStatus();
        public Form1()
        {
            InitializeComponent();
        }

        private void TextBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void HsA_Click(object sender, EventArgs e){iS.evClickInput(hsA,"a"); }
        private void HsB_Click(object sender, EventArgs e) { iS.evClickInput(hsB, "b"); }
        private void HsC_Click(object sender, EventArgs e) { iS.evClickInput(hsC, "c"); }
        private void HsXm_Click(object sender, EventArgs e) { iS.evClickInput(hsXm, "x"); }
        private void HsYm_Click(object sender, EventArgs e) { iS.evClickInput(hsYm, "y"); }

        private void HsA_Leave(object sender, EventArgs e) {IputStatus.hsAB = iS.evLeave(hsA, "a", messError); }
        private void HsB_Leave(object sender, EventArgs e) {IputStatus.hsBB =  iS.evLeave(hsB, "b", messError); }
        private void HsC_Leave(object sender, EventArgs e) { IputStatus.hsCB = iS.evLeave(hsC, "c", messError); }
        private void HsXm_Leave(object sender, EventArgs e) { IputStatus.hsXmB =  iS.evLeave(hsXm, "x", messError); }
        private void HsYm_Leave(object sender, EventArgs e) { IputStatus.hsYmB = iS.evLeave(hsYm, "y ", messError); }

        private void Button1_Click(object sender, EventArgs e)
        {
            if (iS.setMessErrAll(messError))
            {
                outPut.Visible = true;
                lblRes.Text = process.calculaterDistance(hsA, hsB, hsC, hsXm, hsYm);
            }
            else outPut.Visible = false;
        }
    }
}
