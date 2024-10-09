namespace Bai3
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
            this.txt_Songuoi = new System.Windows.Forms.TextBox();
            this.txt_Hoten = new System.Windows.Forms.TextBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.btn_Xoacuoi = new System.Windows.Forms.Button();
            this.btn_Xoatatca = new System.Windows.Forms.Button();
            this.btn_Xoabandau = new System.Windows.Forms.Button();
            this.btn_Xoachon = new System.Windows.Forms.Button();
            this.btn_Nhap = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txt_Songuoi
            // 
            this.txt_Songuoi.Location = new System.Drawing.Point(532, 286);
            this.txt_Songuoi.Name = "txt_Songuoi";
            this.txt_Songuoi.Size = new System.Drawing.Size(230, 22);
            this.txt_Songuoi.TabIndex = 21;
            // 
            // txt_Hoten
            // 
            this.txt_Hoten.Location = new System.Drawing.Point(96, 155);
            this.txt_Hoten.Name = "txt_Hoten";
            this.txt_Hoten.Size = new System.Drawing.Size(167, 22);
            this.txt_Hoten.TabIndex = 20;            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 16;
            this.listBox1.Location = new System.Drawing.Point(366, 131);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(405, 132);
            this.listBox1.TabIndex = 19;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // btn_Xoacuoi
            // 
            this.btn_Xoacuoi.Location = new System.Drawing.Point(582, 368);
            this.btn_Xoacuoi.Name = "btn_Xoacuoi";
            this.btn_Xoacuoi.Size = new System.Drawing.Size(180, 32);
            this.btn_Xoacuoi.TabIndex = 18;
            this.btn_Xoacuoi.Text = "Xóa thông tin cuối";
            this.btn_Xoacuoi.UseVisualStyleBackColor = true;
            this.btn_Xoacuoi.Click += new System.EventHandler(this.btn_Xoacuoi_Click);
            // 
            // btn_Xoatatca
            // 
            this.btn_Xoatatca.Location = new System.Drawing.Point(366, 368);
            this.btn_Xoatatca.Name = "btn_Xoatatca";
            this.btn_Xoatatca.Size = new System.Drawing.Size(180, 32);
            this.btn_Xoatatca.TabIndex = 17;
            this.btn_Xoatatca.Text = "Xóa tất cả thông tin";
            this.btn_Xoatatca.UseVisualStyleBackColor = true;
            this.btn_Xoatatca.Click += new System.EventHandler(this.btn_Xoatatca_Click);
            // 
            // btn_Xoabandau
            // 
            this.btn_Xoabandau.Location = new System.Drawing.Point(582, 321);
            this.btn_Xoabandau.Name = "btn_Xoabandau";
            this.btn_Xoabandau.Size = new System.Drawing.Size(180, 32);
            this.btn_Xoabandau.TabIndex = 16;
            this.btn_Xoabandau.Text = "Xóa thông tin ban đầu";
            this.btn_Xoabandau.UseVisualStyleBackColor = true;
            this.btn_Xoabandau.Click += new System.EventHandler(this.btn_Xoabandau_Click);
            // 
            // btn_Xoachon
            // 
            this.btn_Xoachon.Location = new System.Drawing.Point(366, 321);
            this.btn_Xoachon.Name = "btn_Xoachon";
            this.btn_Xoachon.Size = new System.Drawing.Size(180, 32);
            this.btn_Xoachon.TabIndex = 15;
            this.btn_Xoachon.Text = "Xóa thông tin đã chọn";
            this.btn_Xoachon.UseVisualStyleBackColor = true;
            this.btn_Xoachon.Click += new System.EventHandler(this.btn_Xoachon_Click);
            // 
            // btn_Nhap
            // 
            this.btn_Nhap.Location = new System.Drawing.Point(96, 200);
            this.btn_Nhap.Name = "btn_Nhap";
            this.btn_Nhap.Size = new System.Drawing.Size(141, 34);
            this.btn_Nhap.TabIndex = 14;
            this.btn_Nhap.Text = "Nhập thông tin";
            this.btn_Nhap.UseVisualStyleBackColor = true;
            this.btn_Nhap.Click += new System.EventHandler(this.btn_Nhap_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(363, 286);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(148, 16);
            this.label3.TabIndex = 13;
            this.label3.Text = "Tổng số người khai báo";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(30, 155);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 16);
            this.label2.TabIndex = 12;
            this.label2.Text = "Họ tên";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(152, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(415, 38);
            this.label1.TabIndex = 11;
            this.label1.Text = "KHAI BÁO Y TẾ ĐIỆN TỬ";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txt_Songuoi);
            this.Controls.Add(this.txt_Hoten);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.btn_Xoacuoi);
            this.Controls.Add(this.btn_Xoatatca);
            this.Controls.Add(this.btn_Xoabandau);
            this.Controls.Add(this.btn_Xoachon);
            this.Controls.Add(this.btn_Nhap);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_Songuoi;
        private System.Windows.Forms.TextBox txt_Hoten;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button btn_Xoacuoi;
        private System.Windows.Forms.Button btn_Xoatatca;
        private System.Windows.Forms.Button btn_Xoabandau;
        private System.Windows.Forms.Button btn_Xoachon;
        private System.Windows.Forms.Button btn_Nhap;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}

