namespace Bai3_BTVN_Lap4
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.listBox2 = new System.Windows.Forms.ListBox();
            this.btn_CapNhat = new System.Windows.Forms.Button();
            this.btn_AsangB = new System.Windows.Forms.Button();
            this.btn_BsangA = new System.Windows.Forms.Button();
            this.btn_AsangB1 = new System.Windows.Forms.Button();
            this.btn_BsangA1 = new System.Windows.Forms.Button();
            this.btn_Xoa = new System.Windows.Forms.Button();
            this.btn_KetThuc = new System.Windows.Forms.Button();
            this.txt_HvaT = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(225, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(323, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "DANH SÁCH SINH VIÊN";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(155, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Họ và tên";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.listBox1);
            this.groupBox1.Location = new System.Drawing.Point(12, 118);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(310, 258);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Lớp A:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.listBox2);
            this.groupBox2.Location = new System.Drawing.Point(478, 118);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(310, 258);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Lớp B:";
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 16;
            this.listBox1.Location = new System.Drawing.Point(6, 21);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(304, 228);
            this.listBox1.TabIndex = 0;
            // 
            // listBox2
            // 
            this.listBox2.FormattingEnabled = true;
            this.listBox2.ItemHeight = 16;
            this.listBox2.Location = new System.Drawing.Point(6, 21);
            this.listBox2.Name = "listBox2";
            this.listBox2.Size = new System.Drawing.Size(304, 228);
            this.listBox2.TabIndex = 1;
            // 
            // btn_CapNhat
            // 
            this.btn_CapNhat.Location = new System.Drawing.Point(478, 70);
            this.btn_CapNhat.Name = "btn_CapNhat";
            this.btn_CapNhat.Size = new System.Drawing.Size(87, 25);
            this.btn_CapNhat.TabIndex = 4;
            this.btn_CapNhat.Text = "Cập nhật";
            this.btn_CapNhat.UseVisualStyleBackColor = true;
            this.btn_CapNhat.Click += new System.EventHandler(this.btn_CapNhat_Click);
            // 
            // btn_AsangB
            // 
            this.btn_AsangB.Location = new System.Drawing.Point(328, 197);
            this.btn_AsangB.Name = "btn_AsangB";
            this.btn_AsangB.Size = new System.Drawing.Size(69, 29);
            this.btn_AsangB.TabIndex = 5;
            this.btn_AsangB.Text = ">";
            this.btn_AsangB.UseVisualStyleBackColor = true;
            this.btn_AsangB.Click += new System.EventHandler(this.btn_AsangB_Click);
            // 
            // btn_BsangA
            // 
            this.btn_BsangA.Location = new System.Drawing.Point(403, 197);
            this.btn_BsangA.Name = "btn_BsangA";
            this.btn_BsangA.Size = new System.Drawing.Size(69, 29);
            this.btn_BsangA.TabIndex = 6;
            this.btn_BsangA.Text = "<";
            this.btn_BsangA.UseVisualStyleBackColor = true;
            this.btn_BsangA.Click += new System.EventHandler(this.btn_BsangA_Click);
            // 
            // btn_AsangB1
            // 
            this.btn_AsangB1.Location = new System.Drawing.Point(328, 255);
            this.btn_AsangB1.Name = "btn_AsangB1";
            this.btn_AsangB1.Size = new System.Drawing.Size(69, 29);
            this.btn_AsangB1.TabIndex = 7;
            this.btn_AsangB1.Text = ">>";
            this.btn_AsangB1.UseVisualStyleBackColor = true;
            this.btn_AsangB1.Click += new System.EventHandler(this.btn_AsangB1_Click);
            // 
            // btn_BsangA1
            // 
            this.btn_BsangA1.Location = new System.Drawing.Point(403, 255);
            this.btn_BsangA1.Name = "btn_BsangA1";
            this.btn_BsangA1.Size = new System.Drawing.Size(69, 29);
            this.btn_BsangA1.TabIndex = 8;
            this.btn_BsangA1.Text = "<<";
            this.btn_BsangA1.UseVisualStyleBackColor = true;
            this.btn_BsangA1.Click += new System.EventHandler(this.btn_BsangA1_Click);
            // 
            // btn_Xoa
            // 
            this.btn_Xoa.Location = new System.Drawing.Point(136, 399);
            this.btn_Xoa.Name = "btn_Xoa";
            this.btn_Xoa.Size = new System.Drawing.Size(124, 23);
            this.btn_Xoa.TabIndex = 9;
            this.btn_Xoa.Text = "Xóa";
            this.btn_Xoa.UseVisualStyleBackColor = true;
            this.btn_Xoa.Click += new System.EventHandler(this.btn_Xoa_Click);
            // 
            // btn_KetThuc
            // 
            this.btn_KetThuc.Location = new System.Drawing.Point(586, 399);
            this.btn_KetThuc.Name = "btn_KetThuc";
            this.btn_KetThuc.Size = new System.Drawing.Size(124, 23);
            this.btn_KetThuc.TabIndex = 10;
            this.btn_KetThuc.Text = "Kết thúc";
            this.btn_KetThuc.UseVisualStyleBackColor = true;
            this.btn_KetThuc.Click += new System.EventHandler(this.btn_KetThuc_Click);
            // 
            // txt_HvaT
            // 
            this.txt_HvaT.Location = new System.Drawing.Point(231, 73);
            this.txt_HvaT.Name = "txt_HvaT";
            this.txt_HvaT.Size = new System.Drawing.Size(220, 22);
            this.txt_HvaT.TabIndex = 11;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txt_HvaT);
            this.Controls.Add(this.btn_KetThuc);
            this.Controls.Add(this.btn_Xoa);
            this.Controls.Add(this.btn_BsangA1);
            this.Controls.Add(this.btn_AsangB1);
            this.Controls.Add(this.btn_BsangA);
            this.Controls.Add(this.btn_AsangB);
            this.Controls.Add(this.btn_CapNhat);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ListBox listBox2;
        private System.Windows.Forms.Button btn_CapNhat;
        private System.Windows.Forms.Button btn_AsangB;
        private System.Windows.Forms.Button btn_BsangA;
        private System.Windows.Forms.Button btn_AsangB1;
        private System.Windows.Forms.Button btn_BsangA1;
        private System.Windows.Forms.Button btn_Xoa;
        private System.Windows.Forms.Button btn_KetThuc;
        private System.Windows.Forms.TextBox txt_HvaT;
    }
}

