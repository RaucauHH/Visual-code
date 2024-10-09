namespace BTVN_Lap3
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
            this.txt_a = new System.Windows.Forms.TextBox();
            this.txt_b = new System.Windows.Forms.TextBox();
            this.btn_KiemTra = new System.Windows.Forms.Button();
            this.btn_Giai = new System.Windows.Forms.Button();
            this.txt_KetQua = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(288, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(227, 22);
            this.label1.TabIndex = 0;
            this.label1.Text = "Bất phương trình ax + b < 0";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(195, 129);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nhập a:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(195, 198);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Nhập b:";
            // 
            // txt_a
            // 
            this.txt_a.Location = new System.Drawing.Point(292, 129);
            this.txt_a.Name = "txt_a";
            this.txt_a.Size = new System.Drawing.Size(192, 22);
            this.txt_a.TabIndex = 3;
            // 
            // txt_b
            // 
            this.txt_b.Location = new System.Drawing.Point(292, 198);
            this.txt_b.Name = "txt_b";
            this.txt_b.Size = new System.Drawing.Size(192, 22);
            this.txt_b.TabIndex = 4;
            // 
            // btn_KiemTra
            // 
            this.btn_KiemTra.Location = new System.Drawing.Point(171, 296);
            this.btn_KiemTra.Name = "btn_KiemTra";
            this.btn_KiemTra.Size = new System.Drawing.Size(158, 30);
            this.btn_KiemTra.TabIndex = 5;
            this.btn_KiemTra.Text = "Kiểm tra";
            this.btn_KiemTra.UseVisualStyleBackColor = true;
            this.btn_KiemTra.Click += new System.EventHandler(this.btn_KiemTra_Click);
            // 
            // btn_Giai
            // 
            this.btn_Giai.Location = new System.Drawing.Point(451, 296);
            this.btn_Giai.Name = "btn_Giai";
            this.btn_Giai.Size = new System.Drawing.Size(158, 30);
            this.btn_Giai.TabIndex = 6;
            this.btn_Giai.Text = "Giải phương trình";
            this.btn_Giai.UseVisualStyleBackColor = true;
            this.btn_Giai.Click += new System.EventHandler(this.btn_Giai_Click);
            // 
            // txt_KetQua
            // 
            this.txt_KetQua.AutoSize = true;
            this.txt_KetQua.Location = new System.Drawing.Point(289, 254);
            this.txt_KetQua.Name = "txt_KetQua";
            this.txt_KetQua.Size = new System.Drawing.Size(0, 16);
            this.txt_KetQua.TabIndex = 7;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txt_KetQua);
            this.Controls.Add(this.btn_Giai);
            this.Controls.Add(this.btn_KiemTra);
            this.Controls.Add(this.txt_b);
            this.Controls.Add(this.txt_a);
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
        private System.Windows.Forms.TextBox txt_a;
        private System.Windows.Forms.TextBox txt_b;
        private System.Windows.Forms.Button btn_KiemTra;
        private System.Windows.Forms.Button btn_Giai;
        private System.Windows.Forms.Label txt_KetQua;
    }
}

