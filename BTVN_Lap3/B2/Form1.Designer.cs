namespace B2
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
            this.rtxt_TrungTo = new System.Windows.Forms.RichTextBox();
            this.rtxt_HauTo = new System.Windows.Forms.RichTextBox();
            this.btn_Chuyen = new System.Windows.Forms.Button();
            this.btn_Thoat = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(46, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(680, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "CHUYỂN BIỂU THỨC ĐẦY ĐỦ TRUNG TỐ NGOẶC SANG DẠNG HẬU TỐ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(163, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nhập biểu thức trung tố";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 295);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(116, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Biểu thức hậu tố";
            // 
            // rtxt_TrungTo
            // 
            this.rtxt_TrungTo.Location = new System.Drawing.Point(12, 78);
            this.rtxt_TrungTo.Name = "rtxt_TrungTo";
            this.rtxt_TrungTo.Size = new System.Drawing.Size(773, 123);
            this.rtxt_TrungTo.TabIndex = 3;
            this.rtxt_TrungTo.Text = "";
            this.rtxt_TrungTo.TextChanged += new System.EventHandler(this.rtxt_TrungTo_TextChanged);
            // 
            // rtxt_HauTo
            // 
            this.rtxt_HauTo.Location = new System.Drawing.Point(12, 315);
            this.rtxt_HauTo.Name = "rtxt_HauTo";
            this.rtxt_HauTo.Size = new System.Drawing.Size(773, 123);
            this.rtxt_HauTo.TabIndex = 4;
            this.rtxt_HauTo.Text = "";
            this.rtxt_HauTo.TextChanged += new System.EventHandler(this.rtxt_HauTo_TextChanged);
            // 
            // btn_Chuyen
            // 
            this.btn_Chuyen.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Chuyen.Location = new System.Drawing.Point(180, 242);
            this.btn_Chuyen.Name = "btn_Chuyen";
            this.btn_Chuyen.Size = new System.Drawing.Size(116, 36);
            this.btn_Chuyen.TabIndex = 5;
            this.btn_Chuyen.Text = "Chuyển hậu tố";
            this.btn_Chuyen.UseVisualStyleBackColor = true;
            this.btn_Chuyen.Click += new System.EventHandler(this.btn_Chuyen_Click);
            // 
            // btn_Thoat
            // 
            this.btn_Thoat.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Thoat.Location = new System.Drawing.Point(441, 242);
            this.btn_Thoat.Name = "btn_Thoat";
            this.btn_Thoat.Size = new System.Drawing.Size(116, 36);
            this.btn_Thoat.TabIndex = 6;
            this.btn_Thoat.Text = "Thoát";
            this.btn_Thoat.UseVisualStyleBackColor = true;
            this.btn_Thoat.Click += new System.EventHandler(this.btn_Thoat_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_Thoat);
            this.Controls.Add(this.btn_Chuyen);
            this.Controls.Add(this.rtxt_HauTo);
            this.Controls.Add(this.rtxt_TrungTo);
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
        private System.Windows.Forms.RichTextBox rtxt_TrungTo;
        private System.Windows.Forms.RichTextBox rtxt_HauTo;
        private System.Windows.Forms.Button btn_Chuyen;
        private System.Windows.Forms.Button btn_Thoat;
    }
}

