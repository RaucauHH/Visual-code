namespace Lap5
{
    partial class Form2
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
            this.txt_TH1 = new System.Windows.Forms.TextBox();
            this.txt_TH2 = new System.Windows.Forms.TextBox();
            this.txt_KetQua = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btn_TinhToan = new System.Windows.Forms.Button();
            this.btn_Thoat = new System.Windows.Forms.Button();
            this.cb_PhepToan = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(66, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "Toán hạng 1:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(243, 33);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 19);
            this.label2.TabIndex = 1;
            this.label2.Text = "Phép toán:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(396, 33);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(94, 19);
            this.label3.TabIndex = 2;
            this.label3.Text = "Toán hạng 2:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(628, 33);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 19);
            this.label4.TabIndex = 3;
            this.label4.Text = "Kết quả:";
            // 
            // txt_TH1
            // 
            this.txt_TH1.Location = new System.Drawing.Point(60, 72);
            this.txt_TH1.Name = "txt_TH1";
            this.txt_TH1.Size = new System.Drawing.Size(100, 22);
            this.txt_TH1.TabIndex = 4;
            // 
            // txt_TH2
            // 
            this.txt_TH2.Location = new System.Drawing.Point(390, 72);
            this.txt_TH2.Name = "txt_TH2";
            this.txt_TH2.Size = new System.Drawing.Size(100, 22);
            this.txt_TH2.TabIndex = 6;
            // 
            // txt_KetQua
            // 
            this.txt_KetQua.Location = new System.Drawing.Point(616, 72);
            this.txt_KetQua.Name = "txt_KetQua";
            this.txt_KetQua.Size = new System.Drawing.Size(100, 22);
            this.txt_KetQua.TabIndex = 7;
            this.txt_KetQua.Visible = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(552, 72);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(14, 16);
            this.label5.TabIndex = 8;
            this.label5.Text = "=";
            // 
            // btn_TinhToan
            // 
            this.btn_TinhToan.Location = new System.Drawing.Point(161, 230);
            this.btn_TinhToan.Name = "btn_TinhToan";
            this.btn_TinhToan.Size = new System.Drawing.Size(106, 40);
            this.btn_TinhToan.TabIndex = 9;
            this.btn_TinhToan.Text = "Tính Toán";
            this.btn_TinhToan.UseVisualStyleBackColor = true;
            this.btn_TinhToan.Click += new System.EventHandler(this.btn_TinhToan_Click);
            // 
            // btn_Thoat
            // 
            this.btn_Thoat.Location = new System.Drawing.Point(506, 229);
            this.btn_Thoat.Name = "btn_Thoat";
            this.btn_Thoat.Size = new System.Drawing.Size(106, 40);
            this.btn_Thoat.TabIndex = 10;
            this.btn_Thoat.Text = "Thoát";
            this.btn_Thoat.UseVisualStyleBackColor = true;
            this.btn_Thoat.Click += new System.EventHandler(this.btn_Thoat_Click);
            // 
            // cb_PhepToan
            // 
            this.cb_PhepToan.FormattingEnabled = true;
            this.cb_PhepToan.Location = new System.Drawing.Point(215, 72);
            this.cb_PhepToan.Name = "cb_PhepToan";
            this.cb_PhepToan.Size = new System.Drawing.Size(121, 24);
            this.cb_PhepToan.TabIndex = 11;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.cb_PhepToan);
            this.Controls.Add(this.btn_Thoat);
            this.Controls.Add(this.btn_TinhToan);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txt_KetQua);
            this.Controls.Add(this.txt_TH2);
            this.Controls.Add(this.txt_TH1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form2";
            this.Text = "Form2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_TH1;
        private System.Windows.Forms.TextBox txt_TH2;
        private System.Windows.Forms.TextBox txt_KetQua;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btn_TinhToan;
        private System.Windows.Forms.Button btn_Thoat;
        private System.Windows.Forms.ComboBox cb_PhepToan;
    }
}