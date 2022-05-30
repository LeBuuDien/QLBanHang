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

namespace QLSHOPQUANAO.GUI.frmADD
{
    public partial class frmADDSP : Form
    {
        DAO_SanPham sp = new DAO_SanPham();
        DAO_LoaiSP l = new DAO_LoaiSP();
        DAO_NhaCungCap ncc = new DAO_NhaCungCap();
        
        public frmADDSP()
        {
            InitializeComponent();
            cboLoai.DataSource = l.LoadLoai();
            cboLoai.DisplayMember = "TENLOAI";
            cboLoai.ValueMember = "MALOAI";
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            string maSP, MaLoai, maCC, tenSP, chatLieu, mauSac, moTa;
            double giaBan;
            int size, soLuongTon;
            maSP = txtMaSP.Text;
            MaLoai = cboLoai.SelectedValue.ToString();
            tenSP = txtSanpham.Text;
            maCC = cboNCC.SelectedValue.ToString() ;
            chatLieu = txtChatlieu.Text;
            mauSac = txtMausac.Text;
            moTa = txtMota.Text;
            giaBan = double.Parse(txtGiaban.Text);
            size = int.Parse(txtSize.Text);
            soLuongTon = int.Parse(txtSL.Text);
            if (sp.addSanPham(maSP, MaLoai, maCC, tenSP, giaBan, size, chatLieu, mauSac, soLuongTon, moTa) == true)
            {
                MessageBox.Show("succesfull");
            }
            else
            {
                MessageBox.Show("sorry, try again");
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            frmSanPham frmSanPham = new frmSanPham();
            frmSanPham.Show();
            this.Hide();
        }

        private void frmADDSP_Load(object sender, EventArgs e)
        {
            cboLoai.DataSource = l.LoadLoai();
            cboLoai.DisplayMember = "TENLOAI";
            cboLoai.ValueMember = "MALOAI";

            cboNCC.DataSource = ncc.LoadNCC();
            cboNCC.DisplayMember = "TENNCC";
            cboNCC.ValueMember = "MACC";
        }
    }
}
