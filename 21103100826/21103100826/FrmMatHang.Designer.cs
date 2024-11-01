namespace _21103100826
{
    partial class FrmMatHang
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
            this.btn_TimKiem_0826 = new System.Windows.Forms.Button();
            this.btn_Xoa_0826 = new System.Windows.Forms.Button();
            this.btn_Sua_0826 = new System.Windows.Forms.Button();
            this.btn_Them_0826 = new System.Windows.Forms.Button();
            this.groupBox2_0826 = new System.Windows.Forms.GroupBox();
            this.dataGridView1_0826 = new System.Windows.Forms.DataGridView();
            this.groupBox1_0826 = new System.Windows.Forms.GroupBox();
            this.txt_TenMH_0826 = new System.Windows.Forms.TextBox();
            this.txt_MaMH_0826 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_Thoat_0826 = new System.Windows.Forms.Button();
            this.txt_DVT_0826 = new System.Windows.Forms.TextBox();
            this.MaMH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenMH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DVT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox2_0826.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1_0826)).BeginInit();
            this.groupBox1_0826.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(165, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(443, 36);
            this.label1.TabIndex = 3;
            this.label1.Text = "THÔNG TIN MẶT HÀNG 0826";
            // 
            // btn_TimKiem_0826
            // 
            this.btn_TimKiem_0826.Location = new System.Drawing.Point(613, 22);
            this.btn_TimKiem_0826.Name = "btn_TimKiem_0826";
            this.btn_TimKiem_0826.Size = new System.Drawing.Size(120, 36);
            this.btn_TimKiem_0826.TabIndex = 12;
            this.btn_TimKiem_0826.Text = "Tìm kiếm 0826";
            this.btn_TimKiem_0826.UseVisualStyleBackColor = true;
            this.btn_TimKiem_0826.Click += new System.EventHandler(this.btn_TimKiem_0826_Click);
            // 
            // btn_Xoa_0826
            // 
            this.btn_Xoa_0826.Location = new System.Drawing.Point(457, 67);
            this.btn_Xoa_0826.Name = "btn_Xoa_0826";
            this.btn_Xoa_0826.Size = new System.Drawing.Size(120, 36);
            this.btn_Xoa_0826.TabIndex = 11;
            this.btn_Xoa_0826.Text = "Xóa 0826";
            this.btn_Xoa_0826.UseVisualStyleBackColor = true;
            this.btn_Xoa_0826.Click += new System.EventHandler(this.btn_Xoa_0826_Click);
            // 
            // btn_Sua_0826
            // 
            this.btn_Sua_0826.Location = new System.Drawing.Point(457, 119);
            this.btn_Sua_0826.Name = "btn_Sua_0826";
            this.btn_Sua_0826.Size = new System.Drawing.Size(120, 36);
            this.btn_Sua_0826.TabIndex = 10;
            this.btn_Sua_0826.Text = "Sửa 0826";
            this.btn_Sua_0826.UseVisualStyleBackColor = true;
            this.btn_Sua_0826.Click += new System.EventHandler(this.btn_Sua_0826_Click);
            // 
            // btn_Them_0826
            // 
            this.btn_Them_0826.Location = new System.Drawing.Point(457, 22);
            this.btn_Them_0826.Name = "btn_Them_0826";
            this.btn_Them_0826.Size = new System.Drawing.Size(120, 36);
            this.btn_Them_0826.TabIndex = 9;
            this.btn_Them_0826.Text = "Thêm 0826";
            this.btn_Them_0826.UseVisualStyleBackColor = true;
            this.btn_Them_0826.Click += new System.EventHandler(this.btn_Them_0826_Click);
            // 
            // groupBox2_0826
            // 
            this.groupBox2_0826.Controls.Add(this.dataGridView1_0826);
            this.groupBox2_0826.Location = new System.Drawing.Point(12, 231);
            this.groupBox2_0826.Name = "groupBox2_0826";
            this.groupBox2_0826.Size = new System.Drawing.Size(775, 207);
            this.groupBox2_0826.TabIndex = 8;
            this.groupBox2_0826.TabStop = false;
            this.groupBox2_0826.Text = "Danh sách mặt hàng 0826";
            // 
            // dataGridView1_0826
            // 
            this.dataGridView1_0826.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1_0826.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaMH,
            this.TenMH,
            this.DVT});
            this.dataGridView1_0826.Location = new System.Drawing.Point(6, 21);
            this.dataGridView1_0826.Name = "dataGridView1_0826";
            this.dataGridView1_0826.RowHeadersWidth = 51;
            this.dataGridView1_0826.RowTemplate.Height = 24;
            this.dataGridView1_0826.Size = new System.Drawing.Size(762, 180);
            this.dataGridView1_0826.TabIndex = 0;
            this.dataGridView1_0826.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_0826_CellClick);
            // 
            // groupBox1_0826
            // 
            this.groupBox1_0826.Controls.Add(this.txt_DVT_0826);
            this.groupBox1_0826.Controls.Add(this.btn_Thoat_0826);
            this.groupBox1_0826.Controls.Add(this.btn_TimKiem_0826);
            this.groupBox1_0826.Controls.Add(this.btn_Xoa_0826);
            this.groupBox1_0826.Controls.Add(this.txt_TenMH_0826);
            this.groupBox1_0826.Controls.Add(this.btn_Sua_0826);
            this.groupBox1_0826.Controls.Add(this.txt_MaMH_0826);
            this.groupBox1_0826.Controls.Add(this.btn_Them_0826);
            this.groupBox1_0826.Controls.Add(this.label4);
            this.groupBox1_0826.Controls.Add(this.label3);
            this.groupBox1_0826.Controls.Add(this.label2);
            this.groupBox1_0826.Location = new System.Drawing.Point(13, 50);
            this.groupBox1_0826.Name = "groupBox1_0826";
            this.groupBox1_0826.Size = new System.Drawing.Size(775, 175);
            this.groupBox1_0826.TabIndex = 7;
            this.groupBox1_0826.TabStop = false;
            this.groupBox1_0826.Text = "Thông tin chi tiết mặt hàng 0826";
            // 
            // txt_TenMH_0826
            // 
            this.txt_TenMH_0826.Location = new System.Drawing.Point(174, 74);
            this.txt_TenMH_0826.Name = "txt_TenMH_0826";
            this.txt_TenMH_0826.Size = new System.Drawing.Size(231, 22);
            this.txt_TenMH_0826.TabIndex = 6;
            // 
            // txt_MaMH_0826
            // 
            this.txt_MaMH_0826.Location = new System.Drawing.Point(174, 22);
            this.txt_MaMH_0826.Name = "txt_MaMH_0826";
            this.txt_MaMH_0826.Size = new System.Drawing.Size(231, 22);
            this.txt_MaMH_0826.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(32, 126);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(106, 16);
            this.label4.TabIndex = 2;
            this.label4.Text = "Đơn Vị Tính 0826";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 74);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(123, 16);
            this.label3.TabIndex = 1;
            this.label3.Text = "Tên Mặt Hàng 0826";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(118, 16);
            this.label2.TabIndex = 0;
            this.label2.Text = "Mã Mặt Hàng 0826";
            // 
            // btn_Thoat_0826
            // 
            this.btn_Thoat_0826.Location = new System.Drawing.Point(613, 74);
            this.btn_Thoat_0826.Name = "btn_Thoat_0826";
            this.btn_Thoat_0826.Size = new System.Drawing.Size(120, 32);
            this.btn_Thoat_0826.TabIndex = 13;
            this.btn_Thoat_0826.Text = "Thoát 0826";
            this.btn_Thoat_0826.UseVisualStyleBackColor = true;
            this.btn_Thoat_0826.Click += new System.EventHandler(this.btn_Thoat_0826_Click);
            // 
            // txt_DVT_0826
            // 
            this.txt_DVT_0826.Location = new System.Drawing.Point(174, 119);
            this.txt_DVT_0826.Name = "txt_DVT_0826";
            this.txt_DVT_0826.Size = new System.Drawing.Size(231, 22);
            this.txt_DVT_0826.TabIndex = 14;
            // 
            // MaMH
            // 
            this.MaMH.DataPropertyName = "MaMH";
            this.MaMH.HeaderText = "Mã Mặt Hàng";
            this.MaMH.MinimumWidth = 6;
            this.MaMH.Name = "MaMH";
            this.MaMH.Width = 125;
            // 
            // TenMH
            // 
            this.TenMH.DataPropertyName = "TenMH";
            this.TenMH.HeaderText = "Tên Mặt Hàng ";
            this.TenMH.MinimumWidth = 6;
            this.TenMH.Name = "TenMH";
            this.TenMH.Width = 200;
            // 
            // DVT
            // 
            this.DVT.DataPropertyName = "DVT";
            this.DVT.HeaderText = "Đơn Vị Tính";
            this.DVT.MinimumWidth = 6;
            this.DVT.Name = "DVT";
            this.DVT.Width = 200;
            // 
            // FrmMatHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox2_0826);
            this.Controls.Add(this.groupBox1_0826);
            this.Controls.Add(this.label1);
            this.Name = "FrmMatHang";
            this.Text = "FrmMatHang";
            this.Load += new System.EventHandler(this.FrmMatHang_Load);
            this.groupBox2_0826.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1_0826)).EndInit();
            this.groupBox1_0826.ResumeLayout(false);
            this.groupBox1_0826.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_TimKiem_0826;
        private System.Windows.Forms.Button btn_Xoa_0826;
        private System.Windows.Forms.Button btn_Sua_0826;
        private System.Windows.Forms.Button btn_Them_0826;
        private System.Windows.Forms.GroupBox groupBox2_0826;
        private System.Windows.Forms.DataGridView dataGridView1_0826;
        private System.Windows.Forms.GroupBox groupBox1_0826;
        private System.Windows.Forms.TextBox txt_TenMH_0826;
        private System.Windows.Forms.TextBox txt_MaMH_0826;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_Thoat_0826;
        private System.Windows.Forms.TextBox txt_DVT_0826;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaMH;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenMH;
        private System.Windows.Forms.DataGridViewTextBoxColumn DVT;
    }
}