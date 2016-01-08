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
<<<<<<< HEAD
        Random rd = new Random();
        private void HoaDonNhapKho_Load(object sender, EventArgs e)
        {

            lblMahd.Text = "HĐNK" + rd.Next(1, 2000).ToString();
            lblNgay.Text = DateTime.Today.ToString();

        }
=======
>>>>>>> 95c9307d8cfe968163844108b14ef33679d62c9c
    }
}
