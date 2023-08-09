namespace Queue_LL
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            lblSize.Text = "";
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

        class QueueLinkedClass
        {
            Node front;
            Node rear;
            int size;

            public QueueLinkedClass()
            {
                front = null;
                rear = null;
                size = 0;
            }

            public int len()
            {
                return size;
            }

            public bool IsEmpty()
            {
                return size == 0;
            }

            public void EnQueue(int e)
            {
                Node newest = new Node(e, null);
                if (IsEmpty())
                {
                    front = newest;
                    rear = newest;
                }
                else
                {
                    rear.next = newest;
                    rear = newest;
                }
                size++;
            }
            // Delete the 1st element
            public int DeQueue()
            {
                int e;
                Node p = front;
                int i;
                if (IsEmpty())
                {
                    Console.WriteLine("Queue is Empty");
                    e = -1;
                }
                else
                {
                    e = front.element;
                    front = front.next;
                }
                if (IsEmpty())
                    rear = null;
                size--;
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
        QueueLinkedClass q = new QueueLinkedClass();
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            txtQueue.Clear();
            q.EnQueue(int.Parse(txtAdd.Text));
            lblSize.Text = "Size: " + q.len().ToString();
            foreach (int item in q)
            {
                txtQueue.AppendText(item.ToString() + "-->");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            txtQueue.Clear();
            q.DeQueue();
            lblSize.Text = "Size: " + q.len().ToString();
            foreach (int item in q)
            {
                txtQueue.AppendText(item.ToString() + "-->");
            }
        }
    }
}