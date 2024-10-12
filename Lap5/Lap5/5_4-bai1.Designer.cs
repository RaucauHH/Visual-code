namespace Lap5
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.rbt_ThongTin = new System.Windows.Forms.RichTextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txt_KH = new System.Windows.Forms.TextBox();
            this.txt_DC = new System.Windows.Forms.TextBox();
            this.txt_TongNgay = new System.Windows.Forms.TextBox();
            this.btn_Nhap = new System.Windows.Forms.Button();
            this.btn_Reset = new System.Windows.Forms.Button();
            this.btn_Thoat = new System.Windows.Forms.Button();
            this.dtp_Ngaysinh = new System.Windows.Forms.DateTimePicker();
            this.dtp_NgayDi = new System.Windows.Forms.DateTimePicker();
            this.dtp_NgayVe = new System.Windows.Forms.DateTimePicker();
            this.listBox_Di = new System.Windows.Forms.ListBox();
            this.listBox_Ve = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Khách hàng";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(25, 106);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Ngày sinh";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(25, 153);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Địa chỉ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(110, 212);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(74, 16);
            this.label4.TabIndex = 3;
            this.label4.Text = "Địa điểm đi";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(297, 212);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(90, 16);
            this.label5.TabIndex = 4;
            this.label5.Text = "Điểm đến đến";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(123, 339);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(54, 16);
            this.label6.TabIndex = 5;
            this.label6.Text = "Ngày đi";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(314, 339);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(58, 16);
            this.label7.TabIndex = 6;
            this.label7.Text = "Ngày về";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(572, 283);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(90, 16);
            this.label8.TabIndex = 7;
            this.label8.Text = "Tổng số ngày";
            // 
            // rbt_ThongTin
            // 
            this.rbt_ThongTin.Location = new System.Drawing.Point(571, 39);
            this.rbt_ThongTin.Name = "rbt_ThongTin";
            this.rbt_ThongTin.Size = new System.Drawing.Size(217, 222);
            this.rbt_ThongTin.TabIndex = 8;
            this.rbt_ThongTin.Text = "";
            this.rbt_ThongTin.TextChanged += new System.EventHandler(this.rbt_ThongTin_TextChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(275, 9);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(252, 25);
            this.label10.TabIndex = 10;
            this.label10.Text = "CÔNG TY DU LỊCH ABC";
            // 
            // txt_KH
            // 
            this.txt_KH.Location = new System.Drawing.Point(113, 57);
            this.txt_KH.Name = "txt_KH";
            this.txt_KH.Size = new System.Drawing.Size(156, 22);
            this.txt_KH.TabIndex = 11;
            // 
            // txt_DC
            // 
            this.txt_DC.Location = new System.Drawing.Point(113, 153);
            this.txt_DC.Name = "txt_DC";
            this.txt_DC.Size = new System.Drawing.Size(156, 22);
            this.txt_DC.TabIndex = 12;
            // 
            // txt_TongNgay
            // 
            this.txt_TongNgay.Enabled = false;
            this.txt_TongNgay.Location = new System.Drawing.Point(668, 283);
            this.txt_TongNgay.Name = "txt_TongNgay";
            this.txt_TongNgay.Size = new System.Drawing.Size(117, 22);
            this.txt_TongNgay.TabIndex = 13;
            // 
            // btn_Nhap
            // 
            this.btn_Nhap.Location = new System.Drawing.Point(575, 330);
            this.btn_Nhap.Name = "btn_Nhap";
            this.btn_Nhap.Size = new System.Drawing.Size(213, 32);
            this.btn_Nhap.TabIndex = 14;
            this.btn_Nhap.Text = "Nhập";
            this.btn_Nhap.UseVisualStyleBackColor = true;
            this.btn_Nhap.Click += new System.EventHandler(this.btn_Nhap_Click);
            // 
            // btn_Reset
            // 
            this.btn_Reset.Location = new System.Drawing.Point(575, 368);
            this.btn_Reset.Name = "btn_Reset";
            this.btn_Reset.Size = new System.Drawing.Size(213, 32);
            this.btn_Reset.TabIndex = 15;
            this.btn_Reset.Text = "Reset";
            this.btn_Reset.UseVisualStyleBackColor = true;
            this.btn_Reset.Click += new System.EventHandler(this.btn_Reset_Click);
            // 
            // btn_Thoat
            // 
            this.btn_Thoat.Location = new System.Drawing.Point(575, 406);
            this.btn_Thoat.Name = "btn_Thoat";
            this.btn_Thoat.Size = new System.Drawing.Size(213, 32);
            this.btn_Thoat.TabIndex = 16;
            this.btn_Thoat.Text = "Thoát";
            this.btn_Thoat.UseVisualStyleBackColor = true;
            this.btn_Thoat.Click += new System.EventHandler(this.btn_Thoat_Click);
            // 
            // dtp_Ngaysinh
            // 
            this.dtp_Ngaysinh.CustomFormat = "dd/MM/yyyy";
            this.dtp_Ngaysinh.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtp_Ngaysinh.Location = new System.Drawing.Point(113, 106);
            this.dtp_Ngaysinh.Name = "dtp_Ngaysinh";
            this.dtp_Ngaysinh.Size = new System.Drawing.Size(126, 22);
            this.dtp_Ngaysinh.TabIndex = 17;
            // 
            // dtp_NgayDi
            // 
            this.dtp_NgayDi.CustomFormat = "dd/MM/yyyy";
            this.dtp_NgayDi.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtp_NgayDi.Location = new System.Drawing.Point(87, 361);
            this.dtp_NgayDi.Name = "dtp_NgayDi";
            this.dtp_NgayDi.Size = new System.Drawing.Size(126, 22);
            this.dtp_NgayDi.TabIndex = 18;
            // 
            // dtp_NgayVe
            // 
            this.dtp_NgayVe.CustomFormat = "dd/MM/yyyy";
            this.dtp_NgayVe.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtp_NgayVe.Location = new System.Drawing.Point(280, 361);
            this.dtp_NgayVe.Name = "dtp_NgayVe";
            this.dtp_NgayVe.Size = new System.Drawing.Size(126, 22);
            this.dtp_NgayVe.TabIndex = 19;
            // 
            // listBox_Di
            // 
            this.listBox_Di.FormattingEnabled = true;
            this.listBox_Di.ItemHeight = 16;
            this.listBox_Di.Location = new System.Drawing.Point(87, 241);
            this.listBox_Di.Name = "listBox_Di";
            this.listBox_Di.Size = new System.Drawing.Size(126, 68);
            this.listBox_Di.TabIndex = 20;
            // 
            // listBox_Ve
            // 
            this.listBox_Ve.FormattingEnabled = true;
            this.listBox_Ve.ItemHeight = 16;
            this.listBox_Ve.Location = new System.Drawing.Point(280, 241);
            this.listBox_Ve.Name = "listBox_Ve";
            this.listBox_Ve.Size = new System.Drawing.Size(126, 68);
            this.listBox_Ve.TabIndex = 21;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.listBox_Ve);
            this.Controls.Add(this.listBox_Di);
            this.Controls.Add(this.dtp_NgayVe);
            this.Controls.Add(this.dtp_NgayDi);
            this.Controls.Add(this.dtp_Ngaysinh);
            this.Controls.Add(this.btn_Thoat);
            this.Controls.Add(this.btn_Reset);
            this.Controls.Add(this.btn_Nhap);
            this.Controls.Add(this.txt_TongNgay);
            this.Controls.Add(this.txt_DC);
            this.Controls.Add(this.txt_KH);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.rbt_ThongTin);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.RichTextBox rbt_ThongTin;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txt_KH;
        private System.Windows.Forms.TextBox txt_DC;
        private System.Windows.Forms.TextBox txt_TongNgay;
        private System.Windows.Forms.Button btn_Nhap;
        private System.Windows.Forms.Button btn_Reset;
        private System.Windows.Forms.Button btn_Thoat;
        private System.Windows.Forms.DateTimePicker dtp_Ngaysinh;
        private System.Windows.Forms.DateTimePicker dtp_NgayDi;
        private System.Windows.Forms.DateTimePicker dtp_NgayVe;
        private System.Windows.Forms.ListBox listBox_Di;
        private System.Windows.Forms.ListBox listBox_Ve;
    }
}

