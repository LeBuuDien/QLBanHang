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
    public partial class frmNhanVien : Form
    {
        DAO_NhanVien nv = new DAO_NhanVien();
        public frmNhanVien()
        {
            InitializeComponent();
        }

        private void frmNhanVien_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = nv.LoadStaff();
        }


        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string manv = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            string ten = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            string chucvu = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            string ngaySinh = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            string gioiTinh = dataGridView1.CurrentRow.Cells[4].Value.ToString();
            string diaChi = dataGridView1.CurrentRow.Cells[5].Value.ToString();
            string sdt = dataGridView1.CurrentRow.Cells[6].Value.ToString();
            string userName = dataGridView1.CurrentRow.Cells[7].ToString();
            string pw = dataGridView1.CurrentRow.Cells[8].Value.ToString();
            txtManv.Text = manv;
            txtTen.Text = ten;
            txtChucvu.Text = chucvu;
            dateTimePicker1.Text = ngaySinh;
            txtGT.Text = gioiTinh;
            txtDiachi.Text = diaChi;
            txtSDT.Text = sdt;
            txtTenDN.Text = userName;
            txtMK.Text = pw;
        }

        private void btnback_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
            this.Hide();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (nv.addStaff(txtManv.Text, txtTen.Text, txtChucvu.Text, dateTimePicker1.Text, txtGT.Text, txtDiachi.Text, txtSDT.Text, txtTenDN.Text, txtMK.Text))
            {
                MessageBox.Show("succesfull");
                dataGridView1.DataSource = nv.LoadStaff();
            }
            else
            {
                MessageBox.Show("try again");
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (nv.deleteStaff(dataGridView1.CurrentRow.Cells[0].Value.ToString()))
            {
                MessageBox.Show("succesfull");
                dataGridView1.DataSource = nv.LoadStaff();
            }
            else
            {
                MessageBox.Show("something wrong, try again");
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {

            if (nv.updateStaff(txtManv.Text, txtTen.Text, txtChucvu.Text, dateTimePicker1.Text, txtGT.Text, txtDiachi.Text, txtSDT.Text, txtTenDN.Text, txtMK.Text))
            {
                MessageBox.Show("succesfull");
                dataGridView1.DataSource = nv.LoadStaff();
            }
            else
            {
                MessageBox.Show("something wrong, try again");
            }
        }
    }
}
