using System;
<<<<<<< HEAD
using BanHang;
=======
>>>>>>> 95c9307d8cfe968163844108b14ef33679d62c9c
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

<<<<<<< HEAD

=======
>>>>>>> 95c9307d8cfe968163844108b14ef33679d62c9c
namespace BanHang
{
    public partial class HoaDonBanHang : Form
    {
<<<<<<< HEAD
        Random rd = new Random();
       
=======
>>>>>>> 95c9307d8cfe968163844108b14ef33679d62c9c
        public HoaDonBanHang()
        {
            InitializeComponent();
        }
<<<<<<< HEAD

       

        private void HoaDonBanHang_Load(object sender, EventArgs e)
        {
            lblMahoadon.Text = "MAHD" + rd.Next(1, 50000).ToString();
            lblNgay.Text = DateTime.Today.ToString();
            lblTongcong.Text = BHandHDKH.tong;
            lblNhan.Text = BHandHDKH.tiennhan;
            lblThoilai.Text = BHandHDKH.tienthua;
           
        }
=======
>>>>>>> 95c9307d8cfe968163844108b14ef33679d62c9c
    }
}
