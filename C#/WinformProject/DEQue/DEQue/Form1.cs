namespace DEQue
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            lblSize.Text = "";
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

        class DEQueLinked
        {
            Node front;
            Node rear;
            int size;

            public DEQueLinked()
            {
                front = null;
                rear = null;
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

            public void AddLast(int e)
            {
                Node newest = new Node(e, null);
                if (IsEmpty())
                {
                    front = newest;
                }
                else
                {
                    rear.next = newest;
                }
                rear = newest;
                size++;
            }

            public void AddFirst(int e)
            {
                Node newest = new Node(e, null);
                if (IsEmpty())
                {
                    rear = newest;
                }
                else
                {
                    newest.next = front;
                }
                front = newest;
                size++;
            }

            public int RemoveFirst()
            {
                int e;
                if (IsEmpty())
                {
                    Console.WriteLine("DEQue is Empty");
                    e = -1;
                }
                else
                {
                    e = front.element;
                    front = front.next;
                    size--;
                }
                return e;
            }

            public int RemoveLast()
            {
                int e;
                if (IsEmpty())
                {
                    Console.WriteLine("DEQue is Empty");
                    e = -1;
                }
                else
                {
                    int i = 1;
                    Node p = front;
                    while (i < (Length() - 1))
                    {
                        p = p.next;
                        i++;
                    }
                    rear = p;
                    p = p.next;
                    e = p.element;
                    rear.next = null;
                    size--;
                }
                return e;
            }

            public int First()
            {
                int e;
                if (IsEmpty())
                {
                    Console.WriteLine("DEQue is Empty");
                    e = -1;
                }
                else
                    e = front.element;
                return e;
            }

            public int Last()
            {
                int e;
                if (IsEmpty())
                {
                    Console.WriteLine("DEQue is Empty");
                    e = -1;
                }
                else
                    e = rear.element;
                return e;
            }
            public IEnumerator<int> GetEnumerator()
            {
                Node p = front;
                while (p != null)
                {
                    yield return p.element;
                    p = p.next;
                }

            }
        }
        DEQueLinked deq = new DEQueLinked();
        private void btnClear_Click(object sender, EventArgs e)
        {
            txtAdd.Clear();
            txtAdd.Focus();
        }

        private void btnAddFirst_Click(object sender, EventArgs e)
        {
            txtDEQue.Clear();
            deq.AddFirst(int.Parse(txtAdd.Text));
            lblSize.Text = "Size: " + deq.Length().ToString();
            foreach (int item in deq)
            {
                txtDEQue.AppendText(item.ToString() + "-->");
            }

        }

        private void btnAddLast_Click(object sender, EventArgs e)
        {
            txtDEQue.Clear();
            deq.AddLast(int.Parse(txtAdd.Text));
            lblSize.Text = "Size: " + deq.Length().ToString();
            foreach (int item in deq)
            {
                txtDEQue.AppendText(item.ToString() + "-->");
            }
        }

        private void btnRemoveFirst_Click(object sender, EventArgs e)
        {
            txtDEQue.Clear();
            deq.RemoveFirst();
            lblSize.Text = "Size: " + deq.Length().ToString();
            foreach (int item in deq)
            {
                txtDEQue.AppendText(item.ToString() + "-->");
            }
        }

        private void btnRemoveLast_Click(object sender, EventArgs e)
        {
            txtDEQue.Clear();
            deq.RemoveLast();
            lblSize.Text = "Size: " + deq.Length().ToString();
            foreach (int item in deq)
            {
                txtDEQue.AppendText(item.ToString() + "-->");
            }
        }

        private void btnFirst_Click(object sender, EventArgs e)
        {
            txtFirst.Clear();
            deq.First();
            txtFirst.Text = deq.First().ToString();
        }

        private void btnLast_Click(object sender, EventArgs e)
        {
            txtLast.Clear();
            deq.Last();
            txtLast.Text = deq.Last().ToString();
        }
    }
}