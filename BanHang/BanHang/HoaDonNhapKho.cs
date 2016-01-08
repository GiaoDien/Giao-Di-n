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
    public partial class HoaDonNhapKho : Form
    {
        public HoaDonNhapKho()
        {
            InitializeComponent();
        }
        Random rd = new Random();
        private void HoaDonNhapKho_Load(object sender, EventArgs e)
        {

            lblMahd.Text = "HĐNK" + rd.Next(1, 2000).ToString();
            lblNgay.Text = DateTime.Today.ToString();

        }
    }
}
