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
using QLSHOPQUANAO.DTO;

namespace QLSHOPQUANAO.GUI
{
    public partial class frmHoaDon : Form
    {
        DAO_KhachHang kh = new DAO_KhachHang();
        DAO_NhanVien nv = new DAO_NhanVien();
        DAO_SanPham sp = new DAO_SanPham();
        DAO_HoaDon HoaDon = new DAO_HoaDon();
        public frmHoaDon()
        {
            InitializeComponent();
        }

        private void frmHoaDon_Load(object sender, EventArgs e)
        {
            Random random = new Random();
            int x = random.Next(1000);
            txtMaHD.Text = x.ToString();

            cboManv.DataSource = nv.LoadStaff();
            cboManv.DisplayMember = "TENNV";
            cboManv.ValueMember = "MaNV";

            cboKH.DataSource = kh.LoadCustomer();
            cboKH.DisplayMember = "TENKH";
            cboKH.ValueMember = "MAKH";

            dtNgay.Value = DateTime.Now;

            cboSP.DataSource = sp.LoadSanPham();
            cboSP.DisplayMember = "MASP";
            cboSP.ValueMember = "MASP";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            finishBill finishBill = new finishBill(txtMaHD.Text,cboKH.SelectedValue.ToString(),cboManv.SelectedValue.ToString(),dtNgay.Text);
            finishBill.Show();
            this.Hide();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (HoaDon.addBill(txtMaHD.Text, dtNgay.Text, cboKH.SelectedValue.ToString(), cboManv.SelectedValue.ToString()))
            {
                MessageBox.Show("succesfull");
                txtSL.Enabled = txtGia.Enabled = cboSP.Enabled = true;

            }
            else
                MessageBox.Show("something wrong, try again");
        }

        private void btnAddBillInfor_Click(object sender, EventArgs e)
        {
            if (HoaDon.addBillInformation(txtMaHD.Text,cboSP.Text,int.Parse(txtSL.Text),int.Parse(txtGia.Text),double.Parse(txtTongtien.Text)))
            {
                MessageBox.Show("succesfull");
                txtGia.Text = txtTongtien.Text = "0";
            }
            else
                MessageBox.Show("something wrong, try again");
            
        }

        private void cboSP_SelectedIndexChanged(object sender, EventArgs e)
        {
          //  txtGia.Text = HoaDon.loadGiaSP(cboSP.SelectedValue.ToString());
        }

        private void txtSL_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtGia_TextChanged(object sender, EventArgs e)
        {
            if (txtGia.Text=="")
            {
                
            }
            else
            {
            int gia = int.Parse(txtGia.Text);
            int sl = int.Parse(txtSL.Text);
            txtTongtien.Text = (0 + gia * sl).ToString();
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
            this.Hide();
        }
    }
}
