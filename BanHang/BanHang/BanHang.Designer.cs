namespace BanHang
{
    partial class BanHang
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
            this.cbHang = new System.Windows.Forms.GroupBox();
            this.cbGia = new System.Windows.Forms.ComboBox();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnadd = new System.Windows.Forms.Button();
            this.cbMa = new System.Windows.Forms.ComboBox();
            this.comboBox4 = new System.Windows.Forms.ComboBox();
            this.cbLoai = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.cbSize = new System.Windows.Forms.ComboBox();
            this.txtSL = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cbSP = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.txtTienThua = new System.Windows.Forms.TextBox();
            this.txtNhan = new System.Windows.Forms.TextBox();
            this.btnThongtinKH = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.txtTong = new System.Windows.Forms.TextBox();
            this.btnXuatHoaDon = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.BanHang_dataGridView1 = new System.Windows.Forms.DataGridView();
            this.masp = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ten = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.size = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.soluong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dongia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.thanhtien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cbHang.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BanHang_dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // cbHang
            // 
            this.cbHang.Controls.Add(this.cbGia);
            this.cbHang.Controls.Add(this.btnDelete);
            this.cbHang.Controls.Add(this.btnadd);
            this.cbHang.Controls.Add(this.cbMa);
            this.cbHang.Controls.Add(this.comboBox4);
            this.cbHang.Controls.Add(this.cbLoai);
            this.cbHang.Controls.Add(this.label7);
            this.cbHang.Controls.Add(this.label6);
            this.cbHang.Controls.Add(this.cbSize);
            this.cbHang.Controls.Add(this.txtSL);
            this.cbHang.Controls.Add(this.label4);
            this.cbHang.Controls.Add(this.label5);
            this.cbHang.Controls.Add(this.label2);
            this.cbHang.Controls.Add(this.cbSP);
            this.cbHang.Controls.Add(this.label3);
            this.cbHang.Controls.Add(this.label1);
            this.cbHang.Location = new System.Drawing.Point(12, 12);
            this.cbHang.Name = "cbHang";
            this.cbHang.Size = new System.Drawing.Size(743, 122);
            this.cbHang.TabIndex = 0;
            this.cbHang.TabStop = false;
            this.cbHang.Text = "Thông tin SP";
            // 
            // cbGia
            // 
            this.cbGia.DropDownStyle = System.Windows.Forms.ComboBoxStyle.Simple;
            this.cbGia.FormattingEnabled = true;
            this.cbGia.Location = new System.Drawing.Point(594, 79);
            this.cbGia.Name = "cbGia";
            this.cbGia.Size = new System.Drawing.Size(132, 21);
            this.cbGia.TabIndex = 21;
            // 
            // btnDelete
            // 
            this.btnDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.Location = new System.Drawing.Point(63, 85);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(45, 31);
            this.btnDelete.TabIndex = 20;
            this.btnDelete.Text = "-";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnadd
            // 
            this.btnadd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnadd.Location = new System.Drawing.Point(12, 85);
            this.btnadd.Name = "btnadd";
            this.btnadd.Size = new System.Drawing.Size(45, 31);
            this.btnadd.TabIndex = 19;
            this.btnadd.Text = "+";
            this.btnadd.UseVisualStyleBackColor = true;
            this.btnadd.Click += new System.EventHandler(this.btnadd_Click);
            // 
            // cbMa
            // 
            this.cbMa.FormattingEnabled = true;
            this.cbMa.Location = new System.Drawing.Point(221, 39);
            this.cbMa.Name = "cbMa";
            this.cbMa.Size = new System.Drawing.Size(118, 21);
            this.cbMa.TabIndex = 18;
            this.cbMa.SelectedValueChanged += new System.EventHandler(this.cbMa_SelectedValueChanged);
            // 
            // comboBox4
            // 
            this.comboBox4.FormattingEnabled = true;
            this.comboBox4.Location = new System.Drawing.Point(421, 39);
            this.comboBox4.Name = "comboBox4";
            this.comboBox4.Size = new System.Drawing.Size(114, 21);
            this.comboBox4.TabIndex = 17;
            // 
            // cbLoai
            // 
            this.cbLoai.FormattingEnabled = true;
            this.cbLoai.Location = new System.Drawing.Point(594, 39);
            this.cbLoai.Name = "cbLoai";
            this.cbLoai.Size = new System.Drawing.Size(132, 21);
            this.cbLoai.TabIndex = 16;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(554, 39);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(32, 16);
            this.label7.TabIndex = 15;
            this.label7.Text = "Loại";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(345, 39);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(38, 16);
            this.label6.TabIndex = 12;
            this.label6.Text = "Hãng";
            // 
            // cbSize
            // 
            this.cbSize.FormattingEnabled = true;
            this.cbSize.Location = new System.Drawing.Point(221, 80);
            this.cbSize.Name = "cbSize";
            this.cbSize.Size = new System.Drawing.Size(118, 21);
            this.cbSize.TabIndex = 11;
            // 
            // txtSL
            // 
            this.txtSL.Location = new System.Drawing.Point(421, 85);
            this.txtSL.Name = "txtSL";
            this.txtSL.Size = new System.Drawing.Size(114, 20);
            this.txtSL.TabIndex = 10;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(345, 85);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 16);
            this.label4.TabIndex = 8;
            this.label4.Text = "Số lượng";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(168, 85);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(34, 16);
            this.label5.TabIndex = 7;
            this.label5.Text = "Size";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(9, 39);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 16);
            this.label2.TabIndex = 6;
            this.label2.Text = "Sản Phẩm";
            // 
            // cbSP
            // 
            this.cbSP.FormattingEnabled = true;
            this.cbSP.Items.AddRange(new object[] {
            "Giay",
            "PhuKien"});
            this.cbSP.Location = new System.Drawing.Point(85, 39);
            this.cbSP.Name = "cbSP";
            this.cbSP.Size = new System.Drawing.Size(73, 21);
            this.cbSP.TabIndex = 5;
            this.cbSP.SelectedIndexChanged += new System.EventHandler(this.cbSP_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(554, 85);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(28, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Giá";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(168, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã SP";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(575, 225);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(66, 16);
            this.label10.TabIndex = 21;
            this.label10.Text = "Tiền Thừa";
            // 
            // txtTienThua
            // 
            this.txtTienThua.Location = new System.Drawing.Point(650, 224);
            this.txtTienThua.Name = "txtTienThua";
            this.txtTienThua.Size = new System.Drawing.Size(100, 20);
            this.txtTienThua.TabIndex = 22;
            this.txtTienThua.Text = "0";
            this.txtTienThua.MouseClick += new System.Windows.Forms.MouseEventHandler(this.txtTienThua_MouseClick);
            // 
            // txtNhan
            // 
            this.txtNhan.Location = new System.Drawing.Point(650, 186);
            this.txtNhan.Name = "txtNhan";
            this.txtNhan.Size = new System.Drawing.Size(100, 20);
            this.txtNhan.TabIndex = 18;
            this.txtNhan.Text = "0";
            // 
            // btnThongtinKH
            // 
            this.btnThongtinKH.Location = new System.Drawing.Point(585, 310);
            this.btnThongtinKH.Name = "btnThongtinKH";
            this.btnThongtinKH.Size = new System.Drawing.Size(165, 25);
            this.btnThongtinKH.TabIndex = 23;
            this.btnThongtinKH.Text = "Thông tin KH";
            this.btnThongtinKH.UseVisualStyleBackColor = true;
            this.btnThongtinKH.Click += new System.EventHandler(this.btnThongtinKH_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(604, 187);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(38, 16);
            this.label9.TabIndex = 17;
            this.label9.Text = "Nhận";
            // 
            // txtTong
            // 
            this.txtTong.Location = new System.Drawing.Point(650, 150);
            this.txtTong.Name = "txtTong";
            this.txtTong.Size = new System.Drawing.Size(100, 20);
            this.txtTong.TabIndex = 19;
            // 
            // btnXuatHoaDon
            // 
            this.btnXuatHoaDon.Location = new System.Drawing.Point(585, 351);
            this.btnXuatHoaDon.Name = "btnXuatHoaDon";
            this.btnXuatHoaDon.Size = new System.Drawing.Size(165, 25);
            this.btnXuatHoaDon.TabIndex = 25;
            this.btnXuatHoaDon.Text = "Xuất hóa đơn";
            this.btnXuatHoaDon.UseVisualStyleBackColor = true;
            this.btnXuatHoaDon.Click += new System.EventHandler(this.button3_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(604, 151);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(36, 16);
            this.label8.TabIndex = 20;
            this.label8.Text = "Tổng";
            // 
            // BanHang_dataGridView1
            // 
            this.BanHang_dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.BanHang_dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.masp,
            this.ten,
            this.size,
            this.soluong,
            this.dongia,
            this.thanhtien});
            this.BanHang_dataGridView1.Location = new System.Drawing.Point(12, 151);
            this.BanHang_dataGridView1.Name = "BanHang_dataGridView1";
            this.BanHang_dataGridView1.Size = new System.Drawing.Size(557, 230);
            this.BanHang_dataGridView1.TabIndex = 26;
            // 
            // masp
            // 
            this.masp.HeaderText = "Mã SP";
            this.masp.Name = "masp";
            // 
            // ten
            // 
            this.ten.HeaderText = "Tên SP";
            this.ten.Name = "ten";
            // 
            // size
            // 
            this.size.HeaderText = "Size";
            this.size.Name = "size";
            // 
            // soluong
            // 
            this.soluong.HeaderText = "Số Lượng";
            this.soluong.Name = "soluong";
            // 
            // dongia
            // 
            this.dongia.HeaderText = "Đơn giá";
            this.dongia.Name = "dongia";
            // 
            // thanhtien
            // 
            this.thanhtien.HeaderText = "Thành Tiền";
            this.thanhtien.Name = "thanhtien";
            // 
            // BanHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(764, 393);
            this.Controls.Add(this.BanHang_dataGridView1);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.btnXuatHoaDon);
            this.Controls.Add(this.txtTong);
            this.Controls.Add(this.cbHang);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txtTienThua);
            this.Controls.Add(this.btnThongtinKH);
            this.Controls.Add(this.txtNhan);
            this.Name = "BanHang";
            this.Text = "BanHang";
            this.cbHang.ResumeLayout(false);
            this.cbHang.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BanHang_dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox cbHang;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbSP;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbLoai;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cbSize;
        private System.Windows.Forms.TextBox txtSL;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cbMa;
        private System.Windows.Forms.ComboBox comboBox4;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnadd;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtTienThua;
        private System.Windows.Forms.TextBox txtNhan;
        private System.Windows.Forms.Button btnThongtinKH;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtTong;
        private System.Windows.Forms.Button btnXuatHoaDon;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DataGridView BanHang_dataGridView1;
        private System.Windows.Forms.ComboBox cbGia;
        private System.Windows.Forms.DataGridViewTextBoxColumn masp;
        private System.Windows.Forms.DataGridViewTextBoxColumn ten;
        private System.Windows.Forms.DataGridViewTextBoxColumn size;
        private System.Windows.Forms.DataGridViewTextBoxColumn soluong;
        private System.Windows.Forms.DataGridViewTextBoxColumn dongia;
        private System.Windows.Forms.DataGridViewTextBoxColumn thanhtien;
    }
}