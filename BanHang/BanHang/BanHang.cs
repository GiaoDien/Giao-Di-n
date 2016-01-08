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
    public partial class BanHang : Form
    {
        public BanHang()
        {
            InitializeComponent();
        }
<<<<<<< HEAD
        
        
=======
<<<<<<< HEAD

>>>>>>> 95c9307d8cfe968163844108b14ef33679d62c9c
        private void button3_Click(object sender, EventArgs e)
        {
            HoaDonBanHang hoadon = new HoaDonBanHang();
           // hoadon.MdiParent = this;
            hoadon.Show();
        }
<<<<<<< HEAD

        bool BUT = true; // Ktriem da chọn Loại Sp chưa
        private void cbSP_SelectedIndexChanged(object sender, EventArgs e)
        {

            string a = cbSP.SelectedItem.ToString();

            cbMa.DisplayMember = "MASP";
            cbMa.ValueMember = "MASP";

            comboBox4.DisplayMember = "HANG";
            comboBox4.ValueMember = "HANG";

            cbLoai.DisplayMember = "TENSP";
            cbLoai.ValueMember = "TENSP";

            cbSize.DisplayMember = "SIZE";
            cbSize.ValueMember = "SIZE";

            cbGia.DisplayMember = "GIA";
            cbGia.ValueMember = "GIA";
            if (a == "Giay")
            {
                cbMa.DataSource = Model.GettblThongvaSPItems();
                cbSize.DataSource = Model.GettblThongvaSPItems();
                comboBox4.DataSource = Model.GettblThongvaSPItems();
                cbLoai.DataSource = Model.GettblThongvaSPItems();
            }
            else
            {
                cbMa.DataSource = Model.GettblThongvaSPPKItems();
                cbSize.DataSource = Model.GettblThongvaSPPKItems();
                comboBox4.DataSource = Model.GettblThongvaSPPKItems();
                cbLoai.DataSource = Model.GettblThongvaSPPKItems();
            }
            BUT = false;
        }

        private void cbMa_SelectedValueChanged(object sender, EventArgs e)
        {
            if (BUT == false)
            {
                string a = cbMa.SelectedValue.ToString();
                cbLoai.DisplayMember = "TENSP";
                cbLoai.ValueMember = "TENSP";
                cbLoai.DataSource = Model.GetCombo(a);

                comboBox4.DisplayMember = "HANG";
                comboBox4.ValueMember = "HANG";
                comboBox4.DataSource = Model.GetCombo(a);

                cbGia.DisplayMember = "GIA";
                cbGia.ValueMember = "GIA";
                cbGia.DataSource = Model.GetCombo(a);

                cbSize.DisplayMember = "SIZE";
                cbSize.ValueMember = "SIZE";
                cbSize.DataSource = Model.GetCombo(a);

            }
        }

        //add vào datagrid
        private void add()
        {
            BanHang_dataGridView1.Rows.Add(1);
            int indexRow = BanHang_dataGridView1.Rows.Count - 1;
            BanHang_dataGridView1[0, indexRow].Value = cbMa.SelectedValue;
            BanHang_dataGridView1[1, indexRow].Value = cbLoai.SelectedValue;
            BanHang_dataGridView1[2, indexRow].Value = cbSize.SelectedValue;
            BanHang_dataGridView1[3, indexRow].Value = cbSize.SelectedValue;
            BanHang_dataGridView1[4, indexRow].Value = txtSL.Text;
            BanHang_dataGridView1[5, indexRow].Value = Convert.ToInt32(txtSL.Text) * Convert.ToInt32(cbGia.SelectedValue);
        }

        int kq = 0;
        public void btnadd_Click(object sender, EventArgs e)
        {
            //add vào datagrid
            BanHang_dataGridView1.AllowUserToAddRows = false;
            add();

            //Tính tổng tiền
            kq+=Convert.ToInt32(Convert.ToInt32(txtSL.Text) * Convert.ToInt32(cbGia.SelectedValue));
            txtTong.Text = Convert.ToString(kq);

            
        }

        //xóa ra khỏi datagrid
        public void btnDelete_Click(object sender, EventArgs e)
        {
            string a = BanHang_dataGridView1.CurrentRow.Cells["thanhtien"].Value.ToString();
            kq = Convert.ToInt32(txtTong.Text);
            kq -= Convert.ToInt32(a);
            txtTong.Text = Convert.ToString(kq);
            
            //tổng tiền khi xóa đi
           int rowindex = BanHang_dataGridView1.CurrentRow.Index;
           BanHang_dataGridView1.Rows.RemoveAt(rowindex);
        }

        private void txtTienThua_MouseClick(object sender, MouseEventArgs e)
        {
            //Tiền thừa, Nhận
            int tienthua = Convert.ToInt32(txtNhan.Text) - Convert.ToInt32(txtTong.Text);
            txtTienThua.Text = tienthua.ToString();

            BHandHDKH.tong = txtTong.Text;
            BHandHDKH.tiennhan = txtNhan.Text;
            BHandHDKH.tienthua = txtTienThua.Text;
        }

        private void btnThongtinKH_Click(object sender, EventArgs e)
        {

        }
        
=======
=======
>>>>>>> ecd4de2248e840fef2355742d63529bc5e5aea3b
>>>>>>> 95c9307d8cfe968163844108b14ef33679d62c9c
    }
}
