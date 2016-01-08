using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DataAccess;

namespace BanHang
{
    public partial class KhoGoc : Form
    {
        public KhoGoc()
        {
            InitializeComponent();
        }
<<<<<<< HEAD
=======
<<<<<<< HEAD
>>>>>>> 95c9307d8cfe968163844108b14ef33679d62c9c

        private void toolStripButton4_Click(object sender, EventArgs e)
        {
            HoaDonXuatKho xuatkho = new HoaDonXuatKho();
            xuatkho.Show();
        }
<<<<<<< HEAD


        private void KhoGoc_Load(object sender, EventArgs e)
        {
            KhoGocdataGridView1.DataSource = Model.GettblThongvaSPItems(); 
        }

        private void GiayMenuItem_Click(object sender, EventArgs e)
        {
            KhoGocdataGridView1.DataSource = Model.GettblThongvaSPItems(); 
        }

        private void PhuKienMenuItem_Click(object sender, EventArgs e)
        {
            KhoGocdataGridView1.DataSource = Model.GettblThongvaSPPKItems();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
         /*  var cur = KhoGocdataGridView1.DataSource as tblThongandSP;
         //  var cur1 = KhoGocdataGridView1.DataSource as tblThongTinSP;

           try
           {
               Model.DeleteKhoGoc(cur);
               Model.DeleteKhoGoc1(cur);
           }
           catch (Exception ex) { MessageBox.Show(ex.Message); };
*/        }

        private void KhoGocdataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            try
            {
                KhoGocdataGridView1.CurrentRow.Selected = true; //dữ liệu đuợc chọn cả dòng
            }
            catch { }
        }


=======
=======
>>>>>>> ecd4de2248e840fef2355742d63529bc5e5aea3b
>>>>>>> 95c9307d8cfe968163844108b14ef33679d62c9c
    }
}
