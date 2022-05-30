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
    public partial class frmNhaCungCap : Form
    {
        DAO_NhaCungCap nhaCungCap = new DAO_NhaCungCap();
        public frmNhaCungCap()
        {
            InitializeComponent();
        }

        private void frmNhaCungCap_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = nhaCungCap.LoadNCC();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
            this.Hide();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {

        }
    }
}
