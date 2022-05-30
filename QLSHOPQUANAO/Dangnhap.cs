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
using QLSHOPQUANAO.GUI;

namespace QLSHOPQUANAO
{
    public partial class Dangnhap : Form
    {
        Login Login = new Login();
        public Dangnhap()
        {
            InitializeComponent();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            var x = Login.funtionLogin(textBox1.Text,textBox2.Text);
            if (x == true)
            {
                Form1 frm = new Form1(Login.getMANV(textBox1.Text));
                frm.Show();
                this.Hide();
            }
            else
                MessageBox.Show("dang nhap that bai");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
