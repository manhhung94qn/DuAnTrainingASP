using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bai3_NhanPhanSo
{
    public partial class Form1 : Form
    {
        CheckInput cIP = new CheckInput();
        public Form1()
        {
            InitializeComponent();
        }

        private void HsA_TextChanged(object sender, EventArgs e)
        {
        }

        private void ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Hsa_Enter(object sender, EventArgs e) { cIP.evtFoEn(hsa); }

        private void HsB_Enter(object sender, EventArgs e) { cIP.evtFoEnM(hsB); }

        private void HsC_Enter(object sender, EventArgs e) { cIP.evtFoEn(hsC); }

        private void HsD_Enter(object sender, EventArgs e) { cIP.evtFoEnM(hsD); }

        private void Hsa_Leave(object sender, EventArgs e) { IPS.hsA = cIP.evtFoLe(hsa,messErr, "a"); }

        private void HsB_Leave(object sender, EventArgs e) { IPS.hsB = cIP.evtFoLeM(hsB, messErr, "b"); }

        private void HsC_Leave(object sender, EventArgs e) { IPS.hsC = cIP.evtFoLe(hsC, messErr, "c"); }

        private void HsD_Leave(object sender, EventArgs e) { IPS.hsD = cIP.evtFoLeM(hsD, messErr, "d"); }

        public void showResl()
        {
            if (CheckInput.checkInputAll())
            {
                Fract reslFr = cIP.getOperation(hsa, hsB, hsC, hsD, selectOp, messErr);
                hsE.Text = Convert.ToString(reslFr.Element);
                hsF.Text = Convert.ToString(reslFr.Sample);
            }
        }

        private void BtnSolve_Click(object sender, EventArgs e) { showResl(); }
    }
}
