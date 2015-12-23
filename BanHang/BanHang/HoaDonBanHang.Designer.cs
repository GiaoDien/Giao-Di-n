namespace BanHang
{
    partial class HoaDonBanHang
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HoaDonBanHang));
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Mavach = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tenhang = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Soluong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ThanhTien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tong = new System.Windows.Forms.Label();
            this.Thoilai = new System.Windows.Forms.Label();
            this.Nhan = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(115, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(201, 22);
            this.label2.TabIndex = 1;
            this.label2.Text = "HÓA ĐƠN BÁN HÀNG";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(260, 108);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 14);
            this.label3.TabIndex = 2;
            this.label3.Text = "Mã hóa đơn:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(260, 135);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 14);
            this.label4.TabIndex = 3;
            this.label4.Text = "Ngày:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(44, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(352, 48);
            this.label1.TabIndex = 0;
            this.label1.Text = "                                   Nhóm 7\r\n                   280 An Dương Vương," +
    " Quận 5                      \r\n                                 01636961996\r\n";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Mavach,
            this.Tenhang,
            this.Soluong,
            this.ThanhTien});
            this.dataGridView1.Location = new System.Drawing.Point(16, 152);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(443, 110);
            this.dataGridView1.TabIndex = 4;
            // 
            // Mavach
            // 
            this.Mavach.HeaderText = "Mã vạch";
            this.Mavach.Name = "Mavach";
            // 
            // Tenhang
            // 
            this.Tenhang.HeaderText = "Tên hàng";
            this.Tenhang.Name = "Tenhang";
            // 
            // Soluong
            // 
            this.Soluong.HeaderText = "Số lượng";
            this.Soluong.Name = "Soluong";
            // 
            // ThanhTien
            // 
            this.ThanhTien.HeaderText = "Thành tiền";
            this.ThanhTien.Name = "ThanhTien";
            // 
            // Tong
            // 
            this.Tong.AutoSize = true;
            this.Tong.Location = new System.Drawing.Point(13, 279);
            this.Tong.Name = "Tong";
            this.Tong.Size = new System.Drawing.Size(61, 14);
            this.Tong.TabIndex = 5;
            this.Tong.Text = "Tổng cộng:";
            // 
            // Thoilai
            // 
            this.Thoilai.AutoSize = true;
            this.Thoilai.Location = new System.Drawing.Point(13, 338);
            this.Thoilai.Name = "Thoilai";
            this.Thoilai.Size = new System.Drawing.Size(43, 14);
            this.Thoilai.TabIndex = 6;
            this.Thoilai.Text = "Thối lại:";
            // 
            // Nhan
            // 
            this.Nhan.AutoSize = true;
            this.Nhan.Location = new System.Drawing.Point(13, 308);
            this.Nhan.Name = "Nhan";
            this.Nhan.Size = new System.Drawing.Size(35, 14);
            this.Nhan.TabIndex = 7;
            this.Nhan.Text = "Nhận:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(44, 364);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(363, 56);
            this.label5.TabIndex = 8;
            this.label5.Text = resources.GetString("label5.Text");
            // 
            // HoaDonBanHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(468, 429);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.Nhan);
            this.Controls.Add(this.Thoilai);
            this.Controls.Add(this.Tong);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "HoaDonBanHang";
            this.Text = "HoaDonBanHang";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Mavach;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tenhang;
        private System.Windows.Forms.DataGridViewTextBoxColumn Soluong;
        private System.Windows.Forms.DataGridViewTextBoxColumn ThanhTien;
        private System.Windows.Forms.Label Tong;
        private System.Windows.Forms.Label Thoilai;
        private System.Windows.Forms.Label Nhan;
        private System.Windows.Forms.Label label5;
    }
}