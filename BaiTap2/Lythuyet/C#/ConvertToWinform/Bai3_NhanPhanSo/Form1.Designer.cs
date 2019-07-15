namespace Bai3_NhanPhanSo
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.inpputInfo = new System.Windows.Forms.GroupBox();
            this.btnSolve = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.selectOp = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.hsF = new System.Windows.Forms.TextBox();
            this.hsE = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.hsD = new System.Windows.Forms.TextBox();
            this.hsC = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.hsB = new System.Windows.Forms.TextBox();
            this.hsa = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.messErr = new System.Windows.Forms.Label();
            this.inpputInfo.SuspendLayout();
            this.SuspendLayout();
            // 
            // inpputInfo
            // 
            this.inpputInfo.AutoSize = true;
            this.inpputInfo.Controls.Add(this.messErr);
            this.inpputInfo.Controls.Add(this.btnSolve);
            this.inpputInfo.Controls.Add(this.label6);
            this.inpputInfo.Controls.Add(this.label5);
            this.inpputInfo.Controls.Add(this.selectOp);
            this.inpputInfo.Controls.Add(this.label4);
            this.inpputInfo.Controls.Add(this.hsF);
            this.inpputInfo.Controls.Add(this.hsE);
            this.inpputInfo.Controls.Add(this.label3);
            this.inpputInfo.Controls.Add(this.hsD);
            this.inpputInfo.Controls.Add(this.hsC);
            this.inpputInfo.Controls.Add(this.label2);
            this.inpputInfo.Controls.Add(this.hsB);
            this.inpputInfo.Controls.Add(this.hsa);
            this.inpputInfo.Controls.Add(this.label1);
            this.inpputInfo.Location = new System.Drawing.Point(12, 18);
            this.inpputInfo.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.inpputInfo.Name = "inpputInfo";
            this.inpputInfo.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.inpputInfo.Size = new System.Drawing.Size(391, 203);
            this.inpputInfo.TabIndex = 0;
            this.inpputInfo.TabStop = false;
            this.inpputInfo.Text = "Nhập thông tin";
            // 
            // btnSolve
            // 
            this.btnSolve.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSolve.Location = new System.Drawing.Point(280, 64);
            this.btnSolve.Name = "btnSolve";
            this.btnSolve.Size = new System.Drawing.Size(75, 37);
            this.btnSolve.TabIndex = 6;
            this.btnSolve.Text = "Slove";
            this.btnSolve.UseVisualStyleBackColor = true;
            this.btnSolve.Click += new System.EventHandler(this.BtnSolve_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(185, 72);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(80, 20);
            this.label6.TabIndex = 12;
            this.label6.Text = "Phân số 2";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(33, 73);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(80, 20);
            this.label5.TabIndex = 11;
            this.label5.Text = "Phân số 1";
            // 
            // selectOp
            // 
            this.selectOp.AllowDrop = true;
            this.selectOp.FormattingEnabled = true;
            this.selectOp.Items.AddRange(new object[] {
            "+",
            "-",
            "x",
            ":"});
            this.selectOp.Location = new System.Drawing.Point(123, 122);
            this.selectOp.Name = "selectOp";
            this.selectOp.Size = new System.Drawing.Size(41, 28);
            this.selectOp.TabIndex = 3;
            this.selectOp.Text = "+";
            this.selectOp.SelectedIndexChanged += new System.EventHandler(this.ComboBox1_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.SystemColors.Control;
            this.label4.Location = new System.Drawing.Point(259, 127);
            this.label4.Margin = new System.Windows.Forms.Padding(0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(18, 20);
            this.label4.TabIndex = 9;
            this.label4.Tag = "1";
            this.label4.Text = "=";
            // 
            // hsF
            // 
            this.hsF.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.hsF.ForeColor = System.Drawing.Color.Black;
            this.hsF.Location = new System.Drawing.Point(284, 141);
            this.hsF.Name = "hsF";
            this.hsF.Size = new System.Drawing.Size(67, 26);
            this.hsF.TabIndex = 8;
            // 
            // hsE
            // 
            this.hsE.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.hsE.ForeColor = System.Drawing.Color.Black;
            this.hsE.Location = new System.Drawing.Point(284, 107);
            this.hsE.Name = "hsE";
            this.hsE.Size = new System.Drawing.Size(67, 26);
            this.hsE.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.Control;
            this.label3.Enabled = false;
            this.label3.Location = new System.Drawing.Point(282, 118);
            this.label3.Margin = new System.Windows.Forms.Padding(0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 20);
            this.label3.TabIndex = 6;
            this.label3.Tag = "1";
            this.label3.Text = "_______";
            // 
            // hsD
            // 
            this.hsD.ForeColor = System.Drawing.Color.DimGray;
            this.hsD.Location = new System.Drawing.Point(189, 141);
            this.hsD.Name = "hsD";
            this.hsD.Size = new System.Drawing.Size(67, 26);
            this.hsD.TabIndex = 5;
            this.hsD.Text = "d";
            this.hsD.Enter += new System.EventHandler(this.HsD_Enter);
            this.hsD.Leave += new System.EventHandler(this.HsD_Leave);
            // 
            // hsC
            // 
            this.hsC.ForeColor = System.Drawing.Color.DimGray;
            this.hsC.Location = new System.Drawing.Point(189, 107);
            this.hsC.Name = "hsC";
            this.hsC.Size = new System.Drawing.Size(67, 26);
            this.hsC.TabIndex = 4;
            this.hsC.Text = "c";
            this.hsC.Enter += new System.EventHandler(this.HsC_Enter);
            this.hsC.Leave += new System.EventHandler(this.HsC_Leave);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.Control;
            this.label2.Location = new System.Drawing.Point(186, 118);
            this.label2.Margin = new System.Windows.Forms.Padding(0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 20);
            this.label2.TabIndex = 3;
            this.label2.Tag = "1";
            this.label2.Text = "_______";
            // 
            // hsB
            // 
            this.hsB.ForeColor = System.Drawing.Color.DimGray;
            this.hsB.Location = new System.Drawing.Point(37, 141);
            this.hsB.Name = "hsB";
            this.hsB.Size = new System.Drawing.Size(67, 26);
            this.hsB.TabIndex = 2;
            this.hsB.Text = "b";
            this.hsB.Enter += new System.EventHandler(this.HsB_Enter);
            this.hsB.Leave += new System.EventHandler(this.HsB_Leave);
            // 
            // hsa
            // 
            this.hsa.ForeColor = System.Drawing.Color.DimGray;
            this.hsa.Location = new System.Drawing.Point(37, 107);
            this.hsa.Name = "hsa";
            this.hsa.Size = new System.Drawing.Size(67, 26);
            this.hsa.TabIndex = 1;
            this.hsa.Text = "a";
            this.hsa.Enter += new System.EventHandler(this.Hsa_Enter);
            this.hsa.Leave += new System.EventHandler(this.Hsa_Leave);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(34, 118);
            this.label1.Margin = new System.Windows.Forms.Padding(0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 20);
            this.label1.TabIndex = 0;
            this.label1.Tag = "1";
            this.label1.Text = "_______";
            // 
            // messErr
            // 
            this.messErr.AutoSize = true;
            this.messErr.ForeColor = System.Drawing.Color.Red;
            this.messErr.Location = new System.Drawing.Point(37, 28);
            this.messErr.Name = "messErr";
            this.messErr.Size = new System.Drawing.Size(0, 20);
            this.messErr.TabIndex = 13;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(412, 224);
            this.Controls.Add(this.inpputInfo);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tinh Toan Phan So";
            this.inpputInfo.ResumeLayout(false);
            this.inpputInfo.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox inpputInfo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox hsa;
        private System.Windows.Forms.ComboBox selectOp;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox hsF;
        private System.Windows.Forms.TextBox hsE;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox hsD;
        private System.Windows.Forms.TextBox hsC;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox hsB;
        private System.Windows.Forms.Button btnSolve;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label messErr;
    }
}

