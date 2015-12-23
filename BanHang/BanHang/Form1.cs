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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void banHangToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BanHang frm = new BanHang();
            frm.MdiParent = this;
            frm.Show();
        }


 
    }
}
