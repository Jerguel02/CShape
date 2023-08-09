using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LinkedList
{
    
    public partial class Form1 : Form
    {
        

        public class Node
        {
            public int element;
            public Node next;
            public Node(int e, Node n)
            {
                element = e;
                next = n;
            }
        }
        class LinkedList
        {
            private Node head;
            private Node tail;
            private int size;
            public LinkedList()
            {
                head = null;
                tail = null;
                size = 0;
            }
            public int length()
            {
                return size+1;
            }
            public bool isempty()
            {
                return size == 0;
            }
            public void addFirst(int e)
            {
                Node newest = new Node(e, null);
                if (isempty())
                {
                    head = newest;
                    tail = newest;
                }
                else
                {
                    newest.next = head;
                    head = newest;
                }
                size++;
            }
            public void addLast(int e)
            {
                Node newest = new Node(e, null);
                if (isempty())
                    head = newest;
                else
                    tail.next = newest;
                tail = newest;
                size = size + 1;
            }
            public void addany(int e, int position)
            {
                Node newest = new Node(e, null);
                Node p = head;
                int i = 1;
                if (position <= 0 || position >= size)
                {
                    Console.WriteLine("Invalid");
                    return;
                }
                while (i < (position - 1))
                {
                    p = p.next;
                    i++;
                }
                newest.next = p.next;
                p.next = newest;
                size++;
            }
            public int removeFirst()
            {
                if ((isempty()))
                {
                    Console.WriteLine("List is Empty");
                    return -1;
                }
                else
                {
                    int e = head.element;
                    head = head.next;
                    size = size - 1;
                    if (isempty())
                        tail = null;
                    return e;
                }
            }
           
            public IEnumerator<int> GetEnumerator()
            {
                Node p = head;
                while (p != null)
                {
                    yield return p.element;
                    p = p.next;
                }
                
            }
        }
       
        LinkedList link = new LinkedList();
        int length;
        public Form1()
        {
            InitializeComponent();
            sizetxt.Text = "0";
        }
        

       
       
        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            length = link.length();
            sizetxt.Text = length.ToString();
            int result = 0;
            if (string.IsNullOrEmpty(txtAdd.Text))
            {
                MessageBox.Show("Vui lòng nhập giá trị cần thêm", "Thông báo", MessageBoxButtons.OK);
            }
            else if (!Int32.TryParse(txtAdd.Text, out result))
            {
                MessageBox.Show("Vui lòng nhập giá trị nguyên", "Thông báo", MessageBoxButtons.OK);
            }
            else if (!Int32.TryParse(txtPosition.Text, out result) && !string.IsNullOrEmpty(txtPosition.Text))
            {
                MessageBox.Show("Vui lòng nhập giá trị nguyên", "Thông báo", MessageBoxButtons.OK);
            }
            

            else {  
          
            if (string.IsNullOrEmpty(txtPosition.Text))
            {
                
            }
        
            else
            {
                radiobtnFirst.Checked = false;
                radiobtnLast.Checked = false;
                if (radiobtnFirst.Checked == false && radiobtnLast.Checked == false)
                link.addany(int.Parse(txtAdd.Text), int.Parse(txtPosition.Text));  
            }
         
            if (radiobtnFirst.Checked == true)
            {
                link.addFirst(int.Parse(txtAdd.Text));
            }
            else if (radiobtnLast.Checked == true)
            {
                link.addLast(int.Parse(txtAdd.Text));
            }
         
            }
       
            txtKQ.Clear();
            foreach (int item in link)
            {
             
                txtKQ.AppendText(item.ToString() + "; ");
            }


        }

        private void btnViTri_Click(object sender, EventArgs e)
        {
           
        }

        private void txtKQ_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtAdd_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void txtPosition_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void btnClrAdd_Click(object sender, EventArgs e)
        {
            txtAdd.Clear();
            txtAdd.Focus();
        }

        private void btnClrPos_Click(object sender, EventArgs e)
        {
            txtPosition.Clear();
            txtPosition.Focus();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            for (int i = 200; i-->0;)
            {
                link.removeFirst();
            }
            radiobtnFirst.Checked = false;
            radiobtnLast.Checked = false;
            sizetxt.Text = "0";
            txtAdd.Clear();
            txtPosition.Clear();
            txtKQ.Clear();
            txtAdd.Focus();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn thoát khỏi chương trình?","Quit", MessageBoxButtons.YesNo) == DialogResult.Yes)
                this.Close();
        }   

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            
        }

        private void sizetxt_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            link.removeFirst();
            
            length = link.length() - 1;
            sizetxt.Text = length.ToString();
            txtKQ.Clear();
            foreach (int item in link)
            {
                txtKQ.AppendText(item.ToString() + "; ");

            }
            
        }

        private void radiobtnFirst_CheckedChanged(object sender, EventArgs e)
        {
            
        }
    }
}
