namespace Bai4_TinhNgayVeHuu
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.inpputName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.selectBirthday = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.pnSelectSex = new System.Windows.Forms.Panel();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.btnExportInfo = new System.Windows.Forms.Button();
            this.mesErr = new System.Windows.Forms.Label();
            this.grOutputInfo = new System.Windows.Forms.GroupBox();
            this.outputName = new System.Windows.Forms.Label();
            this.outputCountday = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.pnSelectSex.SuspendLayout();
            this.grOutputInfo.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.White;
            this.groupBox1.Controls.Add(this.mesErr);
            this.groupBox1.Controls.Add(this.btnExportInfo);
            this.groupBox1.Controls.Add(this.pnSelectSex);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.selectBirthday);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.inpputName);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(118, 67);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(470, 275);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Nhập thông tin";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Họ tên:";
            // 
            // inpputName
            // 
            this.inpputName.ForeColor = System.Drawing.Color.DimGray;
            this.inpputName.Location = new System.Drawing.Point(115, 46);
            this.inpputName.Name = "inpputName";
            this.inpputName.Size = new System.Drawing.Size(328, 26);
            this.inpputName.TabIndex = 1;
            this.inpputName.Text = "Nhập họ tên...";
            this.inpputName.Enter += new System.EventHandler(this.InpputName_Enter);
            this.inpputName.Leave += new System.EventHandler(this.InpputName_Leave);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 104);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Ngày sinh:";
            // 
            // selectBirthday
            // 
            this.selectBirthday.Location = new System.Drawing.Point(115, 103);
            this.selectBirthday.Name = "selectBirthday";
            this.selectBirthday.Size = new System.Drawing.Size(328, 26);
            this.selectBirthday.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(20, 152);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "Giới tính:";
            // 
            // pnSelectSex
            // 
            this.pnSelectSex.Controls.Add(this.radioButton2);
            this.pnSelectSex.Controls.Add(this.radioButton1);
            this.pnSelectSex.Location = new System.Drawing.Point(115, 135);
            this.pnSelectSex.Name = "pnSelectSex";
            this.pnSelectSex.Size = new System.Drawing.Size(328, 49);
            this.pnSelectSex.TabIndex = 5;
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(26, 13);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(60, 24);
            this.radioButton1.TabIndex = 0;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Nam";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(149, 12);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(47, 24);
            this.radioButton2.TabIndex = 1;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "Nữ";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // btnExportInfo
            // 
            this.btnExportInfo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnExportInfo.Location = new System.Drawing.Point(141, 233);
            this.btnExportInfo.Name = "btnExportInfo";
            this.btnExportInfo.Size = new System.Drawing.Size(201, 38);
            this.btnExportInfo.TabIndex = 6;
            this.btnExportInfo.Text = "Xuất Thông Tin";
            this.btnExportInfo.UseVisualStyleBackColor = true;
            this.btnExportInfo.Click += new System.EventHandler(this.BtnExportInfo_Click);
            // 
            // mesErr
            // 
            this.mesErr.AutoSize = true;
            this.mesErr.ForeColor = System.Drawing.Color.Red;
            this.mesErr.Location = new System.Drawing.Point(141, 202);
            this.mesErr.Name = "mesErr";
            this.mesErr.Size = new System.Drawing.Size(0, 20);
            this.mesErr.TabIndex = 7;
            // 
            // grOutputInfo
            // 
            this.grOutputInfo.BackColor = System.Drawing.Color.White;
            this.grOutputInfo.Controls.Add(this.outputCountday);
            this.grOutputInfo.Controls.Add(this.outputName);
            this.grOutputInfo.Location = new System.Drawing.Point(118, 341);
            this.grOutputInfo.Name = "grOutputInfo";
            this.grOutputInfo.Size = new System.Drawing.Size(470, 295);
            this.grOutputInfo.TabIndex = 1;
            this.grOutputInfo.TabStop = false;
            this.grOutputInfo.Text = "Thông tin";
            // 
            // outputName
            // 
            this.outputName.AutoSize = true;
            this.outputName.Location = new System.Drawing.Point(24, 48);
            this.outputName.Name = "outputName";
            this.outputName.Size = new System.Drawing.Size(0, 20);
            this.outputName.TabIndex = 0;
            // 
            // outputCountday
            // 
            this.outputCountday.AutoSize = true;
            this.outputCountday.Location = new System.Drawing.Point(28, 90);
            this.outputCountday.Name = "outputCountday";
            this.outputCountday.Size = new System.Drawing.Size(0, 20);
            this.outputCountday.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(739, 692);
            this.Controls.Add(this.grOutputInfo);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tính tuổi về hưu";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.pnSelectSex.ResumeLayout(false);
            this.pnSelectSex.PerformLayout();
            this.grOutputInfo.ResumeLayout(false);
            this.grOutputInfo.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DateTimePicker selectBirthday;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox inpputName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel pnSelectSex;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label mesErr;
        private System.Windows.Forms.Button btnExportInfo;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.GroupBox grOutputInfo;
        private System.Windows.Forms.Label outputName;
        private System.Windows.Forms.Label outputCountday;
    }
}

