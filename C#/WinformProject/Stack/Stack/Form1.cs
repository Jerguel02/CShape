namespace Stack
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
        class StacksArray
        {
            int[] data;
            int top;

            public StacksArray(int n)
            {
                data = new int[n]; // create Array which has n elements
                top = 0;
            }

            public int Length()
            {
                return top;
            }

            public bool IsEmpty()
            {
                return top == 0;
            }

            public bool IsFull()
            {
                return top == data.Length;
            }

            // Insert 
            public void Push(int e)
            {
                if (IsFull())
                {
                    Console.WriteLine("Stack is Full/Overflow");
                }
                else
                {
                    data[top] = e;
                    top++;
                }
            }
            // Remove the last element
            public int Pop()
            {
                int e;
                if (IsEmpty())
                {
                    Console.WriteLine("Stack is Empty");
                    e = -1;
                }
                else
                {
                    e = data[top - 1];
                    top--;

                }
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
                    e = data[top - 1];
                }
                return e;
            }

            public IEnumerator<int> GetEnumerator()
            {
                for (int i = 0; i < top; i++)
                {
                    yield return data[i];
                }

            }
        }
        StacksArray stack = new StacksArray(10);
        int l;
        private void Push_Click(object sender, EventArgs e)
        {
            txtKQ.Clear();

            stack.Push(int.Parse(txtAdd.Text));
            Sizelbl.Text = "Size: " + stack.Length().ToString();
            foreach (int item in stack)
            {
                txtKQ.AppendText(item.ToString() + "--");
            }
        }

        private void btnclr_Click(object sender, EventArgs e)
        {
            txtAdd.Clear();
            txtAdd.Focus();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            txtKQ.Clear();

            stack.Pop();
            Sizelbl.Text = "Size: "  + stack.Length().ToString();
            foreach (int item in stack)
            {
                txtKQ.AppendText(item.ToString() + "--");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            txtKQ.Clear();

        }

        private void button3_Click(object sender, EventArgs e)
        {
           

            
            peekelement.Text = stack.Peek().ToString();


        }

        private void Sizelbl_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            peekelement.Clear();
        }
    }
}