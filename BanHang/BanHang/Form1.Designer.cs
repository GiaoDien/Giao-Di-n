namespace BanHang
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.banHangToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kiemHangToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quanLyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.khoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cậpNhậtToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gốcToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.khácToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.giàyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.phụKiệnToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kháchHàngToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hóaĐơnToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.thongKeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.banHangToolStripMenuItem,
            this.kiemHangToolStripMenuItem,
            this.quanLyToolStripMenuItem,
            this.thongKeToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(817, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // banHangToolStripMenuItem
            // 
            this.banHangToolStripMenuItem.Name = "banHangToolStripMenuItem";
            this.banHangToolStripMenuItem.Size = new System.Drawing.Size(71, 20);
            this.banHangToolStripMenuItem.Text = "Bán Hàng";
            this.banHangToolStripMenuItem.Click += new System.EventHandler(this.banHangToolStripMenuItem_Click);
            // 
            // kiemHangToolStripMenuItem
            // 
            this.kiemHangToolStripMenuItem.Name = "kiemHangToolStripMenuItem";
            this.kiemHangToolStripMenuItem.Size = new System.Drawing.Size(76, 20);
            this.kiemHangToolStripMenuItem.Text = "Kiểm hàng";
            // 
            // quanLyToolStripMenuItem
            // 
            this.quanLyToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.khoToolStripMenuItem,
            this.khácToolStripMenuItem});
            this.quanLyToolStripMenuItem.Name = "quanLyToolStripMenuItem";
            this.quanLyToolStripMenuItem.Size = new System.Drawing.Size(63, 20);
            this.quanLyToolStripMenuItem.Text = "Quản Lý";
            // 
            // khoToolStripMenuItem
            // 
            this.khoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cậpNhậtToolStripMenuItem,
            this.gốcToolStripMenuItem});
            this.khoToolStripMenuItem.Name = "khoToolStripMenuItem";
            this.khoToolStripMenuItem.Size = new System.Drawing.Size(100, 22);
            this.khoToolStripMenuItem.Text = "Kho";
            // 
            // cậpNhậtToolStripMenuItem
            // 
            this.cậpNhậtToolStripMenuItem.Name = "cậpNhậtToolStripMenuItem";
            this.cậpNhậtToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.cậpNhậtToolStripMenuItem.Text = "Cập Nhật";
            this.cậpNhậtToolStripMenuItem.Click += new System.EventHandler(this.cậpNhậtToolStripMenuItem_Click);
            // 
            // gốcToolStripMenuItem
            // 
            this.gốcToolStripMenuItem.Name = "gốcToolStripMenuItem";
            this.gốcToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.gốcToolStripMenuItem.Text = "Gốc";
            this.gốcToolStripMenuItem.Click += new System.EventHandler(this.gốcToolStripMenuItem_Click);
            // 
            // khácToolStripMenuItem
            // 
            this.khácToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.giàyToolStripMenuItem,
            this.phụKiệnToolStripMenuItem,
            this.kháchHàngToolStripMenuItem,
            this.hóaĐơnToolStripMenuItem});
            this.khácToolStripMenuItem.Name = "khácToolStripMenuItem";
            this.khácToolStripMenuItem.Size = new System.Drawing.Size(100, 22);
            this.khácToolStripMenuItem.Text = "Khác";
            // 
            // giàyToolStripMenuItem
            // 
            this.giàyToolStripMenuItem.Name = "giàyToolStripMenuItem";
            this.giàyToolStripMenuItem.Size = new System.Drawing.Size(139, 22);
            this.giàyToolStripMenuItem.Text = "Giày";
            // 
            // phụKiệnToolStripMenuItem
            // 
            this.phụKiệnToolStripMenuItem.Name = "phụKiệnToolStripMenuItem";
            this.phụKiệnToolStripMenuItem.Size = new System.Drawing.Size(139, 22);
            this.phụKiệnToolStripMenuItem.Text = "Phụ Kiện";
            // 
            // kháchHàngToolStripMenuItem
            // 
            this.kháchHàngToolStripMenuItem.Name = "kháchHàngToolStripMenuItem";
            this.kháchHàngToolStripMenuItem.Size = new System.Drawing.Size(139, 22);
            this.kháchHàngToolStripMenuItem.Text = "Khách Hàng";
            // 
            // hóaĐơnToolStripMenuItem
            // 
            this.hóaĐơnToolStripMenuItem.Name = "hóaĐơnToolStripMenuItem";
            this.hóaĐơnToolStripMenuItem.Size = new System.Drawing.Size(139, 22);
            this.hóaĐơnToolStripMenuItem.Text = "Hóa Đơn";
            // 
            // thongKeToolStripMenuItem
            // 
            this.thongKeToolStripMenuItem.Name = "thongKeToolStripMenuItem";
            this.thongKeToolStripMenuItem.Size = new System.Drawing.Size(70, 20);
            this.thongKeToolStripMenuItem.Text = "Thống Kê";
            this.thongKeToolStripMenuItem.Click += new System.EventHandler(this.thongKeToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(817, 424);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Bán Hàng";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem banHangToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kiemHangToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quanLyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem khoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cậpNhậtToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gốcToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem khácToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem giàyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem phụKiệnToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kháchHàngToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem hóaĐơnToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem thongKeToolStripMenuItem;

    }
}

