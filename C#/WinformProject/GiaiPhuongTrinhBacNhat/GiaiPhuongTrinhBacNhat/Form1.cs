using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GiaiPhuongTrinhBacNhat
{
    public partial class Form1 : Form
    {
        double b, c;
        double nghiem;
        void Nhap()
        {
            b = double.Parse(txtB.Text);
            c = double.Parse(txtC.Text);

        }
        void Giai()
        {
            nghiem = -c / b;
        }
        void Xuat()
        {
            if (b == 0)
            {
                lblKetqua.Text = "Invalid";
            }
            else
            {
                lblKetqua.Text = nghiem.ToString();
            }
        }
        public Form1()
        {
            InitializeComponent();
        }

        private void btnGiai_Click(object sender, EventArgs e)
        {
            Nhap();
            Giai();
            Xuat();

        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            txtB.Clear();
            txtC.Clear();
            lblKetqua.Clear();
            txtB.Focus();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
