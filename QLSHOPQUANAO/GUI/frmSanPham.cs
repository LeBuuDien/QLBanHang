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
using QLSHOPQUANAO.GUI.frmADD;

namespace QLSHOPQUANAO.GUI
{
    public partial class frmSanPham : Form
    {
        DAO_SanPham sanPham = new DAO_SanPham();
        public frmSanPham()
        {
            InitializeComponent();
        }

        private void frmSanPham_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = sanPham.LoadSanPham();
        }

        private void btnADD_Click(object sender, EventArgs e)
        {
            frmADDSP frmADDSP = new frmADDSP();
            frmADDSP.ShowDialog();
            this.Hide();
        }

        private void BtnBack_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
            this.Hide();
        }
    }
}
