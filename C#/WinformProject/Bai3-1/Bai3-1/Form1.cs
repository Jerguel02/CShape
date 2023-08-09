using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bai3_1
{
    public partial class Form1 : Form
    {
        
        public Form1()
        {
            InitializeComponent();
        }
        private void btnPlay_Click(object sender, EventArgs e)
        { 
            OpenFileDialog dlg = new OpenFileDialog();

            DialogResult ret = dlg.ShowDialog();
 
            if (ret == DialogResult.OK)
                wmpPlay.URL = dlg.FileName;
        }

        private void Form1_SizeChanged(object sender, EventArgs e)
        {
            //xác ₫ịnh kích thước hiện hành của Form
            int cx = this.Size.Width;
            int cy = this.Size.Height;
            //thay ₫ổi vị trí của ₫ối tượng WMP về vị trí mong muốn
            wmpPlay.Location = new Point(10, 40);
            //thay ₫ổi kích thước của ₫ối tượng WMP theo kích thước Form
            wmpPlay.Size = new Size(cx - 30, cy - 80);

        }
    }
}
