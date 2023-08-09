namespace StackLL
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
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

        class StacksLinkedList
        {
            Node top;
            int size;

            public StacksLinkedList()
            {
                top = null;
                size = 0;
            }

            public int Length()
            {
                return size;
            }

            public bool IsEmpty()
            {
                return size == 0;
            }

            public void Push(int e)
            {
                Node newest = new Node(e, null);
                if (IsEmpty())
                {
                    top = newest;
                }
                else
                {
                    newest.next = top;
                    top = newest;
                }
                size++;
            }

            public int Pop()
            {
                int e;
                if (IsEmpty())
                {
                    Console.WriteLine("Stack is empty");
                    e = -1;
                }
                else
                {
                    e = top.element;
                    top = top.next;
                }
                size--;
                return e;
            }

            public int Peek()
            {
                int e;
                if (IsEmpty())
                {
                    Console.WriteLine("Stack is empty");
                    e = -1;
                }
                else
                {
                    e = top.element;
                }
                return e;
            }
            public IEnumerator<int> GetEnumerator()
            {
                {
                    Node p = top;
                    while (p != null)
                    {
                        yield return (p.element);
                        p = p.next;
                    }

                }
            }
        }
        StacksLinkedList SL = new StacksLinkedList();
        private void btnPush_Click(object sender, EventArgs e)
        {
            txtKQ.Clear();
            SL.Push(int.Parse(txtAdd.Text));
            sizelbl.Text = SL.Length().ToString();
            foreach (int item in SL)
            {
                txtKQ.AppendText(item.ToString() + "-->");
            }


        }

        private void btnPop_Click(object sender, EventArgs e)
        {
            txtKQ.Clear();
            SL.Pop();
            sizelbl.Text = SL.Length().ToString();
            foreach (int item in SL)
            {
                txtKQ.AppendText((string)item.ToString() + "-->");
            }
        }

        private void btnPeek_Click(object sender, EventArgs e)
        {
            SL.Peek();
            txtPeek.Text = SL.Peek().ToString();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            txtAdd.Clear();
            txtAdd.Focus();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            txtKQ.Clear();
            
        }
    }
}