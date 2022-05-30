namespace QLSHOPQUANAO.GUI
{
    partial class finishBill
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.lbMaNV = new System.Windows.Forms.Label();
            this.lbNgayLapHD = new System.Windows.Forms.Label();
            this.lbMaKH = new System.Windows.Forms.Label();
            this.lbMHD = new System.Windows.Forms.Label();
            this.txtMaHD = new System.Windows.Forms.TextBox();
            this.txtMKH = new System.Windows.Forms.TextBox();
            this.txtMaNV = new System.Windows.Forms.TextBox();
            this.txtDate = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lbTongTien = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(30, 204);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(414, 216);
            this.dataGridView1.TabIndex = 0;
            // 
            // lbMaNV
            // 
            this.lbMaNV.AutoSize = true;
            this.lbMaNV.Location = new System.Drawing.Point(28, 115);
            this.lbMaNV.Name = "lbMaNV";
            this.lbMaNV.Size = new System.Drawing.Size(72, 13);
            this.lbMaNV.TabIndex = 18;
            this.lbMaNV.Text = "Mã nhân viên";
            // 
            // lbNgayLapHD
            // 
            this.lbNgayLapHD.AutoSize = true;
            this.lbNgayLapHD.Location = new System.Drawing.Point(27, 152);
            this.lbNgayLapHD.Name = "lbNgayLapHD";
            this.lbNgayLapHD.Size = new System.Drawing.Size(92, 13);
            this.lbNgayLapHD.TabIndex = 12;
            this.lbNgayLapHD.Text = "Ngày lập hóa đơn";
            // 
            // lbMaKH
            // 
            this.lbMaKH.AutoSize = true;
            this.lbMaKH.Location = new System.Drawing.Point(28, 81);
            this.lbMaKH.Name = "lbMaKH";
            this.lbMaKH.Size = new System.Drawing.Size(82, 13);
            this.lbMaKH.TabIndex = 13;
            this.lbMaKH.Text = "Mã khách hàng";
            // 
            // lbMHD
            // 
            this.lbMHD.AutoSize = true;
            this.lbMHD.Location = new System.Drawing.Point(28, 50);
            this.lbMHD.Name = "lbMHD";
            this.lbMHD.Size = new System.Drawing.Size(65, 13);
            this.lbMHD.TabIndex = 14;
            this.lbMHD.Text = "Mã hóa đơn";
            // 
            // txtMaHD
            // 
            this.txtMaHD.Location = new System.Drawing.Point(159, 50);
            this.txtMaHD.Name = "txtMaHD";
            this.txtMaHD.Size = new System.Drawing.Size(100, 20);
            this.txtMaHD.TabIndex = 19;
            // 
            // txtMKH
            // 
            this.txtMKH.Location = new System.Drawing.Point(159, 78);
            this.txtMKH.Name = "txtMKH";
            this.txtMKH.Size = new System.Drawing.Size(100, 20);
            this.txtMKH.TabIndex = 20;
            // 
            // txtMaNV
            // 
            this.txtMaNV.Location = new System.Drawing.Point(159, 112);
            this.txtMaNV.Name = "txtMaNV";
            this.txtMaNV.Size = new System.Drawing.Size(100, 20);
            this.txtMaNV.TabIndex = 21;
            // 
            // txtDate
            // 
            this.txtDate.Location = new System.Drawing.Point(159, 145);
            this.txtDate.Name = "txtDate";
            this.txtDate.Size = new System.Drawing.Size(100, 20);
            this.txtDate.TabIndex = 22;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(369, 426);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 23;
            this.button1.Text = "Thanh toán";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(30, 435);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 13);
            this.label1.TabIndex = 24;
            this.label1.Text = "Tổng hóa đơn";
            // 
            // lbTongTien
            // 
            this.lbTongTien.AutoSize = true;
            this.lbTongTien.Location = new System.Drawing.Point(112, 435);
            this.lbTongTien.Name = "lbTongTien";
            this.lbTongTien.Size = new System.Drawing.Size(25, 13);
            this.lbTongTien.TabIndex = 25;
            this.lbTongTien.Text = "000";
            this.lbTongTien.Click += new System.EventHandler(this.lbTongTien_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(369, 456);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 26;
            this.button2.Text = "In Hóa Đơn";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // finishBill
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(456, 511);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.lbTongTien);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtDate);
            this.Controls.Add(this.txtMaNV);
            this.Controls.Add(this.txtMKH);
            this.Controls.Add(this.txtMaHD);
            this.Controls.Add(this.lbMaNV);
            this.Controls.Add(this.lbNgayLapHD);
            this.Controls.Add(this.lbMaKH);
            this.Controls.Add(this.lbMHD);
            this.Controls.Add(this.dataGridView1);
            this.Name = "finishBill";
            this.Text = "finishBill";
            this.Load += new System.EventHandler(this.finishBill_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label lbMaNV;
        private System.Windows.Forms.Label lbNgayLapHD;
        private System.Windows.Forms.Label lbMaKH;
        private System.Windows.Forms.Label lbMHD;
        private System.Windows.Forms.TextBox txtMaHD;
        private System.Windows.Forms.TextBox txtMKH;
        private System.Windows.Forms.TextBox txtMaNV;
        private System.Windows.Forms.TextBox txtDate;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbTongTien;
        private System.Windows.Forms.Button button2;
    }
}