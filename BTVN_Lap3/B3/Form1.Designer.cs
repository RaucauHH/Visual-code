namespace B3
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
            this.txt_n = new System.Windows.Forms.TextBox();
            this.btn_TinhTong = new System.Windows.Forms.Button();
            this.btn_KiemTra = new System.Windows.Forms.Button();
            this.txt_KQ = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(61, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 22);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nhập n:";
            // 
            // txt_n
            // 
            this.txt_n.Location = new System.Drawing.Point(163, 46);
            this.txt_n.Name = "txt_n";
            this.txt_n.Size = new System.Drawing.Size(475, 22);
            this.txt_n.TabIndex = 1;
            // 
            // btn_TinhTong
            // 
            this.btn_TinhTong.Location = new System.Drawing.Point(65, 177);
            this.btn_TinhTong.Name = "btn_TinhTong";
            this.btn_TinhTong.Size = new System.Drawing.Size(189, 29);
            this.btn_TinhTong.TabIndex = 2;
            this.btn_TinhTong.Text = "Tính tổng:";
            this.btn_TinhTong.UseVisualStyleBackColor = true;
            this.btn_TinhTong.Click += new System.EventHandler(this.btn_TinhTong_Click);
            // 
            // btn_KiemTra
            // 
            this.btn_KiemTra.Location = new System.Drawing.Point(65, 242);
            this.btn_KiemTra.Name = "btn_KiemTra";
            this.btn_KiemTra.Size = new System.Drawing.Size(189, 29);
            this.btn_KiemTra.TabIndex = 3;
            this.btn_KiemTra.Text = "Kiểm tra nguyên tố";
            this.btn_KiemTra.UseVisualStyleBackColor = true;
            this.btn_KiemTra.Click += new System.EventHandler(this.btn_KiemTra_Click);
            // 
            // txt_KQ
            // 
            this.txt_KQ.AutoSize = true;
            this.txt_KQ.Location = new System.Drawing.Point(260, 177);
            this.txt_KQ.Name = "txt_KQ";
            this.txt_KQ.Size = new System.Drawing.Size(0, 16);
            this.txt_KQ.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txt_KQ);
            this.Controls.Add(this.btn_KiemTra);
            this.Controls.Add(this.btn_TinhTong);
            this.Controls.Add(this.txt_n);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_n;
        private System.Windows.Forms.Button btn_TinhTong;
        private System.Windows.Forms.Button btn_KiemTra;
        private System.Windows.Forms.Label txt_KQ;
    }
}

