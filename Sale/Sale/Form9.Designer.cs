namespace Sale
{
    partial class Form9_Kiemhang
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.sảnPhẩmToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.giàyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.phụKiệnToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.mavach = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.thuonghieu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.loai = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mau = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tinhtrang = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.soluong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hinh = new System.Windows.Forms.DataGridViewImageColumn();
            this.baohanh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sảnPhẩmToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(807, 28);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // sảnPhẩmToolStripMenuItem
            // 
            this.sảnPhẩmToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.giàyToolStripMenuItem,
            this.phụKiệnToolStripMenuItem});
            this.sảnPhẩmToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sảnPhẩmToolStripMenuItem.Name = "sảnPhẩmToolStripMenuItem";
            this.sảnPhẩmToolStripMenuItem.Size = new System.Drawing.Size(87, 24);
            this.sảnPhẩmToolStripMenuItem.Text = "Sản phẩm";
            // 
            // giàyToolStripMenuItem
            // 
            this.giàyToolStripMenuItem.Name = "giàyToolStripMenuItem";
            this.giàyToolStripMenuItem.Size = new System.Drawing.Size(133, 24);
            this.giàyToolStripMenuItem.Text = "Giày";
            // 
            // phụKiệnToolStripMenuItem
            // 
            this.phụKiệnToolStripMenuItem.Name = "phụKiệnToolStripMenuItem";
            this.phụKiệnToolStripMenuItem.Size = new System.Drawing.Size(133, 24);
            this.phụKiệnToolStripMenuItem.Text = "Phụ kiện";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.mavach,
            this.thuonghieu,
            this.loai,
            this.mau,
            this.tinhtrang,
            this.soluong,
            this.gia,
            this.hinh,
            this.baohanh});
            this.dataGridView1.Location = new System.Drawing.Point(21, 103);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(774, 203);
            this.dataGridView1.TabIndex = 13;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(60, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 16);
            this.label1.TabIndex = 14;
            this.label1.Text = "Theo";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(115, 45);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 16;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(270, 46);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(180, 20);
            this.textBox1.TabIndex = 17;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::Sale.Properties.Resources.magnifying_glass_icon;
            this.pictureBox2.Location = new System.Drawing.Point(21, 42);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(33, 24);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 15;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Sale.Properties.Resources.running_shoe_icon_vector_white_background_illustration_45598287;
            this.pictureBox1.Location = new System.Drawing.Point(747, 31);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(60, 53);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 12;
            this.pictureBox1.TabStop = false;
            // 
            // mavach
            // 
            this.mavach.HeaderText = "Mã vạch";
            this.mavach.Name = "mavach";
            // 
            // thuonghieu
            // 
            this.thuonghieu.HeaderText = "Thương hiệu";
            this.thuonghieu.Name = "thuonghieu";
            // 
            // loai
            // 
            this.loai.HeaderText = "Loại";
            this.loai.Name = "loai";
            this.loai.Width = 70;
            // 
            // mau
            // 
            this.mau.HeaderText = "Màu";
            this.mau.Name = "mau";
            this.mau.Width = 80;
            // 
            // tinhtrang
            // 
            this.tinhtrang.HeaderText = "Hết hàng";
            this.tinhtrang.Name = "tinhtrang";
            this.tinhtrang.Width = 40;
            // 
            // soluong
            // 
            this.soluong.HeaderText = "Số lượng";
            this.soluong.Name = "soluong";
            this.soluong.Width = 60;
            // 
            // gia
            // 
            this.gia.HeaderText = "Giá";
            this.gia.Name = "gia";
            // 
            // hinh
            // 
            this.hinh.HeaderText = "Hình";
            this.hinh.Name = "hinh";
            // 
            // baohanh
            // 
            this.baohanh.HeaderText = "Bảo hành / năm";
            this.baohanh.Name = "baohanh";
            this.baohanh.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.baohanh.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.baohanh.Width = 80;
            // 
            // Form9_Kiemhang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(807, 318);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form9_Kiemhang";
            this.Text = "Kiểm hàng";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem sảnPhẩmToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem giàyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem phụKiệnToolStripMenuItem;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.DataGridViewTextBoxColumn mavach;
        private System.Windows.Forms.DataGridViewTextBoxColumn thuonghieu;
        private System.Windows.Forms.DataGridViewTextBoxColumn loai;
        private System.Windows.Forms.DataGridViewTextBoxColumn mau;
        private System.Windows.Forms.DataGridViewCheckBoxColumn tinhtrang;
        private System.Windows.Forms.DataGridViewTextBoxColumn soluong;
        private System.Windows.Forms.DataGridViewTextBoxColumn gia;
        private System.Windows.Forms.DataGridViewImageColumn hinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn baohanh;
    }
}