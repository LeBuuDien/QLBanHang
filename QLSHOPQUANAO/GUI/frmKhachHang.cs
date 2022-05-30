using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QLSHOPQUANAO.BLL;

namespace QLSHOPQUANAO.GUI
{
    public partial class frmKhachHang : Form
    {
        DAO_KhachHang khachHang = new DAO_KhachHang();
        public frmKhachHang()
        {
            InitializeComponent();
        }

        private void frmKhachHang_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = khachHang.LoadCustomer();
            Random random = new Random();
            int a = random.Next(1, 100);
            string maKH = "KH0" + a;
            txtMakh.Text = maKH;
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
            this.Hide();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (khachHang.addCustomer(txtMakh.Text, txtTen.Text, dtNgaySinh.Text, txtGT.Text, txtEmail.Text, txtDiachi.Text, txtSDT.Text))
            {
                MessageBox.Show("succesfull");
                dataGridView1.DataSource = khachHang.LoadCustomer();
            }
            else
            {
                MessageBox.Show("something wrong, try again");
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (khachHang.deleteCustomer(dataGridView1.CurrentRow.Cells[0].Value.ToString()))
            {
                MessageBox.Show("succesfull");
                dataGridView1.DataSource = khachHang.LoadCustomer();
            }
            else
            {
                MessageBox.Show("something wrong, try again");
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            string makh = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            string ten = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            string ngaySinh = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            string email = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            string gioiTinh = dataGridView1.CurrentRow.Cells[4].Value.ToString();
            string diaChi = dataGridView1.CurrentRow.Cells[5].Value.ToString();
            string sdt = dataGridView1.CurrentRow.Cells[6].Value.ToString();

            if (khachHang.updatecustomer(makh, ten, ngaySinh, email, gioiTinh, diaChi, sdt) == true)
            {
                MessageBox.Show("1");
            }
            else
                MessageBox.Show("2");
            
        }
    }
}
