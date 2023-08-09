using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CongTruNhanChia
{
    public partial class Form1 : Form
    {
        double a, b, cong, tru, nhan, chia;

        private void btnNhan_Click(object sender, EventArgs e)
        {
            lblKetqua.Clear();
            Nhap();
            nhan = a * b;
            lblKetqua.Text = nhan.ToString();
        }

        private void btnChia_Click(object sender, EventArgs e)
        {
            lblKetqua.Clear();
            Nhap();
            if (b == 0)
            {
                txtB.Clear();
                txtB.Focus();
                MessageBox.Show("Invalid");
                
            }
            else
            {
                chia = a / b;
                lblKetqua.Text = chia.ToString();
            }
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            txtA.Clear();
            txtB.Clear();
            lblKetqua.Clear();
            txtA.Focus();
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnTru_Click(object sender, EventArgs e)
        {
            lblKetqua.Clear();
            Nhap();
            tru = a - b;
            lblKetqua.Text = tru.ToString();
        }

        private void btnCong_Click(object sender, EventArgs e)
        {
            lblKetqua.Clear();
            Nhap();
            cong = a + b;
            lblKetqua.Text = cong.ToString();
        }


        void Nhap()
        {
            a = Double.Parse(txtA.Text);
            b = Double.Parse(txtB.Text);
        }
      


        public Form1()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
