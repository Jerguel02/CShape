namespace Queue
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            Sizelbl.Text = "";
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        class QueuesArray
        {
            int[] data;
            int front;
            int rear;
            int size;

            public QueuesArray(int n)
            {
                data = new int[n];
                front = 0;
                rear = 0;
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

            public bool IsFull()
            {
                return size == data.Length;
            }
            // Insert
            public void EnQueue(int e)
            {
                if (IsFull())
                {
                    Console.WriteLine("Queue is overflow");
                }
                else
                {
                    data[rear] = e;
                    rear++;
                    size++;
                }
            }
            // Remove 
            public int DeQueue()
            {
                int e;
                if (IsEmpty())
                {
                    Console.WriteLine("Queue is empty");
                    return -1;
                }
                else
                {
                    e = data[front];
                    front++;
                    size--;
                }
                return e;
            }
            // The 1st Element
            public int First()
            {
                int e;
                if (IsEmpty())
                {
                    Console.WriteLine("Queue is empty");
                    e = -1;
                }
                else
                {
                    e = data[front];
                }
                return e;
            }

            public IEnumerator<int> GetEnumerator()
            {
                for (int i = 0; i < rear; i++)
                    yield return data[i];


            }
        }
        QueuesArray q = new QueuesArray(10);
      
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            
            txtQueue.Clear();
            q.EnQueue(int.Parse(txtAdd.Text));
            foreach (int item in q)
            {
                txtQueue.AppendText(item.ToString() + "--");
            }
            Sizelbl.Text ="Size: " + q.len().ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            txtAdd.Clear();
            txtAdd.Focus();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
            txtFirst.Clear();
            txtFirst.Text = q.First().ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            txtQueue.Clear();

        }

        private void button4_Click(object sender, EventArgs e)
        {
            txtQueue.Clear();
            q.DeQueue();
            foreach (int item in q)
            {
                txtQueue.AppendText((string)item.ToString());
            }    
            Sizelbl.Text = "Size: " + q.len().ToString();
        }
    }
}