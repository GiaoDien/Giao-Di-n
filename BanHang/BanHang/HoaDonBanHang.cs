using System;
using BanHang;
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
    public partial class HoaDonBanHang : Form
    {
        Random rd = new Random();
       
        public HoaDonBanHang()
        {
            InitializeComponent();
        }

       

        private void HoaDonBanHang_Load(object sender, EventArgs e)
        {
            lblMahoadon.Text = "MAHD" + rd.Next(1, 50000).ToString();
            lblNgay.Text = DateTime.Today.ToString();
            lblTongcong.Text = BHandHDKH.tong;
            lblNhan.Text = BHandHDKH.tiennhan;
            lblThoilai.Text = BHandHDKH.tienthua;
           
        }
    }
}
