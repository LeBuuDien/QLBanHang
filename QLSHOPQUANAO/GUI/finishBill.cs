using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QLSHOPQUANAO.DTO;
using QLSHOPQUANAO.BLL;


namespace QLSHOPQUANAO.GUI
{
    public partial class finishBill : Form
    {
        DAO_HoaDon DAO_HoaDon = new DAO_HoaDon();
        ShopQuanAoDataContext SQA = new ShopQuanAoDataContext();
        public finishBill()
        {
            InitializeComponent();
        }
        public finishBill(string maHD,string maKH,string maNV,string nlhd)
        {
            InitializeComponent();
            txtMaHD.Text = maHD;
            this.txtMKH.Text = maKH;
            this.txtMaNV.Text = maNV;
            this.txtDate.Text = nlhd;

            dataGridView1.DataSource = (from q in SQA.CHITIETHDs
                                        where q.MAHD == maHD
                                        select new
                                        {
                                            q.MASP,
                                            q.SOLUONG,
                                            q.TONGTIEN
                                        }); 
        }

        private void finishBill_Load(object sender, EventArgs e)
        {   int sc = dataGridView1.Rows.Count;
            double thanhtien = 0;
            for (int i = 0; i <= sc-1; i++)
                thanhtien += double.Parse(dataGridView1.Rows[i].Cells[2].Value.ToString());
            lbTongTien.Text = thanhtien.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmThanhToan frmThanhToan = new frmThanhToan(lbTongTien.Text);
            frmThanhToan.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void lbTongTien_Click(object sender, EventArgs e)
        {

        }
    }
}
