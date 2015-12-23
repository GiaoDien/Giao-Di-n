using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BanHang
{
    public partial class KhoCapNhat : Form
    {
        public KhoCapNhat()
        {
            InitializeComponent();
        }

        private void xuấtHóaĐơnKhoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            HoaDonXuatKho xuatkho = new HoaDonXuatKho();
            xuatkho.Show();
        }
    }
}
