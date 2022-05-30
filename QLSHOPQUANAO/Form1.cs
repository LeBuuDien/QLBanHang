using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QLSHOPQUANAO.GUI;
using QLSHOPQUANAO.BLL;

namespace QLSHOPQUANAO
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public Form1(string a)
        {
            InitializeComponent();
            Login lg = new Login();
            if (lg.checkQuyen(a))
            {
                toolStripButton4.Enabled = toolStripButton5.Enabled = toolStripButton6.Enabled = true;
            }
        }
        private void toolStripButton7_Click(object sender, EventArgs e)
        {
            Dangnhap dn = new Dangnhap();
            dn.Show();
            this.Hide();
        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            frmKhachHang frmKhach = new frmKhachHang();
            frmKhach.Show();
            this.Hide();
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            frmSanPham frm = new frmSanPham();
            frm.Show();
            this.Hide();
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            frmHoaDon frmHoaDon = new frmHoaDon();
            frmHoaDon.Show();
            this.Hide();
        }

        private void toolStripButton4_Click(object sender, EventArgs e)
        {
            frmNhanVien frmNhanVien = new frmNhanVien();
            frmNhanVien.Show();
            this.Hide();
        }

        private void toolStripButton5_Click(object sender, EventArgs e)
        {
            frmNhapHang frmNhapHang = new frmNhapHang();
            frmNhapHang.Show();
            this.Hide();
        }

        private void toolStripButton6_Click(object sender, EventArgs e)
        {
            frmNhaCungCap frmNhaCungCap = new frmNhaCungCap();
            frmNhaCungCap.Show();
            this.Hide();
        }
    }
}
